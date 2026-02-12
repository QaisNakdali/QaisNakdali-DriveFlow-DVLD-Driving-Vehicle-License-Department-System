namespace DVLDWinForms___Presentation_Layer
{
    partial class frmPersonDetails
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModeName = new System.Windows.Forms.Label();
            this.pbModeIcon = new System.Windows.Forms.PictureBox();
            this.pnlUserControlContainer = new System.Windows.Forms.Panel();
            this.ucAddNewPersonCard2 = new DVLDWinForms___Presentation_Layer.ucAddNewPersonCard();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModeIcon)).BeginInit();
            this.pnlUserControlContainer.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnEditPerson);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.lblPersonID);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblModeName);
            this.pnlMain.Controls.Add(this.pbModeIcon);
            this.pnlMain.Controls.Add(this.pnlUserControlContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1679, 1134);
            this.pnlMain.TabIndex = 2;
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
            // lblPersonID
            // 
            this.lblPersonID.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPersonID.Location = new System.Drawing.Point(366, 238);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(382, 32);
            this.lblPersonID.TabIndex = 89;
            this.lblPersonID.Text = "N/A";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDWinForms___Presentation_Layer.Properties.Resources.face_id__1_;
            this.pictureBox2.Location = new System.Drawing.Point(98, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(156, 238);
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
            this.lblModeName.Location = new System.Drawing.Point(698, 168);
            this.lblModeName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblModeName.Name = "lblModeName";
            this.lblModeName.Size = new System.Drawing.Size(282, 43);
            this.lblModeName.TabIndex = 64;
            this.lblModeName.Text = "Add New Person";
            // 
            // pbModeIcon
            // 
            this.pbModeIcon.Image = global::DVLDWinForms___Presentation_Layer.Properties.Resources.add_user__2_;
            this.pbModeIcon.Location = new System.Drawing.Point(773, 35);
            this.pbModeIcon.Name = "pbModeIcon";
            this.pbModeIcon.Size = new System.Drawing.Size(133, 130);
            this.pbModeIcon.TabIndex = 0;
            this.pbModeIcon.TabStop = false;
            // 
            // pnlUserControlContainer
            // 
            this.pnlUserControlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnlUserControlContainer.Controls.Add(this.ucAddNewPersonCard2);
            this.pnlUserControlContainer.Location = new System.Drawing.Point(53, 290);
            this.pnlUserControlContainer.Name = "pnlUserControlContainer";
            this.pnlUserControlContainer.Size = new System.Drawing.Size(1573, 806);
            this.pnlUserControlContainer.TabIndex = 93;
            // 
            // ucAddNewPersonCard2
            // 
            this.ucAddNewPersonCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ucAddNewPersonCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddNewPersonCard2.Location = new System.Drawing.Point(0, 0);
            this.ucAddNewPersonCard2.Name = "ucAddNewPersonCard2";
            this.ucAddNewPersonCard2.Size = new System.Drawing.Size(1573, 806);
            this.ucAddNewPersonCard2.TabIndex = 91;
            this.ucAddNewPersonCard2.OnSaveComplete += new System.Action<int>(this.ucAddNewPersonCard2_OnSaveComplete);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.White;
            this.lblLoading.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lblLoading.Location = new System.Drawing.Point(783, 554);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(113, 27);
            this.lblLoading.TabIndex = 93;
            this.lblLoading.Text = "Loading...";
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.White;
            this.pnlLoading.Controls.Add(this.lblLoading);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoading.Location = new System.Drawing.Point(0, 0);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(1679, 1134);
            this.pnlLoading.TabIndex = 94;
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.user_edit;
            this.btnEditPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPerson.Location = new System.Drawing.Point(1561, 229);
            this.btnEditPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(52, 50);
            this.btnEditPerson.TabIndex = 94;
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Visible = false;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 1134);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModeIcon)).EndInit();
            this.pnlUserControlContainer.ResumeLayout(false);
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModeName;
        private System.Windows.Forms.PictureBox pbModeIcon;
        private ucAddNewPersonCard ucAddNewPersonCard2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Panel pnlUserControlContainer;
        private System.Windows.Forms.Button btnEditPerson;
    }
}