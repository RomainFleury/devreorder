namespace DeviceLister
{
    partial class DeviceListerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.targetGroupBox = new System.Windows.Forms.GroupBox();
            this.importConfigButton = new System.Windows.Forms.Button();
            this.refreshStatusButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.saveTargetButton = new System.Windows.Forms.Button();
            this.loadConfigButton = new System.Windows.Forms.Button();
            this.targetStatusLabel = new System.Windows.Forms.Label();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.targetPathLabel = new System.Windows.Forms.Label();
            this.targetComboBox = new System.Windows.Forms.ComboBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.deviceListView = new System.Windows.Forms.ListView();
            this.orderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aliasColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceInstanceIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.effectiveOrderListBox = new System.Windows.Forms.ListBox();
            this.identifyGroupBox = new System.Windows.Forms.GroupBox();
            this.identifyTextBox = new System.Windows.Forms.TextBox();
            this.identifyStatusLabel = new System.Windows.Forms.Label();
            this.identifierLabel = new System.Windows.Forms.Label();
            this.identifierComboBox = new System.Windows.Forms.ComboBox();
            this.visibleWhitelistCheckBox = new System.Windows.Forms.CheckBox();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.ignoredProcessesLabel = new System.Windows.Forms.Label();
            this.ignoredProcessesTextBox = new System.Windows.Forms.TextBox();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.hideSelectedButton = new System.Windows.Forms.Button();
            this.showSelectedButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.identifyTimer = new System.Windows.Forms.Timer(this.components);
            this.targetGroupBox.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.identifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // instructionsLabel
            //
            this.instructionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(1016, 34);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Check devices that should remain visible, uncheck devices to hide them, then drag rows or use Move Up/Down to set the DirectInput order. Choose a target to load, import, or save that devreorder.ini.";
            //
            // targetGroupBox
            //
            this.targetGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetGroupBox.Controls.Add(this.importConfigButton);
            this.targetGroupBox.Controls.Add(this.refreshStatusButton);
            this.targetGroupBox.Controls.Add(this.saveAsButton);
            this.targetGroupBox.Controls.Add(this.saveTargetButton);
            this.targetGroupBox.Controls.Add(this.loadConfigButton);
            this.targetGroupBox.Controls.Add(this.targetStatusLabel);
            this.targetGroupBox.Controls.Add(this.browseFolderButton);
            this.targetGroupBox.Controls.Add(this.targetPathTextBox);
            this.targetGroupBox.Controls.Add(this.targetPathLabel);
            this.targetGroupBox.Controls.Add(this.targetComboBox);
            this.targetGroupBox.Controls.Add(this.targetLabel);
            this.targetGroupBox.Location = new System.Drawing.Point(12, 46);
            this.targetGroupBox.Name = "targetGroupBox";
            this.targetGroupBox.Size = new System.Drawing.Size(1016, 112);
            this.targetGroupBox.TabIndex = 1;
            this.targetGroupBox.TabStop = false;
            this.targetGroupBox.Text = "Configuration target";
            //
            // importConfigButton
            //
            this.importConfigButton.Location = new System.Drawing.Point(342, 52);
            this.importConfigButton.Name = "importConfigButton";
            this.importConfigButton.Size = new System.Drawing.Size(88, 23);
            this.importConfigButton.TabIndex = 10;
            this.importConfigButton.Text = "Import...";
            this.importConfigButton.UseVisualStyleBackColor = true;
            this.importConfigButton.Click += new System.EventHandler(this.importConfigButton_Click);
            //
            // refreshStatusButton
            //
            this.refreshStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshStatusButton.Location = new System.Drawing.Point(925, 18);
            this.refreshStatusButton.Name = "refreshStatusButton";
            this.refreshStatusButton.Size = new System.Drawing.Size(85, 23);
            this.refreshStatusButton.TabIndex = 9;
            this.refreshStatusButton.Text = "Refresh";
            this.refreshStatusButton.UseVisualStyleBackColor = true;
            this.refreshStatusButton.Click += new System.EventHandler(this.refreshStatusButton_Click);
            //
            // saveAsButton
            //
            this.saveAsButton.Location = new System.Drawing.Point(248, 52);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(88, 23);
            this.saveAsButton.TabIndex = 8;
            this.saveAsButton.Text = "Save As...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            //
            // saveTargetButton
            //
            this.saveTargetButton.Location = new System.Drawing.Point(123, 52);
            this.saveTargetButton.Name = "saveTargetButton";
            this.saveTargetButton.Size = new System.Drawing.Size(119, 23);
            this.saveTargetButton.TabIndex = 7;
            this.saveTargetButton.Text = "Save to Target";
            this.saveTargetButton.UseVisualStyleBackColor = true;
            this.saveTargetButton.Click += new System.EventHandler(this.saveTargetButton_Click);
            //
            // loadConfigButton
            //
            this.loadConfigButton.Location = new System.Drawing.Point(9, 52);
            this.loadConfigButton.Name = "loadConfigButton";
            this.loadConfigButton.Size = new System.Drawing.Size(108, 23);
            this.loadConfigButton.TabIndex = 6;
            this.loadConfigButton.Text = "Load Target";
            this.loadConfigButton.UseVisualStyleBackColor = true;
            this.loadConfigButton.Click += new System.EventHandler(this.loadConfigButton_Click);
            //
            // targetStatusLabel
            //
            this.targetStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetStatusLabel.Location = new System.Drawing.Point(9, 80);
            this.targetStatusLabel.Name = "targetStatusLabel";
            this.targetStatusLabel.Size = new System.Drawing.Size(1001, 25);
            this.targetStatusLabel.TabIndex = 5;
            //
            // browseFolderButton
            //
            this.browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderButton.Location = new System.Drawing.Point(844, 18);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(75, 23);
            this.browseFolderButton.TabIndex = 4;
            this.browseFolderButton.Text = "Browse...";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            //
            // targetPathTextBox
            //
            this.targetPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPathTextBox.Location = new System.Drawing.Point(353, 20);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(485, 20);
            this.targetPathTextBox.TabIndex = 3;
            this.targetPathTextBox.Leave += new System.EventHandler(this.targetPathTextBox_Leave);
            //
            // targetPathLabel
            //
            this.targetPathLabel.AutoSize = true;
            this.targetPathLabel.Location = new System.Drawing.Point(281, 24);
            this.targetPathLabel.Name = "targetPathLabel";
            this.targetPathLabel.Size = new System.Drawing.Size(66, 13);
            this.targetPathLabel.TabIndex = 2;
            this.targetPathLabel.Text = "Folder/path:";
            //
            // targetComboBox
            //
            this.targetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetComboBox.FormattingEnabled = true;
            this.targetComboBox.Location = new System.Drawing.Point(55, 20);
            this.targetComboBox.Name = "targetComboBox";
            this.targetComboBox.Size = new System.Drawing.Size(220, 21);
            this.targetComboBox.TabIndex = 1;
            this.targetComboBox.SelectedIndexChanged += new System.EventHandler(this.targetComboBox_SelectedIndexChanged);
            //
            // targetLabel
            //
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(9, 24);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(41, 13);
            this.targetLabel.TabIndex = 0;
            this.targetLabel.Text = "Target:";
            //
            // deviceListView
            //
            this.deviceListView.AllowDrop = true;
            this.deviceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceListView.CheckBoxes = true;
            this.deviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderColumnHeader,
            this.nameColumnHeader,
            this.aliasColumnHeader,
            this.guidColumnHeader,
            this.deviceInstanceIdColumnHeader});
            this.deviceListView.FullRowSelect = true;
            this.deviceListView.GridLines = true;
            this.deviceListView.HideSelection = false;
            this.deviceListView.Location = new System.Drawing.Point(12, 164);
            this.deviceListView.MultiSelect = false;
            this.deviceListView.Name = "deviceListView";
            this.deviceListView.Size = new System.Drawing.Size(704, 274);
            this.deviceListView.TabIndex = 2;
            this.deviceListView.UseCompatibleStateImageBehavior = false;
            this.deviceListView.View = System.Windows.Forms.View.Details;
            this.deviceListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.deviceListView_ItemChecked);
            this.deviceListView.SelectedIndexChanged += new System.EventHandler(this.deviceListView_SelectedIndexChanged);
            this.deviceListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.deviceListView_ItemDrag);
            this.deviceListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.deviceListView_DragDrop);
            this.deviceListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.deviceListView_DragEnter);
            this.deviceListView.DragOver += new System.Windows.Forms.DragEventHandler(this.deviceListView_DragOver);
            //
            // orderColumnHeader
            //
            this.orderColumnHeader.Text = "#";
            this.orderColumnHeader.Width = 40;
            //
            // nameColumnHeader
            //
            this.nameColumnHeader.Text = "Device";
            this.nameColumnHeader.Width = 180;
            //
            // aliasColumnHeader
            //
            this.aliasColumnHeader.Text = "Alias";
            this.aliasColumnHeader.Width = 145;
            //
            // guidColumnHeader
            //
            this.guidColumnHeader.Text = "Instance GUID";
            this.guidColumnHeader.Width = 225;
            //
            // deviceInstanceIdColumnHeader
            //
            this.deviceInstanceIdColumnHeader.Text = "Device Instance ID";
            this.deviceInstanceIdColumnHeader.Width = 380;
            //
            // previewGroupBox
            //
            this.previewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewGroupBox.Controls.Add(this.effectiveOrderListBox);
            this.previewGroupBox.Location = new System.Drawing.Point(722, 164);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(306, 132);
            this.previewGroupBox.TabIndex = 3;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Effective visible order";
            //
            // effectiveOrderListBox
            //
            this.effectiveOrderListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.effectiveOrderListBox.FormattingEnabled = true;
            this.effectiveOrderListBox.Location = new System.Drawing.Point(8, 19);
            this.effectiveOrderListBox.Name = "effectiveOrderListBox";
            this.effectiveOrderListBox.Size = new System.Drawing.Size(292, 95);
            this.effectiveOrderListBox.TabIndex = 0;
            //
            // identifyGroupBox
            //
            this.identifyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.identifyGroupBox.Controls.Add(this.identifyTextBox);
            this.identifyGroupBox.Controls.Add(this.identifyStatusLabel);
            this.identifyGroupBox.Location = new System.Drawing.Point(722, 302);
            this.identifyGroupBox.Name = "identifyGroupBox";
            this.identifyGroupBox.Size = new System.Drawing.Size(306, 136);
            this.identifyGroupBox.TabIndex = 4;
            this.identifyGroupBox.TabStop = false;
            this.identifyGroupBox.Text = "Identify selected device";
            //
            // identifyTextBox
            //
            this.identifyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.identifyTextBox.Location = new System.Drawing.Point(8, 42);
            this.identifyTextBox.Multiline = true;
            this.identifyTextBox.Name = "identifyTextBox";
            this.identifyTextBox.ReadOnly = true;
            this.identifyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.identifyTextBox.Size = new System.Drawing.Size(292, 88);
            this.identifyTextBox.TabIndex = 1;
            this.identifyTextBox.WordWrap = false;
            //
            // identifyStatusLabel
            //
            this.identifyStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.identifyStatusLabel.Location = new System.Drawing.Point(8, 20);
            this.identifyStatusLabel.Name = "identifyStatusLabel";
            this.identifyStatusLabel.Size = new System.Drawing.Size(292, 19);
            this.identifyStatusLabel.TabIndex = 0;
            this.identifyStatusLabel.Text = "Select a device to identify it.";
            //
            // identifierLabel
            //
            this.identifierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Location = new System.Drawing.Point(12, 450);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(96, 13);
            this.identifierLabel.TabIndex = 5;
            this.identifierLabel.Text = "Identifier to save:";
            //
            // identifierComboBox
            //
            this.identifierComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.identifierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.identifierComboBox.FormattingEnabled = true;
            this.identifierComboBox.Location = new System.Drawing.Point(114, 447);
            this.identifierComboBox.Name = "identifierComboBox";
            this.identifierComboBox.Size = new System.Drawing.Size(214, 21);
            this.identifierComboBox.TabIndex = 6;
            this.identifierComboBox.SelectedIndexChanged += new System.EventHandler(this.identifierComboBox_SelectedIndexChanged);
            //
            // visibleWhitelistCheckBox
            //
            this.visibleWhitelistCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visibleWhitelistCheckBox.AutoSize = true;
            this.visibleWhitelistCheckBox.Location = new System.Drawing.Point(350, 449);
            this.visibleWhitelistCheckBox.Name = "visibleWhitelistCheckBox";
            this.visibleWhitelistCheckBox.Size = new System.Drawing.Size(191, 17);
            this.visibleWhitelistCheckBox.TabIndex = 7;
            this.visibleWhitelistCheckBox.Text = "Use [visible] whitelist when saving";
            this.visibleWhitelistCheckBox.UseVisualStyleBackColor = true;
            this.visibleWhitelistCheckBox.CheckedChanged += new System.EventHandler(this.visibleWhitelistCheckBox_CheckedChanged);
            //
            // aliasLabel
            //
            this.aliasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(12, 480);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(109, 13);
            this.aliasLabel.TabIndex = 8;
            this.aliasLabel.Text = "Selected device alias:";
            //
            // aliasTextBox
            //
            this.aliasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aliasTextBox.Location = new System.Drawing.Point(127, 477);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(490, 20);
            this.aliasTextBox.TabIndex = 9;
            //
            // renameButton
            //
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.renameButton.Location = new System.Drawing.Point(623, 475);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(93, 23);
            this.renameButton.TabIndex = 10;
            this.renameButton.Text = "Apply Alias";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            //
            // ignoredProcessesLabel
            //
            this.ignoredProcessesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ignoredProcessesLabel.AutoSize = true;
            this.ignoredProcessesLabel.Location = new System.Drawing.Point(12, 511);
            this.ignoredProcessesLabel.Name = "ignoredProcessesLabel";
            this.ignoredProcessesLabel.Size = new System.Drawing.Size(172, 13);
            this.ignoredProcessesLabel.TabIndex = 11;
            this.ignoredProcessesLabel.Text = "Ignored processes (one .exe/line):";
            //
            // ignoredProcessesTextBox
            //
            this.ignoredProcessesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoredProcessesTextBox.Location = new System.Drawing.Point(190, 508);
            this.ignoredProcessesTextBox.Multiline = true;
            this.ignoredProcessesTextBox.Name = "ignoredProcessesTextBox";
            this.ignoredProcessesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ignoredProcessesTextBox.Size = new System.Drawing.Size(838, 51);
            this.ignoredProcessesTextBox.TabIndex = 12;
            this.ignoredProcessesTextBox.WordWrap = false;
            //
            // moveUpButton
            //
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveUpButton.Location = new System.Drawing.Point(12, 605);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 23);
            this.moveUpButton.TabIndex = 13;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            //
            // moveDownButton
            //
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveDownButton.Location = new System.Drawing.Point(93, 605);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(82, 23);
            this.moveDownButton.TabIndex = 14;
            this.moveDownButton.Text = "Move Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            //
            // hideSelectedButton
            //
            this.hideSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hideSelectedButton.Location = new System.Drawing.Point(193, 605);
            this.hideSelectedButton.Name = "hideSelectedButton";
            this.hideSelectedButton.Size = new System.Drawing.Size(92, 23);
            this.hideSelectedButton.TabIndex = 15;
            this.hideSelectedButton.Text = "Hide Selected";
            this.hideSelectedButton.UseVisualStyleBackColor = true;
            this.hideSelectedButton.Click += new System.EventHandler(this.hideSelectedButton_Click);
            //
            // showSelectedButton
            //
            this.showSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showSelectedButton.Location = new System.Drawing.Point(291, 605);
            this.showSelectedButton.Name = "showSelectedButton";
            this.showSelectedButton.Size = new System.Drawing.Size(96, 23);
            this.showSelectedButton.TabIndex = 16;
            this.showSelectedButton.Text = "Show Selected";
            this.showSelectedButton.UseVisualStyleBackColor = true;
            this.showSelectedButton.Click += new System.EventHandler(this.showSelectedButton_Click);
            //
            // showAllButton
            //
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAllButton.Location = new System.Drawing.Point(393, 605);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 17;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            //
            // refreshButton
            //
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(474, 605);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(101, 23);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh Devices";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            //
            // copyButton
            //
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(934, 605);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(94, 23);
            this.copyButton.TabIndex = 19;
            this.copyButton.Text = "Copy Details";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            //
            // statusLabel
            //
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(581, 582);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(447, 17);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // identifyTimer
            //
            this.identifyTimer.Interval = 150;
            this.identifyTimer.Tick += new System.EventHandler(this.identifyTimer_Tick);
            //
            // DeviceListerForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.showSelectedButton);
            this.Controls.Add(this.hideSelectedButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.ignoredProcessesTextBox);
            this.Controls.Add(this.ignoredProcessesLabel);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.visibleWhitelistCheckBox);
            this.Controls.Add(this.identifierComboBox);
            this.Controls.Add(this.identifierLabel);
            this.Controls.Add(this.identifyGroupBox);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.deviceListView);
            this.Controls.Add(this.targetGroupBox);
            this.Controls.Add(this.instructionsLabel);
            this.MinimumSize = new System.Drawing.Size(940, 560);
            this.Name = "DeviceListerForm";
            this.Text = "devreorder Device Lister";
            this.Load += new System.EventHandler(this.DeviceListerForm_Load);
            this.targetGroupBox.ResumeLayout(false);
            this.targetGroupBox.PerformLayout();
            this.previewGroupBox.ResumeLayout(false);
            this.identifyGroupBox.ResumeLayout(false);
            this.identifyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.GroupBox targetGroupBox;
        private System.Windows.Forms.Button importConfigButton;
        private System.Windows.Forms.Button refreshStatusButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button saveTargetButton;
        private System.Windows.Forms.Button loadConfigButton;
        private System.Windows.Forms.Label targetStatusLabel;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Label targetPathLabel;
        private System.Windows.Forms.ComboBox targetComboBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.ListView deviceListView;
        private System.Windows.Forms.ColumnHeader orderColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader aliasColumnHeader;
        private System.Windows.Forms.ColumnHeader guidColumnHeader;
        private System.Windows.Forms.ColumnHeader deviceInstanceIdColumnHeader;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.ListBox effectiveOrderListBox;
        private System.Windows.Forms.GroupBox identifyGroupBox;
        private System.Windows.Forms.TextBox identifyTextBox;
        private System.Windows.Forms.Label identifyStatusLabel;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.ComboBox identifierComboBox;
        private System.Windows.Forms.CheckBox visibleWhitelistCheckBox;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Label ignoredProcessesLabel;
        private System.Windows.Forms.TextBox ignoredProcessesTextBox;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button hideSelectedButton;
        private System.Windows.Forms.Button showSelectedButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer identifyTimer;
    }
}
