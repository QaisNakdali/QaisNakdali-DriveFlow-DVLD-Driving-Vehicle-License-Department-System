namespace DVLDWinForms___Presentation_Layer
{
    partial class ucTestTypes
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
            this.btnBackToApplicationsScreen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblNumberOfTests = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTestsTypesInformation = new Krypton.Toolkit.KryptonDataGridView();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToApplicationsScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsTypesInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.MainPanel.Controls.Add(this.btnBackToApplicationsScreen);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lblLoading);
            this.MainPanel.Controls.Add(this.lblNumberOfTests);
            this.MainPanel.Controls.Add(this.lblRecords);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.dgvTestsTypesInformation);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(2560, 1465);
            this.MainPanel.TabIndex = 8;
            // 
            // btnBackToApplicationsScreen
            // 
            this.btnBackToApplicationsScreen.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.back__1_;
            this.btnBackToApplicationsScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToApplicationsScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToApplicationsScreen.Location = new System.Drawing.Point(13, 13);
            this.btnBackToApplicationsScreen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToApplicationsScreen.Name = "btnBackToApplicationsScreen";
            this.btnBackToApplicationsScreen.Size = new System.Drawing.Size(54, 52);
            this.btnBackToApplicationsScreen.TabIndex = 20;
            this.btnBackToApplicationsScreen.TabStop = false;
            this.btnBackToApplicationsScreen.Click += new System.EventHandler(this.btnBackToApplicationsScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(1139, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Test Types Management";
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
            // lblNumberOfTests
            // 
            this.lblNumberOfTests.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblNumberOfTests.Location = new System.Drawing.Point(148, 1415);
            this.lblNumberOfTests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfTests.Name = "lblNumberOfTests";
            this.lblNumberOfTests.Size = new System.Drawing.Size(124, 27);
            this.lblNumberOfTests.TabIndex = 14;
            this.lblNumberOfTests.Text = "0";
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
            this.pictureBox1.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.hashtag__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 138);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTestsTypesInformation
            // 
            this.dgvTestsTypesInformation.AllowUserToAddRows = false;
            this.dgvTestsTypesInformation.AllowUserToDeleteRows = false;
            this.dgvTestsTypesInformation.AllowUserToResizeColumns = false;
            this.dgvTestsTypesInformation.AllowUserToResizeRows = false;
            this.dgvTestsTypesInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTestsTypesInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestsTypesInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTestsTypesInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTestsTypesInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestsTypesInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTestsTypesInformation.Location = new System.Drawing.Point(32, 201);
            this.dgvTestsTypesInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTestsTypesInformation.Name = "dgvTestsTypesInformation";
            this.dgvTestsTypesInformation.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.dgvTestsTypesInformation.ReadOnly = true;
            this.dgvTestsTypesInformation.RowHeadersVisible = false;
            this.dgvTestsTypesInformation.RowHeadersWidth = 82;
            this.dgvTestsTypesInformation.RowTemplate.Height = 35;
            this.dgvTestsTypesInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestsTypesInformation.Size = new System.Drawing.Size(2504, 1199);
            this.dgvTestsTypesInformation.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvTestsTypesInformation.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvTestsTypesInformation.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvTestsTypesInformation.TabIndex = 0;
            // 
            // ucTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "ucTestTypes";
            this.Size = new System.Drawing.Size(2560, 1465);
            this.Load += new System.EventHandler(this.ucTestTypes_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToApplicationsScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsTypesInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox btnBackToApplicationsScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblNumberOfTests;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDataGridView dgvTestsTypesInformation;
    }
}
