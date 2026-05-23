using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.DirectX.DirectInput;
using System.Runtime.InteropServices;
using System.Text;

namespace DeviceLister
{
    public partial class DeviceListerForm : Form
    {
        private const int IdentifierDeviceInstanceId = 0;
        private const int IdentifierGuid = 1;
        private const int IdentifierProductName = 2;
        private const int TargetGameFolder = 0;
        private const int TargetAllPrograms = 1;
        private const int TargetSystem = 2;

        private readonly List<string> preservedOrderEntries = new List<string>();
        private readonly List<string> preservedHiddenEntries = new List<string>();
        private readonly List<string> preservedVisibleEntries = new List<string>();
        private string gameFolderPath;

        [DllImport("DIDeviceInputId.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetDeviceInstanceID(string input);

        private class DeviceEntry
        {
            public string ProductName;
            public string InstanceGuid;
            public string DeviceInstanceId;
            public bool HasDeviceInstanceId;

            public string FormattedGuid
            {
                get { return "{" + InstanceGuid + "}"; }
            }
        }

        private class IniConfig
        {
            public readonly List<string> Order = new List<string>();
            public readonly List<string> Hidden = new List<string>();
            public readonly List<string> Visible = new List<string>();
            public readonly List<string> IgnoredProcesses = new List<string>();
        }

        public DeviceListerForm()
        {
            InitializeComponent();
        }

        private void DeviceListerForm_Load(object sender, EventArgs e)
        {
            gameFolderPath = Application.StartupPath;

            identifierComboBox.Items.Add("Device instance ID (recommended)");
            identifierComboBox.Items.Add("Instance GUID");
            identifierComboBox.Items.Add("Product name");
            identifierComboBox.SelectedIndex = IdentifierDeviceInstanceId;

            targetComboBox.Items.Add("Selected game/program folder");
            targetComboBox.Items.Add("All programs (ProgramData)");
            targetComboBox.Items.Add("System-wide install");
            targetComboBox.SelectedIndex = TargetGameFolder;

            LoadDevices();
            UpdateTargetControls();
        }

        private void LoadDevices()
        {
            deviceListView.BeginUpdate();
            deviceListView.Items.Clear();

            try
            {
                foreach (DeviceInstance device in Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly))
                {
                    AddDevice(device);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "Unable to enumerate DirectInput game controllers." + Environment.NewLine + Environment.NewLine + ex.Message,
                    "DeviceLister",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                RefreshOrderColumn();
                deviceListView.EndUpdate();
                UpdateStatus();
            }
        }

        private void AddDevice(DeviceInstance device)
        {
            DeviceEntry entry = new DeviceEntry();
            entry.ProductName = device.ProductName;
            entry.InstanceGuid = device.InstanceGuid.ToString();
            entry.DeviceInstanceId = GetDeviceInstanceId(device.InstanceGuid.ToString(), out entry.HasDeviceInstanceId);

            ListViewItem item = new ListViewItem();
            item.Checked = true;
            item.Tag = entry;
            item.SubItems.Add(entry.ProductName);
            item.SubItems.Add(entry.FormattedGuid);
            item.SubItems.Add(entry.HasDeviceInstanceId ? "<" + entry.DeviceInstanceId + ">" : entry.DeviceInstanceId);

            deviceListView.Items.Add(item);
        }

        private string GetDeviceInstanceId(string instanceGuid, out bool success)
        {
            success = false;

            try
            {
                IntPtr resultPtr = GetDeviceInstanceID(instanceGuid);

                if (resultPtr == IntPtr.Zero)
                {
                    return "[failed to get device instance ID]";
                }

                string deviceInstanceId = Marshal.PtrToStringUni(resultPtr);
                if (String.IsNullOrEmpty(deviceInstanceId))
                {
                    return "[failed to get device instance ID]";
                }

                success = true;
                return deviceInstanceId;
            }
            catch (Exception ex)
            {
                return "[failed to get device instance ID: " + ex.Message + "]";
            }
        }

        private void RefreshOrderColumn()
        {
            for (int i = 0; i < deviceListView.Items.Count; ++i)
            {
                deviceListView.Items[i].Text = (i + 1).ToString();
            }
        }

        private void UpdateStatus()
        {
            int visibleCount = 0;
            int hiddenCount = 0;

            foreach (ListViewItem item in deviceListView.Items)
            {
                if (item.Checked)
                {
                    ++visibleCount;
                }
                else
                {
                    ++hiddenCount;
                }
            }

            string preservedText = GetPreservedEntryCount() > 0
                ? "; preserving " + GetPreservedEntryCount().ToString() + " unmatched config entries"
                : "";
            statusLabel.Text = visibleCount.ToString() + " visible, " + hiddenCount.ToString() + " hidden" + preservedText;
            UpdateConfigStatus();
        }

        private int GetPreservedEntryCount()
        {
            return preservedOrderEntries.Count + preservedHiddenEntries.Count + preservedVisibleEntries.Count;
        }

        private DeviceEntry GetEntry(ListViewItem item)
        {
            return (DeviceEntry)item.Tag;
        }

        private string GetIdentifier(DeviceEntry entry)
        {
            switch (identifierComboBox.SelectedIndex)
            {
                case IdentifierGuid:
                    return entry.FormattedGuid;
                case IdentifierProductName:
                    return entry.ProductName;
                case IdentifierDeviceInstanceId:
                default:
                    return entry.HasDeviceInstanceId ? "<" + entry.DeviceInstanceId + ">" : entry.FormattedGuid;
            }
        }

        private string GetCommonConfigPath()
        {
            return Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "devreorder"), "devreorder.ini");
        }

