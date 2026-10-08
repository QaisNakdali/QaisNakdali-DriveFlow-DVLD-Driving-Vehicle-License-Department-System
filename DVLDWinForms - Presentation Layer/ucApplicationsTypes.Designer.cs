namespace DVLDWinForms___Presentation_Layer
{
    partial class ucApplicationsTypes
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblNumberOfApplications = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvApplicationsTypesInformation = new Krypton.Toolkit.KryptonDataGridView();
            this.btnBackToPreviousPage = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsTypesInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToPreviousPage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.MainPanel.Controls.Add(this.btnBackToPreviousPage);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lblLoading);
            this.MainPanel.Controls.Add(this.lblNumberOfApplications);
            this.MainPanel.Controls.Add(this.lblRecords);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.dgvApplicationsTypesInformation);
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
            this.label1.Location = new System.Drawing.Point(1092, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Applications Types Management";
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
            // lblNumberOfApplications
            // 
            this.lblNumberOfApplications.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblNumberOfApplications.Location = new System.Drawing.Point(148, 1415);
            this.lblNumberOfApplications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfApplications.Name = "lblNumberOfApplications";
            this.lblNumberOfApplications.Size = new System.Drawing.Size(124, 27);
            this.lblNumberOfApplications.TabIndex = 14;
            this.lblNumberOfApplications.Text = "0";
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.hashtags;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 138);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvApplicationsTypesInformation
            // 
            this.dgvApplicationsTypesInformation.AllowUserToAddRows = false;
            this.dgvApplicationsTypesInformation.AllowUserToDeleteRows = false;
            this.dgvApplicationsTypesInformation.AllowUserToResizeColumns = false;
            this.dgvApplicationsTypesInformation.AllowUserToResizeRows = false;
            this.dgvApplicationsTypesInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvApplicationsTypesInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplicationsTypesInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApplicationsTypesInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplicationsTypesInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationsTypesInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvApplicationsTypesInformation.Location = new System.Drawing.Point(32, 201);
            this.dgvApplicationsTypesInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApplicationsTypesInformation.Name = "dgvApplicationsTypesInformation";
            this.dgvApplicationsTypesInformation.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.dgvApplicationsTypesInformation.ReadOnly = true;
            this.dgvApplicationsTypesInformation.RowHeadersVisible = false;
            this.dgvApplicationsTypesInformation.RowHeadersWidth = 82;
            this.dgvApplicationsTypesInformation.RowTemplate.Height = 35;
            this.dgvApplicationsTypesInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationsTypesInformation.Size = new System.Drawing.Size(2504, 1199);
            this.dgvApplicationsTypesInformation.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvApplicationsTypesInformation.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvApplicationsTypesInformation.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvApplicationsTypesInformation.TabIndex = 0;
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
            this.btnBackToPreviousPage.TabIndex = 26;
            this.btnBackToPreviousPage.TabStop = false;
            this.btnBackToPreviousPage.Click += new System.EventHandler(this.btnBackToPreviousPage_Click);
            // 
            // ucApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "ucApplicationsTypes";
            this.Size = new System.Drawing.Size(2560, 1465);
            this.Load += new System.EventHandler(this.ucApplicationsTypes_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsTypesInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToPreviousPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblNumberOfApplications;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDataGridView dgvApplicationsTypesInformation;
        private System.Windows.Forms.PictureBox btnBackToPreviousPage;
    }
}
