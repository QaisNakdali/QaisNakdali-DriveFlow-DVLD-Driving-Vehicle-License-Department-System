namespace DVLDWinForms___Presentation_Layer
{
    partial class ucLocalLicensesManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbLocalLicensesSearchFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblNumberOfLocalLicenses = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvLocalLicensesManagement = new Krypton.Toolkit.KryptonDataGridView();
            this.cmsDrivingLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.showDrivingLicenseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDrivnigLicenseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelDrivingLicesne = new System.Windows.Forms.ToolStripMenuItem();
            this.ScaduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.scaduleVisonTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaduleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackToPreviousPage = new System.Windows.Forms.PictureBox();
            this.btnAddLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocalLicensesSearchFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesManagement)).BeginInit();
            this.cmsDrivingLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToPreviousPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.MainPanel.Controls.Add(this.btnBackToPreviousPage);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.tbSearch);
            this.MainPanel.Controls.Add(this.cbLocalLicensesSearchFilter);
            this.MainPanel.Controls.Add(this.lblLoading);
            this.MainPanel.Controls.Add(this.btnAddLicense);
            this.MainPanel.Controls.Add(this.lblNumberOfLocalLicenses);
            this.MainPanel.Controls.Add(this.lblRecords);
            this.MainPanel.Controls.Add(this.lblFilterBy);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.dgvLocalLicensesManagement);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(2560, 1465);
            this.MainPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(1118, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Local Licenses Management";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(445, 151);
            this.tbSearch.MaxLength = 50;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(284, 33);
            this.tbSearch.TabIndex = 18;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // cbLocalLicensesSearchFilter
            // 
            this.cbLocalLicensesSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLocalLicensesSearchFilter.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.TabCustom1;
            this.cbLocalLicensesSearchFilter.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbLocalLicensesSearchFilter.DropDownHeight = 400;
            this.cbLocalLicensesSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalLicensesSearchFilter.DropDownWidth = 121;
            this.cbLocalLicensesSearchFilter.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbLocalLicensesSearchFilter.IntegralHeight = false;
            this.cbLocalLicensesSearchFilter.Items.AddRange(new object[] {
            "None",
            "Local License ID",
            "Class Name",
            "National No",
            "Full Name",
            "Status"});
            this.cbLocalLicensesSearchFilter.Location = new System.Drawing.Point(140, 151);
            this.cbLocalLicensesSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocalLicensesSearchFilter.Name = "cbLocalLicensesSearchFilter";
            this.cbLocalLicensesSearchFilter.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cbLocalLicensesSearchFilter.Size = new System.Drawing.Size(284, 38);
            this.cbLocalLicensesSearchFilter.StateTracking.Item.Back.Color1 = System.Drawing.Color.BlueViolet;
            this.cbLocalLicensesSearchFilter.StateTracking.Item.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.cbLocalLicensesSearchFilter.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cbLocalLicensesSearchFilter.TabIndex = 0;
            this.cbLocalLicensesSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cbLocalLicensesSearchFilter_SelectedIndexChanged);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lblLoading.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblLoading.Location = new System.Drawing.Point(1228, 773);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(113, 27);
            this.lblLoading.TabIndex = 17;
            this.lblLoading.Text = "Loading...";
            // 
            // lblNumberOfLocalLicenses
            // 
            this.lblNumberOfLocalLicenses.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLocalLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblNumberOfLocalLicenses.Location = new System.Drawing.Point(148, 1415);
            this.lblNumberOfLocalLicenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfLocalLicenses.Name = "lblNumberOfLocalLicenses";
            this.lblNumberOfLocalLicenses.Size = new System.Drawing.Size(124, 27);
            this.lblNumberOfLocalLicenses.TabIndex = 14;
            this.lblNumberOfLocalLicenses.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblRecords.Location = new System.Drawing.Point(28, 1415);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(116, 27);
            this.lblRecords.TabIndex = 13;
            this.lblRecords.Text = "# Records:";
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblFilterBy.Location = new System.Drawing.Point(28, 157);
            this.lblFilterBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(106, 27);
            this.lblFilterBy.TabIndex = 12;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // dgvLocalLicensesManagement
            // 
            this.dgvLocalLicensesManagement.AllowUserToAddRows = false;
            this.dgvLocalLicensesManagement.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesManagement.AllowUserToResizeColumns = false;
            this.dgvLocalLicensesManagement.AllowUserToResizeRows = false;
            this.dgvLocalLicensesManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvLocalLicensesManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicensesManagement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalLicensesManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocalLicensesManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesManagement.ContextMenuStrip = this.cmsDrivingLicense;
            this.dgvLocalLicensesManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLocalLicensesManagement.Location = new System.Drawing.Point(32, 201);
            this.dgvLocalLicensesManagement.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLocalLicensesManagement.Name = "dgvLocalLicensesManagement";
            this.dgvLocalLicensesManagement.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.dgvLocalLicensesManagement.ReadOnly = true;
            this.dgvLocalLicensesManagement.RowHeadersVisible = false;
            this.dgvLocalLicensesManagement.RowHeadersWidth = 82;
            this.dgvLocalLicensesManagement.RowTemplate.Height = 35;
            this.dgvLocalLicensesManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicensesManagement.Size = new System.Drawing.Size(2504, 1199);
            this.dgvLocalLicensesManagement.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvLocalLicensesManagement.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvLocalLicensesManagement.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvLocalLicensesManagement.TabIndex = 0;
            // 
            // cmsDrivingLicense
            // 
            this.cmsDrivingLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsDrivingLicense.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDrivingLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDrivingLicense,
            this.showDrivingLicenseInfo,
            this.updateDrivnigLicenseInfo,
            this.deleteDrivingLicense,
            this.CancelDrivingLicesne,
            this.ScaduleTest,
            this.ShowPersonLicenseHistory,
            this.toolStripSeparator1,
            this.Refresh});
            this.cmsDrivingLicense.Name = "cmsPeople";
            this.cmsDrivingLicense.Size = new System.Drawing.Size(392, 358);
            // 
            // addDrivingLicense
            // 
            this.addDrivingLicense.Name = "addDrivingLicense";
            this.addDrivingLicense.Size = new System.Drawing.Size(391, 38);
            this.addDrivingLicense.Text = "Add";
            this.addDrivingLicense.Click += new System.EventHandler(this.addDrivingLicense_Click);
            // 
            // showDrivingLicenseInfo
            // 
            this.showDrivingLicenseInfo.Name = "showDrivingLicenseInfo";
            this.showDrivingLicenseInfo.Size = new System.Drawing.Size(391, 38);
            this.showDrivingLicenseInfo.Text = "Show";
            this.showDrivingLicenseInfo.Click += new System.EventHandler(this.showDrivingLicenseInfo_Click);
            // 
            // updateDrivnigLicenseInfo
            // 
            this.updateDrivnigLicenseInfo.Name = "updateDrivnigLicenseInfo";
            this.updateDrivnigLicenseInfo.Size = new System.Drawing.Size(391, 38);
            this.updateDrivnigLicenseInfo.Text = "Update";
            this.updateDrivnigLicenseInfo.Click += new System.EventHandler(this.updateDrivnigLicenseInfo_Click);
            // 
            // deleteDrivingLicense
            // 
            this.deleteDrivingLicense.Name = "deleteDrivingLicense";
            this.deleteDrivingLicense.Size = new System.Drawing.Size(391, 38);
            this.deleteDrivingLicense.Text = "Delete";
            this.deleteDrivingLicense.Click += new System.EventHandler(this.deleteDrivingLicense_Click);
            // 
            // CancelDrivingLicesne
            // 
            this.CancelDrivingLicesne.Name = "CancelDrivingLicesne";
            this.CancelDrivingLicesne.Size = new System.Drawing.Size(391, 38);
            this.CancelDrivingLicesne.Text = "Cancel Application";
            this.CancelDrivingLicesne.Click += new System.EventHandler(this.CancelDrivingLicesne_Click);
            // 
            // ScaduleTest
            // 
            this.ScaduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaduleVisonTestToolStripMenuItem,
            this.scaduleToolStripMenuItem,
            this.scaduleToolStripMenuItem1});
            this.ScaduleTest.Name = "ScaduleTest";
            this.ScaduleTest.Size = new System.Drawing.Size(391, 38);
            this.ScaduleTest.Text = "Scadule Test";
            // 
            // scaduleVisonTestToolStripMenuItem
            // 
            this.scaduleVisonTestToolStripMenuItem.Name = "scaduleVisonTestToolStripMenuItem";
            this.scaduleVisonTestToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.scaduleVisonTestToolStripMenuItem.Text = "Scadule Vision Test";
            this.scaduleVisonTestToolStripMenuItem.Click += new System.EventHandler(this.scaduleVisonTestToolStripMenuItem_Click);
            // 
            // scaduleToolStripMenuItem
            // 
            this.scaduleToolStripMenuItem.Name = "scaduleToolStripMenuItem";
            this.scaduleToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.scaduleToolStripMenuItem.Text = "Scadule ";
            // 
            // scaduleToolStripMenuItem1
            // 
            this.scaduleToolStripMenuItem1.Name = "scaduleToolStripMenuItem1";
            this.scaduleToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.scaduleToolStripMenuItem1.Text = "Scadule";
            // 
            // ShowPersonLicenseHistory
            // 
            this.ShowPersonLicenseHistory.Name = "ShowPersonLicenseHistory";
            this.ShowPersonLicenseHistory.Size = new System.Drawing.Size(391, 38);
            this.ShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(388, 6);
            // 
            // Refresh
            // 
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(391, 38);
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnBackToPreviousPage
            // 
            this.btnBackToPreviousPage.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.back__1_;
            this.btnBackToPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToPreviousPage.Location = new System.Drawing.Point(26, 25);
            this.btnBackToPreviousPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToPreviousPage.Name = "btnBackToPreviousPage";
            this.btnBackToPreviousPage.Size = new System.Drawing.Size(52, 62);
            this.btnBackToPreviousPage.TabIndex = 27;
            this.btnBackToPreviousPage.TabStop = false;
            this.btnBackToPreviousPage.Click += new System.EventHandler(this.btnBackToPreviousPage_Click);
            // 
            // btnAddLicense
            // 
            this.btnAddLicense.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.stamp__1_;
            this.btnAddLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLicense.Location = new System.Drawing.Point(2484, 134);
            this.btnAddLicense.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLicense.Name = "btnAddLicense";
            this.btnAddLicense.Size = new System.Drawing.Size(52, 50);
            this.btnAddLicense.TabIndex = 16;
            this.btnAddLicense.UseVisualStyleBackColor = true;
            this.btnAddLicense.Click += new System.EventHandler(this.btnAddLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.driver_license__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 138);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ucLocalLicensesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "ucLocalLicensesManagement";
            this.Size = new System.Drawing.Size(2560, 1465);
            this.Load += new System.EventHandler(this.ucLocalLicensesManagement_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocalLicensesSearchFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesManagement)).EndInit();
            this.cmsDrivingLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToPreviousPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox btnBackToPreviousPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private Krypton.Toolkit.KryptonComboBox cbLocalLicensesSearchFilter;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnAddLicense;
        private System.Windows.Forms.Label lblNumberOfLocalLicenses;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDataGridView dgvLocalLicensesManagement;
        private System.Windows.Forms.ContextMenuStrip cmsDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem addDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem showDrivingLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem updateDrivnigLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem deleteDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem CancelDrivingLicesne;
        private System.Windows.Forms.ToolStripMenuItem ScaduleTest;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Refresh;
        private System.Windows.Forms.ToolStripMenuItem scaduleVisonTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaduleToolStripMenuItem1;
    }
}
