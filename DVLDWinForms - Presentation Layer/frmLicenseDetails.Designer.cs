namespace DVLDWinForms___Presentation_Layer
{
    partial class frmLicenseDetails
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
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLicenseControlContainer = new System.Windows.Forms.Panel();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucPeopleSearch1 = new DVLDWinForms___Presentation_Layer.ucPeopleSearch();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnPerviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbModeIcon = new System.Windows.Forms.PictureBox();
            this.pnlLoading.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.White;
            this.pnlLoading.Controls.Add(this.label2);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoading.Location = new System.Drawing.Point(0, 0);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(1679, 1134);
            this.pnlLoading.TabIndex = 100;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnEditPerson);
            this.pnlMain.Controls.Add(this.ucPeopleSearch1);
            this.pnlMain.Controls.Add(this.pnlLicenseControlContainer);
            this.pnlMain.Controls.Add(this.btnPerviousPage);
            this.pnlMain.Controls.Add(this.btnNextPage);
            this.pnlMain.Controls.Add(this.btnAddPerson);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.lblPersonID);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblModeName);
            this.pnlMain.Controls.Add(this.pbModeIcon);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1679, 1134);
            this.pnlMain.TabIndex = 94;
            // 
            // pnlLicenseControlContainer
            // 
            this.pnlLicenseControlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.pnlLicenseControlContainer.Location = new System.Drawing.Point(53, 265);
            this.pnlLicenseControlContainer.Name = "pnlLicenseControlContainer";
            this.pnlLicenseControlContainer.Size = new System.Drawing.Size(1573, 806);
            this.pnlLicenseControlContainer.TabIndex = 94;
            // 
            // lblPersonID
            // 
            this.lblPersonID.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPersonID.Location = new System.Drawing.Point(366, 214);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(382, 32);
            this.lblPersonID.TabIndex = 89;
            this.lblPersonID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(156, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "Person ID";
            // 
            // lblModeName
            // 
            this.lblModeName.AutoSize = true;
            this.lblModeName.Font = new System.Drawing.Font("Cambria", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lblModeName.Location = new System.Drawing.Point(694, 168);
            this.lblModeName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblModeName.Name = "lblModeName";
            this.lblModeName.Size = new System.Drawing.Size(291, 43);
            this.lblModeName.TabIndex = 64;
            this.lblModeName.Text = "Add New License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(783, 554);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 93;
            this.label2.Text = "Loading...";
            // 
            // ucPeopleSearch1
            // 
            this.ucPeopleSearch1.BackColor = System.Drawing.Color.White;
            this.ucPeopleSearch1.Location = new System.Drawing.Point(0, 0);
            this.ucPeopleSearch1.Name = "ucPeopleSearch1";
            this.ucPeopleSearch1.Size = new System.Drawing.Size(568, 50);
            this.ucPeopleSearch1.TabIndex = 94;
            this.ucPeopleSearch1.SearchComplete += new DVLDWinForms___Presentation_Layer.ucPeopleSearch.SearchCompleteEventHandler(this.ucPeopleSearch1_SearchComplete);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.user_edit;
            this.btnEditPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPerson.ForeColor = System.Drawing.Color.White;
            this.btnEditPerson.Location = new System.Drawing.Point(1560, 206);
            this.btnEditPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(52, 50);
            this.btnEditPerson.TabIndex = 95;
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Visible = false;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnPerviousPage
            // 
            this.btnPerviousPage.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.image__1_;
            this.btnPerviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPerviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPerviousPage.Location = new System.Drawing.Point(59, 1078);
            this.btnPerviousPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerviousPage.Name = "btnPerviousPage";
            this.btnPerviousPage.Size = new System.Drawing.Size(52, 50);
            this.btnPerviousPage.TabIndex = 97;
            this.btnPerviousPage.UseVisualStyleBackColor = true;
            this.btnPerviousPage.Visible = false;
            this.btnPerviousPage.Click += new System.EventHandler(this.btnPerviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.next;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Enabled = false;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(1570, 1078);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(52, 50);
            this.btnNextPage.TabIndex = 96;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.add_user__4_;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Location = new System.Drawing.Point(1563, 206);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(52, 50);
            this.btnAddPerson.TabIndex = 95;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::DVLDWinForms___Presentation_Layer.Properties.Resources.vote_no;
            this.btnClose.Location = new System.Drawing.Point(1632, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 92;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDWinForms___Presentation_Layer.Properties.Resources.face_id__1_;
            this.pictureBox2.Location = new System.Drawing.Point(98, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // pbModeIcon
            // 
            this.pbModeIcon.Image = global::DVLDWinForms___Presentation_Layer.Properties.Resources.license;
            this.pbModeIcon.Location = new System.Drawing.Point(781, 35);
            this.pbModeIcon.Name = "pbModeIcon";
            this.pbModeIcon.Size = new System.Drawing.Size(133, 130);
            this.pbModeIcon.TabIndex = 0;
            this.pbModeIcon.TabStop = false;
            // 
            // frmLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 1134);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLoading);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLicenseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicenseDetails";
            this.Load += new System.EventHandler(this.frmLicenseDetails_Load);
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnEditPerson;
        private ucPeopleSearch ucPeopleSearch1;
        private System.Windows.Forms.Panel pnlLicenseControlContainer;
        private System.Windows.Forms.Button btnPerviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModeName;
        private System.Windows.Forms.PictureBox pbModeIcon;
    }
}