        private string GetSelectedConfigPath()
        {
            if (targetComboBox.SelectedIndex == TargetGameFolder)
            {
                return Path.Combine(GetGameFolderPath(), "devreorder.ini");
            }

            return GetCommonConfigPath();
        }

        private string GetGameFolderPath()
        {
            if (targetComboBox.SelectedIndex == TargetGameFolder)
            {
                gameFolderPath = targetPathTextBox.Text.Trim();
            }

            return String.IsNullOrEmpty(gameFolderPath) ? Application.StartupPath : gameFolderPath;
        }

        private void UpdateTargetControls()
        {
            bool gameFolderSelected = targetComboBox.SelectedIndex == TargetGameFolder;

            targetPathTextBox.ReadOnly = !gameFolderSelected;
            browseFolderButton.Enabled = gameFolderSelected;
            targetPathTextBox.Text = gameFolderSelected ? GetGameFolderPath() : GetCommonConfigPath();
            UpdateConfigStatus();
        }

        private void UpdateConfigStatus()
        {
            if (targetComboBox.SelectedIndex < 0)
            {
                return;
            }

            string configPath = GetSelectedConfigPath();
            string configStatus = File.Exists(configPath) ? "config present" : "config missing";

            if (targetComboBox.SelectedIndex == TargetGameFolder)
            {
                string folderPath = GetGameFolderPath();
                string folderStatus = Directory.Exists(folderPath) ? "folder present" : "folder missing";
                string dllPath = Path.Combine(folderPath, "dinput8.dll");
                string dllStatus = File.Exists(dllPath) ? "local dinput8.dll present" : "local dinput8.dll missing";
                targetStatusLabel.Text = folderStatus + "; " + configStatus + "; " + dllStatus + " - " + configPath;
            }
            else if (targetComboBox.SelectedIndex == TargetAllPrograms)
            {
                targetStatusLabel.Text = configStatus + " - games without a local devreorder.ini use " + configPath;
            }
            else
            {
                targetStatusLabel.Text = configStatus + "; " + GetSystemInstallStatus() + " - " + configPath;
            }
        }

        private string GetSystemInstallStatus()
        {
            string system32 = Environment.SystemDirectory;
            string system32Status = GetSystemDirectoryStatus(system32, "system32");
            string windowsDirectory = Environment.GetEnvironmentVariable("WINDIR");

            if (String.IsNullOrEmpty(windowsDirectory))
            {
                return system32Status + "; SysWOW64 not checked";
            }

            string sysWow64 = Path.Combine(windowsDirectory, "SysWOW64");
            if (!Directory.Exists(sysWow64))
            {
                return system32Status + "; SysWOW64 not present";
            }

            return system32Status + "; " + GetSystemDirectoryStatus(sysWow64, "SysWOW64");
        }

