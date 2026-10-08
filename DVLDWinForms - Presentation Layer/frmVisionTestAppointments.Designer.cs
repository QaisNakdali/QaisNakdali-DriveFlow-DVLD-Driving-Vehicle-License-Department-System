namespace DVLDWinForms___Presentation_Layer
{
    partial class frmVisionTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisionTestAppointments));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblNewTest = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.lblNumberOfAppointments = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvAppointments = new Krypton.Toolkit.KryptonDataGridView();
            this.cmsTestAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVisionTestAppointments = new System.Windows.Forms.Label();
            this.ucDrivingLicenseInfoShort1 = new DVLDWinForms___Presentation_Layer.ucDrivingLicenseInfoShort();
            this.ucApplicationsInfoShort1 = new DVLDWinForms___Presentation_Layer.ucApplicationsInfoShort();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsTestAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlMain.Controls.Add(this.lblLoading);
            this.pnlMain.Controls.Add(this.lblNewTest);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.lblAppointments);
            this.pnlMain.Controls.Add(this.lblNumberOfAppointments);
            this.pnlMain.Controls.Add(this.lblRecords);
            this.pnlMain.Controls.Add(this.dgvAppointments);
            this.pnlMain.Controls.Add(this.lblVisionTestAppointments);
            this.pnlMain.Controls.Add(this.ucDrivingLicenseInfoShort1);
            this.pnlMain.Controls.Add(this.ucApplicationsInfoShort1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1156, 1295);
            this.pnlMain.TabIndex = 0;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lblLoading.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblLoading.Location = new System.Drawing.Point(522, 1072);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(113, 27);
            this.lblLoading.TabIndex = 95;
            this.lblLoading.Text = "Loading...";
            // 
            // lblNewTest
            // 
            this.lblNewTest.AutoSize = true;
            this.lblNewTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewTest.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTest.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNewTest.Location = new System.Drawing.Point(953, 869);
            this.lblNewTest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewTest.Name = "lblNewTest";
            this.lblNewTest.Size = new System.Drawing.Size(120, 32);
            this.lblNewTest.TabIndex = 94;
            this.lblNewTest.Text = "New Test";
            this.lblNewTest.Click += new System.EventHandler(this.lblNewTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1109, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 93;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Trebuchet MS", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lblAppointments.Location = new System.Drawing.Point(78, 867);
            this.lblAppointments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(206, 37);
            this.lblAppointments.TabIndex = 78;
            this.lblAppointments.Text = "Appointments";
            // 
            // lblNumberOfAppointments
            // 
            this.lblNumberOfAppointments.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblNumberOfAppointments.Location = new System.Drawing.Point(200, 1263);
            this.lblNumberOfAppointments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfAppointments.Name = "lblNumberOfAppointments";
            this.lblNumberOfAppointments.Size = new System.Drawing.Size(124, 27);
            this.lblNumberOfAppointments.TabIndex = 77;
            this.lblNumberOfAppointments.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblRecords.Location = new System.Drawing.Point(80, 1263);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(116, 27);
            this.lblRecords.TabIndex = 76;
            this.lblRecords.Text = "# Records:";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.cmsTestAppointments;
            this.dgvAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAppointments.Location = new System.Drawing.Point(83, 908);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidth = 82;
            this.dgvAppointments.RowTemplate.Height = 35;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(990, 354);
            this.dgvAppointments.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvAppointments.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvAppointments.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvAppointments.TabIndex = 75;
            // 
            // cmsTestAppointments
            // 
            this.cmsTestAppointments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsTestAppointments.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsTestAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateTest,
            this.TakeTest});
            this.cmsTestAppointments.Name = "cmsPeople";
            this.cmsTestAppointments.Size = new System.Drawing.Size(215, 80);
            // 
            // UpdateTest
            // 
            this.UpdateTest.Name = "UpdateTest";
            this.UpdateTest.Size = new System.Drawing.Size(214, 38);
            this.UpdateTest.Text = "Update Test";
            this.UpdateTest.Click += new System.EventHandler(this.UpdateTest_Click);
            // 
            // TakeTest
            // 
            this.TakeTest.Name = "TakeTest";
            this.TakeTest.Size = new System.Drawing.Size(214, 38);
            this.TakeTest.Text = "Take Test";
            this.TakeTest.Click += new System.EventHandler(this.TakeTest_Click);
            // 
            // lblVisionTestAppointments
            // 
            this.lblVisionTestAppointments.AutoSize = true;
            this.lblVisionTestAppointments.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionTestAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lblVisionTestAppointments.Location = new System.Drawing.Point(277, 32);
            this.lblVisionTestAppointments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVisionTestAppointments.Name = "lblVisionTestAppointments";
            this.lblVisionTestAppointments.Size = new System.Drawing.Size(602, 61);
            this.lblVisionTestAppointments.TabIndex = 74;
            this.lblVisionTestAppointments.Text = "Vision Test Appointments";
            // 
            // ucDrivingLicenseInfoShort1
            // 
            this.ucDrivingLicenseInfoShort1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ucDrivingLicenseInfoShort1.Location = new System.Drawing.Point(83, 121);
            this.ucDrivingLicenseInfoShort1.Name = "ucDrivingLicenseInfoShort1";
            this.ucDrivingLicenseInfoShort1.Size = new System.Drawing.Size(990, 250);
            this.ucDrivingLicenseInfoShort1.TabIndex = 2;
            // 
            // ucApplicationsInfoShort1
            // 
            this.ucApplicationsInfoShort1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ucApplicationsInfoShort1.Location = new System.Drawing.Point(83, 374);
            this.ucApplicationsInfoShort1.Name = "ucApplicationsInfoShort1";
            this.ucApplicationsInfoShort1.Size = new System.Drawing.Size(990, 481);
            this.ucApplicationsInfoShort1.TabIndex = 1;
            // 
            // frmVisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 1295);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisionTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisionTestAppointments";
            this.Load += new System.EventHandler(this.frmVisionTestAppointments_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsTestAppointments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private ucApplicationsInfoShort ucApplicationsInfoShort1;
        private ucDrivingLicenseInfoShort ucDrivingLicenseInfoShort1;
        private System.Windows.Forms.Label lblVisionTestAppointments;
        private Krypton.Toolkit.KryptonDataGridView dgvAppointments;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Label lblNumberOfAppointments;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblNewTest;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ContextMenuStrip cmsTestAppointments;
        private System.Windows.Forms.ToolStripMenuItem UpdateTest;
        private System.Windows.Forms.ToolStripMenuItem TakeTest;
    }
}