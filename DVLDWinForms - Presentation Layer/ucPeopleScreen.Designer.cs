namespace DVLDWinForms___Presentation_Layer
{
    partial class ucPeopleScreen
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
            this.cbPeopleSearchFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPeopleInformation = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sentEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeopleSearchFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleInformation)).BeginInit();
            this.cmsPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.tbSearch);
            this.MainPanel.Controls.Add(this.cbPeopleSearchFilter);
            this.MainPanel.Controls.Add(this.lblLoading);
            this.MainPanel.Controls.Add(this.btnAddUser);
            this.MainPanel.Controls.Add(this.lblNumberOfPeople);
            this.MainPanel.Controls.Add(this.lblRecords);
            this.MainPanel.Controls.Add(this.lblFilterBy);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.dgvPeopleInformation);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(2560, 1465);
            this.MainPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(1161, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "People Management";
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
            // cbPeopleSearchFilter
            // 
            this.cbPeopleSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPeopleSearchFilter.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabCustom1;
            this.cbPeopleSearchFilter.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbPeopleSearchFilter.DropDownHeight = 400;
            this.cbPeopleSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeopleSearchFilter.DropDownWidth = 121;
            this.cbPeopleSearchFilter.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbPeopleSearchFilter.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National NO",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Gender",
            "Phone",
            "Email",
            "Nationality",
            ""});
            this.cbPeopleSearchFilter.Location = new System.Drawing.Point(140, 151);
            this.cbPeopleSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbPeopleSearchFilter.Name = "cbPeopleSearchFilter";
            this.cbPeopleSearchFilter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cbPeopleSearchFilter.Size = new System.Drawing.Size(284, 37);
            this.cbPeopleSearchFilter.StateTracking.Item.Back.Color1 = System.Drawing.Color.BlueViolet;
            this.cbPeopleSearchFilter.StateTracking.Item.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.cbPeopleSearchFilter.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cbPeopleSearchFilter.TabIndex = 0;
            this.cbPeopleSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cbPeopleSearchFilter_SelectedIndexChanged);
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
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblNumberOfPeople.Location = new System.Drawing.Point(148, 1415);
            this.lblNumberOfPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(124, 27);
            this.lblNumberOfPeople.TabIndex = 14;
            this.lblNumberOfPeople.Text = "0";
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.crowd_of_users;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 138);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPeopleInformation
            // 
            this.dgvPeopleInformation.AllowUserToAddRows = false;
            this.dgvPeopleInformation.AllowUserToDeleteRows = false;
            this.dgvPeopleInformation.AllowUserToResizeColumns = false;
            this.dgvPeopleInformation.AllowUserToResizeRows = false;
            this.dgvPeopleInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPeopleInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeopleInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPeopleInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleInformation.ContextMenuStrip = this.cmsPeople;
            this.dgvPeopleInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPeopleInformation.Location = new System.Drawing.Point(32, 201);
            this.dgvPeopleInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPeopleInformation.Name = "dgvPeopleInformation";
            this.dgvPeopleInformation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.dgvPeopleInformation.ReadOnly = true;
            this.dgvPeopleInformation.RowHeadersVisible = false;
            this.dgvPeopleInformation.RowHeadersWidth = 82;
            this.dgvPeopleInformation.RowTemplate.Height = 35;
            this.dgvPeopleInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeopleInformation.Size = new System.Drawing.Size(2504, 1199);
            this.dgvPeopleInformation.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvPeopleInformation.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.dgvPeopleInformation.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvPeopleInformation.TabIndex = 0;
            // 
            // cmsPeople
            // 
            this.cmsPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsPeople.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonToolStripMenuItem,
            this.showPersonInfoToolStripMenuItem,
            this.updatePersonInfoToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sentEmailToolStripMenuItem,
            this.sendMessageToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshToolStripMenuItem});
            this.cmsPeople.Name = "cmsPeople";
            this.cmsPeople.Size = new System.Drawing.Size(301, 326);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.addPersonToolStripMenuItem.Text = "Add";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.showPersonInfoToolStripMenuItem.Text = "Show";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // updatePersonInfoToolStripMenuItem
            // 
            this.updatePersonInfoToolStripMenuItem.Name = "updatePersonInfoToolStripMenuItem";
            this.updatePersonInfoToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.updatePersonInfoToolStripMenuItem.Text = "Update";
            this.updatePersonInfoToolStripMenuItem.Click += new System.EventHandler(this.updatePersonInfoToolStripMenuItem_Click);
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
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.sendMessageToolStripMenuItem.Text = "Send Message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(297, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // ucPeopleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPeopleScreen";
            this.Size = new System.Drawing.Size(2560, 1465);
            this.Load += new System.EventHandler(this.ucPeopleScreen_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeopleSearchFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleInformation)).EndInit();
            this.cmsPeople.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvPeopleInformation;
        private System.Windows.Forms.Label lblLoading;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbPeopleSearchFilter;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sentEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