        private string GetSystemDirectoryStatus(string directory, string label)
        {
            string dinput = Path.Combine(directory, "dinput8.dll");
            string original = Path.Combine(directory, "dinput8org.dll");
            bool hasDinput = File.Exists(dinput);
            bool hasOriginal = File.Exists(original);

            if (hasDinput && hasOriginal)
            {
                return label + " appears installed";
            }

            if (hasDinput)
            {
                return label + " has dinput8.dll only";
            }

            return label + " missing dinput8.dll";
        }

        private void MoveSelectedItem(int direction)
        {
            if (deviceListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selectedItem = deviceListView.SelectedItems[0];
            int oldIndex = selectedItem.Index;
            int newIndex = oldIndex + direction;

            if (newIndex < 0 || newIndex >= deviceListView.Items.Count)
            {
                return;
            }

            deviceListView.BeginUpdate();
            deviceListView.Items.RemoveAt(oldIndex);
            deviceListView.Items.Insert(newIndex, selectedItem);
            selectedItem.Selected = true;
            selectedItem.Focused = true;
            RefreshOrderColumn();
            deviceListView.EndUpdate();
        }

        private void SetSelectedVisibility(bool visible)
        {
            if (deviceListView.SelectedItems.Count == 0)
            {
                return;
            }

            deviceListView.SelectedItems[0].Checked = visible;
            UpdateStatus();
        }

        private string BuildIni()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("; devreorder settings generated by DeviceLister");
            builder.AppendLine("; Drag devices in DeviceLister to change [order]; hide devices with [hidden] or [visible].");
            builder.AppendLine();
            builder.AppendLine("[order]");

            foreach (ListViewItem item in deviceListView.Items)
            {
                if (item.Checked)
                {
                    builder.AppendLine(GetIdentifier(GetEntry(item)));
                }
            }

            AppendPreservedEntries(builder, preservedOrderEntries);

            builder.AppendLine();
            builder.AppendLine("[hidden]");

            if (!visibleWhitelistCheckBox.Checked)
            {
                foreach (ListViewItem item in deviceListView.Items)
                {
                    if (!item.Checked)
                    {
                        builder.AppendLine(GetIdentifier(GetEntry(item)));
                    }
                }

                AppendPreservedEntries(builder, preservedHiddenEntries);
            }
            else
            {
                builder.AppendLine("; Hidden entries are unused while [visible] whitelist mode is enabled.");
            }

            builder.AppendLine();
            builder.AppendLine("[visible]");

            if (visibleWhitelistCheckBox.Checked)
            {
                foreach (ListViewItem item in deviceListView.Items)
                {
                    if (item.Checked)
                    {
                        builder.AppendLine(GetIdentifier(GetEntry(item)));
                    }
                }

                AppendPreservedEntries(builder, preservedVisibleEntries);
            }
            else
            {
                builder.AppendLine("; Leave this empty when using [hidden].");
            }

            builder.AppendLine();
            builder.AppendLine("[ignored processes]");
            AppendTextBoxLines(builder, ignoredProcessesTextBox);

            return builder.ToString();
        }

        private void AppendPreservedEntries(StringBuilder builder, List<string> entries)
        {
            foreach (string entry in entries)
            {
                builder.AppendLine(entry);
            }
        }

        private void AppendTextBoxLines(StringBuilder builder, TextBox textBox)
        {
            string[] lines = textBox.Text.Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                if (trimmedLine.Length > 0)
                {
                    builder.AppendLine(trimmedLine);
                }
            }
        }

        private string BuildDetailsText()
        {
            StringBuilder builder = new StringBuilder();

            foreach (ListViewItem item in deviceListView.Items)
            {
                DeviceEntry entry = GetEntry(item);
                builder.Append("\"");
                builder.Append(entry.ProductName);
                builder.Append("\": ");
                builder.Append(entry.FormattedGuid);
                builder.Append(" ");
                builder.Append(entry.HasDeviceInstanceId ? "<" + entry.DeviceInstanceId + ">" : entry.DeviceInstanceId);
                builder.AppendLine();
            }

            return builder.ToString();
        }

