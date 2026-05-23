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

        public DeviceListerForm()
        {
            InitializeComponent();
        }

        private void DeviceListerForm_Load(object sender, EventArgs e)
        {
            identifierComboBox.Items.Add("Device instance ID (recommended)");
            identifierComboBox.Items.Add("Instance GUID");
            identifierComboBox.Items.Add("Product name");
            identifierComboBox.SelectedIndex = IdentifierDeviceInstanceId;

            LoadDevices();
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

            statusLabel.Text = visibleCount.ToString() + " visible, " + hiddenCount.ToString() + " hidden";
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
            builder.AppendLine("; Drag devices in DeviceLister to change [order]; uncheck devices to add them to [hidden].");
            builder.AppendLine();
            builder.AppendLine("[order]");

            foreach (ListViewItem item in deviceListView.Items)
            {
                if (item.Checked)
                {
                    builder.AppendLine(GetIdentifier(GetEntry(item)));
                }
            }

            builder.AppendLine();
            builder.AppendLine("[hidden]");

            foreach (ListViewItem item in deviceListView.Items)
            {
                if (!item.Checked)
                {
                    builder.AppendLine(GetIdentifier(GetEntry(item)));
                }
            }

            builder.AppendLine();
            builder.AppendLine("[visible]");
            builder.AppendLine("; Leave this empty when using [hidden].");
            builder.AppendLine();
            builder.AppendLine("[ignored processes]");

            return builder.ToString();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.AddExtension = true;
                dialog.DefaultExt = "ini";
                dialog.FileName = "devreorder.ini";
                dialog.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*";
                dialog.InitialDirectory = Application.StartupPath;
                dialog.OverwritePrompt = true;
                dialog.Title = "Save devreorder.ini";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                File.WriteAllText(dialog.FileName, BuildIni(), Encoding.UTF8);
                statusLabel.Text = "Saved " + dialog.FileName;
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
    }
}
