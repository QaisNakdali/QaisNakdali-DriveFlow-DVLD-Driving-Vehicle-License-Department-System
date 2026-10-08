namespace DVLDWinForms___Presentation_Layer
{
    partial class ucUsersScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.cbIsActive = new Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbUsersSearchFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvUsersInformation = new Krypton.Toolkit.KryptonDataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sentEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsersSearchFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersInformation)).BeginInit();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2560, 1465);
            this.panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.MainPanel.Controls.Add(this.cbIsActive);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.tbSearch);
            this.MainPanel.Controls.Add(this.cbUsersSearchFilter);
            this.MainPanel.Controls.Add(this.lblLoading);
            this.MainPanel.Controls.Add(this.btnAddUser);
            this.MainPanel.Controls.Add(this.lblNumberOfUsers);
            this.MainPanel.Controls.Add(this.lblRecords);
            this.MainPanel.Controls.Add(this.lblFilterBy);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.dgvUsersInformation);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(2560, 1465);
            this.MainPanel.TabIndex = 6;
            // 
            // cbIsActive
            // 
            this.cbIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIsActive.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.TabCustom1;
            this.cbIsActive.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbIsActive.DropDownHeight = 400;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.DropDownWidth = 121;
            this.cbIsActive.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbIsActive.IntegralHeight = false;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(445, 149);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cbIsActive.Size = new System.Drawing.Size(134, 38);
            this.cbIsActive.StateTracking.Item.Back.Color1 = System.Drawing.Color.BlueViolet;
            this.cbIsActive.StateTracking.Item.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.cbIsActive.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cbIsActive.TabIndex = 20;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(1161, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Users Management";
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
            // cbUsersSearchFilter
            // 
            this.cbUsersSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUsersSearchFilter.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.TabCustom1;
            this.cbUsersSearchFilter.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbUsersSearchFilter.DropDownHeight = 400;
            this.cbUsersSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersSearchFilter.DropDownWidth = 121;
            this.cbUsersSearchFilter.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbUsersSearchFilter.IntegralHeight = false;
            this.cbUsersSearchFilter.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "Username",
            "Is Active"});
            this.cbUsersSearchFilter.Location = new System.Drawing.Point(140, 151);
            this.cbUsersSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbUsersSearchFilter.Name = "cbUsersSearchFilter";
            this.cbUsersSearchFilter.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cbUsersSearchFilter.Size = new System.Drawing.Size(284, 38);
            this.cbUsersSearchFilter.StateTracking.Item.Back.Color1 = System.Drawing.Color.BlueViolet;
            this.cbUsersSearchFilter.StateTracking.Item.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.cbUsersSearchFilter.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cbUsersSearchFilter.TabIndex = 0;
            this.cbUsersSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cbUsersSearchFilter_SelectedIndexChanged);
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
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblNumberOfUsers.Location = new System.Drawing.Point(148, 1415);
            this.lblNumberOfUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfUsers.Name = "lblNumberOfUsers";
            this.lblNumberOfUsers.Size = new System.Drawing.Size(124, 27);
            this.lblNumberOfUsers.TabIndex = 14;
            this.lblNumberOfUsers.Text = "0";
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
            // dgvUsersInformation
            // 
            this.dgvUsersInformation.AllowUserToAddRows = false;
            this.dgvUsersInformation.AllowUserToDeleteRows = false;
            this.dgvUsersInformation.AllowUserToResizeColumns = false;
            this.dgvUsersInformation.AllowUserToResizeRows = false;
            this.dgvUsersInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUsersInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsersInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersInformation.ContextMenuStrip = this.cmsUsers;
            this.dgvUsersInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUsersInformation.Location = new System.Drawing.Point(32, 201);
            this.dgvUsersInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsersInformation.Name = "dgvUsersInformation";
            this.dgvUsersInformation.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.dgvUsersInformation.ReadOnly = true;
            this.dgvUsersInformation.RowHeadersVisible = false;
            this.dgvUsersInformation.RowHeadersWidth = 82;
            this.dgvUsersInformation.RowTemplate.Height = 35;
            this.dgvUsersInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersInformation.Size = new System.Drawing.Size(2504, 1199);
            this.dgvUsersInformation.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvUsersInformation.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvUsersInformation.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvUsersInformation.TabIndex = 0;
            // 
            // cmsUsers
            // 
            this.cmsUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.showUserInfoToolStripMenuItem,
            this.updateUserInfoToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sentEmailToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendMessageToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.cmsUsers.Name = "cmsPeople";
            this.cmsUsers.Size = new System.Drawing.Size(301, 326);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.addUserToolStripMenuItem.Text = "Add";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // showUserInfoToolStripMenuItem
            // 
            this.showUserInfoToolStripMenuItem.Name = "showUserInfoToolStripMenuItem";
            this.showUserInfoToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.showUserInfoToolStripMenuItem.Text = "Show";
            this.showUserInfoToolStripMenuItem.Click += new System.EventHandler(this.showUserInfoToolStripMenuItem_Click);
            // 
            // updateUserInfoToolStripMenuItem
            // 
            this.updateUserInfoToolStripMenuItem.Name = "updateUserInfoToolStripMenuItem";
            this.updateUserInfoToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.updateUserInfoToolStripMenuItem.Text = "Update";
            this.updateUserInfoToolStripMenuItem.Click += new System.EventHandler(this.updateUserInfoToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(297, 6);
            // 
            // sentEmailToolStripMenuItem
            // 
            this.sentEmailToolStripMenuItem.Name = "sentEmailToolStripMenuItem";
            this.sentEmailToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.sentEmailToolStripMenuItem.Text = "Send Email";
            this.sentEmailToolStripMenuItem.Click += new System.EventHandler(this.sentEmailToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(297, 6);
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.sendMessageToolStripMenuItem.Text = "Send Message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.add_user;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(2484, 134);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(52, 50);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.multi_users__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 138);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ucUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ucUsersScreen";
            this.Size = new System.Drawing.Size(2560, 1465);
            this.Load += new System.EventHandler(this.ucUsersScreen_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsersSearchFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersInformation)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private Krypton.Toolkit.KryptonComboBox cbUsersSearchFilter;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblNumberOfUsers;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDataGridView dgvUsersInformation;
        private Krypton.Toolkit.KryptonComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sentEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