        private IniConfig ReadIni(string path)
        {
            IniConfig config = new IniConfig();
            string section = String.Empty;

            foreach (string rawLine in File.ReadAllLines(path))
            {
                string line = rawLine.Trim();

                if (line.Length == 0 || line.StartsWith(";"))
                {
                    continue;
                }

                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    section = line.Substring(1, line.Length - 2).Trim().ToLowerInvariant();
                    continue;
                }

                if (section == "order")
                {
                    config.Order.Add(line);
                }
                else if (section == "hidden")
                {
                    config.Hidden.Add(line);
                }
                else if (section == "visible")
                {
                    config.Visible.Add(line);
                }
                else if (section == "ignored processes")
                {
                    config.IgnoredProcesses.Add(line);
                }
            }

            return config;
        }

        private void ApplyConfig(IniConfig config)
        {
            preservedOrderEntries.Clear();
            preservedHiddenEntries.Clear();
            preservedVisibleEntries.Clear();

            deviceListView.BeginUpdate();

            foreach (ListViewItem item in deviceListView.Items)
            {
                item.Checked = true;
            }

            ApplyOrder(config.Order);
            ApplyVisibility(config);
            ignoredProcessesTextBox.Text = String.Join(Environment.NewLine, config.IgnoredProcesses.ToArray());

            RefreshOrderColumn();
            deviceListView.EndUpdate();
            UpdateStatus();
        }

        private void ApplyOrder(List<string> orderEntries)
        {
            List<ListViewItem> orderedItems = new List<ListViewItem>();
            List<ListViewItem> remainingItems = new List<ListViewItem>();

            foreach (ListViewItem item in deviceListView.Items)
            {
                remainingItems.Add(item);
            }

            foreach (string entry in orderEntries)
            {
                ListViewItem match = FindMatchingItem(entry, remainingItems);
                if (match == null)
                {
                    preservedOrderEntries.Add(entry);
                    continue;
                }

                orderedItems.Add(match);
                remainingItems.Remove(match);
            }

            deviceListView.Items.Clear();

            foreach (ListViewItem item in orderedItems)
            {
                deviceListView.Items.Add(item);
            }

            foreach (ListViewItem item in remainingItems)
            {
                deviceListView.Items.Add(item);
            }
        }

        private void ApplyVisibility(IniConfig config)
        {
            if (config.Visible.Count > 0)
            {
                visibleWhitelistCheckBox.Checked = true;

                foreach (ListViewItem item in deviceListView.Items)
                {
                    item.Checked = false;
                }

                foreach (string entry in config.Visible)
                {
                    ListViewItem match = FindMatchingItem(entry, deviceListView.Items);
                    if (match == null)
                    {
                        preservedVisibleEntries.Add(entry);
                    }
                    else
                    {
                        match.Checked = true;
                    }
                }
            }
            else
            {
                visibleWhitelistCheckBox.Checked = false;
            }

            foreach (string entry in config.Hidden)
            {
                ListViewItem match = FindMatchingItem(entry, deviceListView.Items);
                if (match == null)
                {
                    preservedHiddenEntries.Add(entry);
                }
                else
                {
                    match.Checked = false;
                }
            }
        }

        private ListViewItem FindMatchingItem(string entry, IEnumerable<ListViewItem> items)
        {
            foreach (ListViewItem item in items)
            {
                if (EntryMatchesDevice(entry, GetEntry(item)))
                {
                    return item;
                }
            }

            return null;
        }

        private ListViewItem FindMatchingItem(string entry, ListView.ListViewItemCollection items)
        {
            foreach (ListViewItem item in items)
            {
                if (EntryMatchesDevice(entry, GetEntry(item)))
                {
                    return item;
                }
            }

            return null;
        }

        private bool EntryMatchesDevice(string entry, DeviceEntry device)
        {
            string trimmedEntry = entry.Trim();

            if (trimmedEntry.Length == 0)
            {
                return false;
            }

            if (trimmedEntry.StartsWith("{"))
            {
                return String.Equals(trimmedEntry, device.FormattedGuid, StringComparison.OrdinalIgnoreCase);
            }

            if (trimmedEntry.StartsWith("<"))
            {
                return device.HasDeviceInstanceId && String.Equals(trimmedEntry, "<" + device.DeviceInstanceId + ">", StringComparison.OrdinalIgnoreCase);
            }

            return String.Equals(trimmedEntry, device.ProductName, StringComparison.Ordinal);
        }

        private void SaveConfigToPath(string path)
        {
            string directory = Path.GetDirectoryName(path);

            if (!String.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(path, BuildIni(), Encoding.UTF8);
            statusLabel.Text = "Saved " + path;
            UpdateConfigStatus();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(-1);
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(1);
        }

        private void hideSelectedButton_Click(object sender, EventArgs e)
        {
            SetSelectedVisibility(false);
        }

        private void showSelectedButton_Click(object sender, EventArgs e)
        {
            SetSelectedVisibility(true);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in deviceListView.Items)
            {
                item.Checked = true;
            }

            UpdateStatus();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string details = BuildDetailsText();

            if (details.Length > 0)
            {
                Clipboard.SetText(details);
                statusLabel.Text = "Device details copied to clipboard";
            }
        }

        private void loadConfigButton_Click(object sender, EventArgs e)
        {
            string path = GetSelectedConfigPath();

            if (!File.Exists(path))
            {
                MessageBox.Show(this,
                    "No devreorder.ini exists for the selected target." + Environment.NewLine + Environment.NewLine + path,
                    "DeviceLister",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                UpdateConfigStatus();
                return;
            }

            ApplyConfig(ReadIni(path));
            statusLabel.Text = "Loaded " + path;
        }

        private void saveTargetButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveConfigToPath(GetSelectedConfigPath());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "Unable to save the selected target." + Environment.NewLine + Environment.NewLine + ex.Message,
                    "DeviceLister",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.AddExtension = true;
                dialog.DefaultExt = "ini";
                dialog.FileName = "devreorder.ini";
                dialog.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*";
                dialog.InitialDirectory = targetComboBox.SelectedIndex == TargetGameFolder ? GetGameFolderPath() : Path.GetDirectoryName(GetCommonConfigPath());
                dialog.OverwritePrompt = true;
                dialog.Title = "Save devreorder.ini";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                SaveConfigToPath(dialog.FileName);
            }
        }

        private void browseFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select the folder containing the game's .exe file";
                dialog.SelectedPath = Directory.Exists(GetGameFolderPath()) ? GetGameFolderPath() : Application.StartupPath;

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                gameFolderPath = dialog.SelectedPath;
                targetPathTextBox.Text = gameFolderPath;
                UpdateConfigStatus();
            }
        }

        private void refreshStatusButton_Click(object sender, EventArgs e)
        {
            UpdateConfigStatus();
        }

        private void targetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTargetControls();
        }

        private void targetPathTextBox_Leave(object sender, EventArgs e)
        {
            if (targetComboBox.SelectedIndex == TargetGameFolder)
            {
                gameFolderPath = targetPathTextBox.Text.Trim();
                UpdateConfigStatus();
            }
        }

        private void deviceListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateStatus();
        }

        private void deviceListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void deviceListView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(ListViewItem)) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void deviceListView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(ListViewItem)) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void deviceListView_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem draggedItem = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;

            if (draggedItem == null || draggedItem.ListView != deviceListView)
            {
                return;
            }

            Point targetPoint = deviceListView.PointToClient(new Point(e.X, e.Y));
            ListViewItem targetItem = deviceListView.GetItemAt(targetPoint.X, targetPoint.Y);
            int oldIndex = draggedItem.Index;
            int insertIndex = targetItem == null ? deviceListView.Items.Count : targetItem.Index;

            if (oldIndex < insertIndex)
            {
                --insertIndex;
            }

            if (insertIndex == oldIndex)
            {
                return;
            }

            deviceListView.BeginUpdate();
            deviceListView.Items.RemoveAt(oldIndex);

            if (insertIndex < 0)
            {
                insertIndex = 0;
            }
            else if (insertIndex > deviceListView.Items.Count)
            {
                insertIndex = deviceListView.Items.Count;
            }

            deviceListView.Items.Insert(insertIndex, draggedItem);
            draggedItem.Selected = true;
            draggedItem.Focused = true;
            RefreshOrderColumn();
            deviceListView.EndUpdate();
        }

        private void identifierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void visibleWhitelistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }
    }
}
