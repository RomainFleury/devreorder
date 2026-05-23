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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.targetGroupBox = new System.Windows.Forms.GroupBox();
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
            this.guidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceInstanceIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.identifierLabel = new System.Windows.Forms.Label();
            this.identifierComboBox = new System.Windows.Forms.ComboBox();
            this.visibleWhitelistCheckBox = new System.Windows.Forms.CheckBox();
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
            this.targetGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // instructionsLabel
            //
            this.instructionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(916, 34);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Check devices that should remain visible, uncheck devices to hide them, then drag rows or use Move Up/Down to set the DirectInput order. Choose a target to load or save that devreorder.ini.";
            //
            // targetGroupBox
            //
            this.targetGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.targetGroupBox.Size = new System.Drawing.Size(916, 112);
            this.targetGroupBox.TabIndex = 1;
            this.targetGroupBox.TabStop = false;
            this.targetGroupBox.Text = "Configuration target";
            //
            // refreshStatusButton
            //
            this.refreshStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshStatusButton.Location = new System.Drawing.Point(819, 18);
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
            this.targetStatusLabel.Size = new System.Drawing.Size(895, 25);
            this.targetStatusLabel.TabIndex = 5;
            //
            // browseFolderButton
            //
            this.browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderButton.Location = new System.Drawing.Point(738, 18);
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
            this.targetPathTextBox.Size = new System.Drawing.Size(379, 20);
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
            this.guidColumnHeader,
            this.deviceInstanceIdColumnHeader});
            this.deviceListView.FullRowSelect = true;
            this.deviceListView.GridLines = true;
            this.deviceListView.HideSelection = false;
            this.deviceListView.Location = new System.Drawing.Point(12, 164);
            this.deviceListView.MultiSelect = false;
            this.deviceListView.Name = "deviceListView";
            this.deviceListView.Size = new System.Drawing.Size(916, 274);
            this.deviceListView.TabIndex = 2;
            this.deviceListView.UseCompatibleStateImageBehavior = false;
            this.deviceListView.View = System.Windows.Forms.View.Details;
            this.deviceListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.deviceListView_ItemChecked);
            this.deviceListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.deviceListView_ItemDrag);
            this.deviceListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.deviceListView_DragDrop);
            this.deviceListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.deviceListView_DragEnter);
            this.deviceListView.DragOver += new System.Windows.Forms.DragEventHandler(this.deviceListView_DragOver);
            //
            // orderColumnHeader
            //
            this.orderColumnHeader.Text = "#";
            this.orderColumnHeader.Width = 48;
            //
            // nameColumnHeader
            //
            this.nameColumnHeader.Text = "Device";
            this.nameColumnHeader.Width = 250;
            //
            // guidColumnHeader
            //
            this.guidColumnHeader.Text = "Instance GUID";
            this.guidColumnHeader.Width = 245;
            //
            // deviceInstanceIdColumnHeader
            //
            this.deviceInstanceIdColumnHeader.Text = "Device Instance ID";
            this.deviceInstanceIdColumnHeader.Width = 420;
            //
            // identifierLabel
            //
            this.identifierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Location = new System.Drawing.Point(12, 450);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(96, 13);
            this.identifierLabel.TabIndex = 3;
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
            this.identifierComboBox.TabIndex = 4;
            this.identifierComboBox.SelectedIndexChanged += new System.EventHandler(this.identifierComboBox_SelectedIndexChanged);
            //
            // visibleWhitelistCheckBox
            //
            this.visibleWhitelistCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visibleWhitelistCheckBox.AutoSize = true;
            this.visibleWhitelistCheckBox.Location = new System.Drawing.Point(350, 449);
            this.visibleWhitelistCheckBox.Name = "visibleWhitelistCheckBox";
            this.visibleWhitelistCheckBox.Size = new System.Drawing.Size(191, 17);
            this.visibleWhitelistCheckBox.TabIndex = 5;
            this.visibleWhitelistCheckBox.Text = "Use [visible] whitelist when saving";
            this.visibleWhitelistCheckBox.UseVisualStyleBackColor = true;
            this.visibleWhitelistCheckBox.CheckedChanged += new System.EventHandler(this.visibleWhitelistCheckBox_CheckedChanged);
            //
            // ignoredProcessesLabel
            //
            this.ignoredProcessesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ignoredProcessesLabel.AutoSize = true;
            this.ignoredProcessesLabel.Location = new System.Drawing.Point(12, 480);
            this.ignoredProcessesLabel.Name = "ignoredProcessesLabel";
            this.ignoredProcessesLabel.Size = new System.Drawing.Size(172, 13);
            this.ignoredProcessesLabel.TabIndex = 6;
            this.ignoredProcessesLabel.Text = "Ignored processes (one .exe/line):";
            //
            // ignoredProcessesTextBox
            //
            this.ignoredProcessesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoredProcessesTextBox.Location = new System.Drawing.Point(190, 477);
            this.ignoredProcessesTextBox.Multiline = true;
            this.ignoredProcessesTextBox.Name = "ignoredProcessesTextBox";
            this.ignoredProcessesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ignoredProcessesTextBox.Size = new System.Drawing.Size(738, 51);
            this.ignoredProcessesTextBox.TabIndex = 7;
            this.ignoredProcessesTextBox.WordWrap = false;
            //
            // moveUpButton
            //
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveUpButton.Location = new System.Drawing.Point(12, 575);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 23);
            this.moveUpButton.TabIndex = 8;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            //
            // moveDownButton
            //
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveDownButton.Location = new System.Drawing.Point(93, 575);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(82, 23);
            this.moveDownButton.TabIndex = 9;
            this.moveDownButton.Text = "Move Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            //
            // hideSelectedButton
            //
            this.hideSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hideSelectedButton.Location = new System.Drawing.Point(193, 575);
            this.hideSelectedButton.Name = "hideSelectedButton";
            this.hideSelectedButton.Size = new System.Drawing.Size(92, 23);
            this.hideSelectedButton.TabIndex = 10;
            this.hideSelectedButton.Text = "Hide Selected";
            this.hideSelectedButton.UseVisualStyleBackColor = true;
            this.hideSelectedButton.Click += new System.EventHandler(this.hideSelectedButton_Click);
            //
            // showSelectedButton
            //
            this.showSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showSelectedButton.Location = new System.Drawing.Point(291, 575);
            this.showSelectedButton.Name = "showSelectedButton";
            this.showSelectedButton.Size = new System.Drawing.Size(96, 23);
            this.showSelectedButton.TabIndex = 11;
            this.showSelectedButton.Text = "Show Selected";
            this.showSelectedButton.UseVisualStyleBackColor = true;
            this.showSelectedButton.Click += new System.EventHandler(this.showSelectedButton_Click);
            //
            // showAllButton
            //
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAllButton.Location = new System.Drawing.Point(393, 575);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 12;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            //
            // refreshButton
            //
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(474, 575);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(101, 23);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh Devices";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            //
            // copyButton
            //
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(834, 575);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(94, 23);
            this.copyButton.TabIndex = 14;
            this.copyButton.Text = "Copy Details";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            //
            // statusLabel
            //
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(581, 552);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(347, 17);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // DeviceListerForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 610);
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
            this.Controls.Add(this.visibleWhitelistCheckBox);
            this.Controls.Add(this.identifierComboBox);
            this.Controls.Add(this.identifierLabel);
            this.Controls.Add(this.deviceListView);
            this.Controls.Add(this.targetGroupBox);
            this.Controls.Add(this.instructionsLabel);
            this.MinimumSize = new System.Drawing.Size(860, 520);
            this.Name = "DeviceListerForm";
            this.Text = "devreorder Device Lister";
            this.Load += new System.EventHandler(this.DeviceListerForm_Load);
            this.targetGroupBox.ResumeLayout(false);
            this.targetGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.GroupBox targetGroupBox;
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
        private System.Windows.Forms.ColumnHeader guidColumnHeader;
        private System.Windows.Forms.ColumnHeader deviceInstanceIdColumnHeader;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.ComboBox identifierComboBox;
        private System.Windows.Forms.CheckBox visibleWhitelistCheckBox;
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
    }
}
