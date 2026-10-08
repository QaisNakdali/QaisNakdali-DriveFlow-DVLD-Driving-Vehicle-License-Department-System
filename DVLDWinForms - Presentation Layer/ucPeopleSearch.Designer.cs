namespace DVLDWinForms___Presentation_Layer
{
    partial class ucPeopleSearch
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbPeopleSearchFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeopleSearchFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnSearchPerson);
            this.pnlMain.Controls.Add(this.tbSearch);
            this.pnlMain.Controls.Add(this.cbPeopleSearchFilter);
            this.pnlMain.Controls.Add(this.lblSearchBy);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(568, 50);
            this.pnlMain.TabIndex = 1;
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackgroundImage = global::DVLDWinForms___Presentation_Layer.Properties.Resources.user_avatar;
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPerson.ForeColor = System.Drawing.Color.White;
            this.btnSearchPerson.Location = new System.Drawing.Point(509, 0);
            this.btnSearchPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(52, 50);
            this.btnSearchPerson.TabIndex = 98;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tbSearch.Location = new System.Drawing.Point(332, 9);
            this.tbSearch.MaxLength = 50;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(169, 33);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // cbPeopleSearchFilter
            // 
            this.cbPeopleSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPeopleSearchFilter.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.TabCustom1;
            this.cbPeopleSearchFilter.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbPeopleSearchFilter.DropDownHeight = 400;
            this.cbPeopleSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeopleSearchFilter.DropDownWidth = 121;
            this.cbPeopleSearchFilter.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbPeopleSearchFilter.IntegralHeight = false;
            this.cbPeopleSearchFilter.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbPeopleSearchFilter.Location = new System.Drawing.Point(116, 6);
            this.cbPeopleSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbPeopleSearchFilter.Name = "cbPeopleSearchFilter";
            this.cbPeopleSearchFilter.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cbPeopleSearchFilter.Size = new System.Drawing.Size(206, 38);
            this.cbPeopleSearchFilter.StateTracking.Item.Back.Color1 = System.Drawing.Color.BlueViolet;
            this.cbPeopleSearchFilter.StateTracking.Item.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.cbPeopleSearchFilter.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cbPeopleSearchFilter.TabIndex = 19;
            this.cbPeopleSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cbPeopleSearchFilter_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Trebuchet MS", 7.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lblSearchBy.Location = new System.Drawing.Point(4, 12);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(104, 24);
            this.lblSearchBy.TabIndex = 20;
            this.lblSearchBy.Text = "Search By:";
            // 
            // ucPeopleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Name = "ucPeopleSearch";
            this.Size = new System.Drawing.Size(568, 50);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeopleSearchFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox tbSearch;
        private Krypton.Toolkit.KryptonComboBox cbPeopleSearchFilter;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Button btnSearchPerson;
    }
}
