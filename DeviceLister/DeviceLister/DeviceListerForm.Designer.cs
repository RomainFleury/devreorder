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
            this.deviceListView = new System.Windows.Forms.ListView();
            this.orderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceInstanceIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.identifierLabel = new System.Windows.Forms.Label();
            this.identifierComboBox = new System.Windows.Forms.ComboBox();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.hideSelectedButton = new System.Windows.Forms.Button();
            this.showSelectedButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // instructionsLabel
            //
            this.instructionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(808, 34);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Check devices that should remain visible, uncheck devices to hide them, then drag" +
    " rows or use Move Up/Down to set the DirectInput order. Save writes a devreorder" +
    ".ini file.";
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
            this.deviceListView.Location = new System.Drawing.Point(12, 46);
            this.deviceListView.MultiSelect = false;
            this.deviceListView.Name = "deviceListView";
            this.deviceListView.Size = new System.Drawing.Size(808, 291);
            this.deviceListView.TabIndex = 1;
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
            this.identifierLabel.Location = new System.Drawing.Point(12, 351);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(96, 13);
            this.identifierLabel.TabIndex = 2;
            this.identifierLabel.Text = "Identifier to save:";
            //
            // identifierComboBox
            //
            this.identifierComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.identifierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.identifierComboBox.FormattingEnabled = true;
            this.identifierComboBox.Location = new System.Drawing.Point(114, 348);
            this.identifierComboBox.Name = "identifierComboBox";
            this.identifierComboBox.Size = new System.Drawing.Size(214, 21);
            this.identifierComboBox.TabIndex = 3;
            this.identifierComboBox.SelectedIndexChanged += new System.EventHandler(this.identifierComboBox_SelectedIndexChanged);
            //
            // moveUpButton
            //
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveUpButton.Location = new System.Drawing.Point(12, 381);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 23);
            this.moveUpButton.TabIndex = 4;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            //
            // moveDownButton
            //
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveDownButton.Location = new System.Drawing.Point(93, 381);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(82, 23);
            this.moveDownButton.TabIndex = 5;
            this.moveDownButton.Text = "Move Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            //
            // hideSelectedButton
            //
            this.hideSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hideSelectedButton.Location = new System.Drawing.Point(193, 381);
            this.hideSelectedButton.Name = "hideSelectedButton";
            this.hideSelectedButton.Size = new System.Drawing.Size(92, 23);
            this.hideSelectedButton.TabIndex = 6;
            this.hideSelectedButton.Text = "Hide Selected";
            this.hideSelectedButton.UseVisualStyleBackColor = true;
            this.hideSelectedButton.Click += new System.EventHandler(this.hideSelectedButton_Click);
            //
            // showSelectedButton
            //
            this.showSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showSelectedButton.Location = new System.Drawing.Point(291, 381);
            this.showSelectedButton.Name = "showSelectedButton";
            this.showSelectedButton.Size = new System.Drawing.Size(96, 23);
            this.showSelectedButton.TabIndex = 7;
            this.showSelectedButton.Text = "Show Selected";
            this.showSelectedButton.UseVisualStyleBackColor = true;
            this.showSelectedButton.Click += new System.EventHandler(this.showSelectedButton_Click);
            //
            // showAllButton
            //
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAllButton.Location = new System.Drawing.Point(393, 381);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 8;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            //
            // refreshButton
            //
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(474, 381);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            //
            // copyButton
            //
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(625, 381);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(94, 23);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy Details";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            //
            // saveButton
            //
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(725, 381);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save INI...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            //
            // statusLabel
            //
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(334, 351);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(486, 17);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // DeviceListerForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 416);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.showSelectedButton);
            this.Controls.Add(this.hideSelectedButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.identifierComboBox);
            this.Controls.Add(this.identifierLabel);
            this.Controls.Add(this.deviceListView);
            this.Controls.Add(this.instructionsLabel);
            this.MinimumSize = new System.Drawing.Size(760, 360);
            this.Name = "DeviceListerForm";
            this.Text = "devreorder Device Lister";
            this.Load += new System.EventHandler(this.DeviceListerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.ListView deviceListView;
        private System.Windows.Forms.ColumnHeader orderColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader guidColumnHeader;
        private System.Windows.Forms.ColumnHeader deviceInstanceIdColumnHeader;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.ComboBox identifierComboBox;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button hideSelectedButton;
        private System.Windows.Forms.Button showSelectedButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

