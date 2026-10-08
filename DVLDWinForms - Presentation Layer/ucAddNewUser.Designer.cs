namespace DVLDWinForms___Presentation_Layer
{
    partial class ucAddNewUser
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.chkIsActive = new Krypton.Toolkit.KryptonCheckBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new Krypton.Toolkit.KryptonTextBox();
            this.tbPassword = new Krypton.Toolkit.KryptonTextBox();
            this.tbUsername = new Krypton.Toolkit.KryptonTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblUserID);
            this.pnlMain.Controls.Add(this.UserID);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.chkIsActive);
            this.pnlMain.Controls.Add(this.lblUsername);
            this.pnlMain.Controls.Add(this.lblConfirmPassword);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.tbConfirmPassword);
            this.pnlMain.Controls.Add(this.tbPassword);
            this.pnlMain.Controls.Add(this.tbUsername);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1573, 806);
            this.pnlMain.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Red;
            this.lblUserID.Location = new System.Drawing.Point(887, 65);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(65, 32);
            this.lblUserID.TabIndex = 71;
            this.lblUserID.Text = "[???]";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.UserID.Location = new System.Drawing.Point(420, 65);
            this.UserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(95, 32);
            this.UserID.TabIndex = 70;
            this.UserID.Text = "UserID";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(763, 623);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(230)))));
            this.btnSave.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(245)))));
            this.btnSave.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.OverrideDefault.Border.Rounding = 25F;
            this.btnSave.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnSave.Size = new System.Drawing.Size(155, 57);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(230)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(245)))));
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 25F;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnSave.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(230)))));
            this.btnSave.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(245)))));
            this.btnSave.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateDisabled.Border.Rounding = 25F;
            this.btnSave.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnSave.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(230)))));
            this.btnSave.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(245)))));
            this.btnSave.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateNormal.Border.Rounding = 25F;
            this.btnSave.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnSave.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSave.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.btnSave.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StatePressed.Border.Rounding = 25F;
            this.btnSave.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnSave.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(230)))));
            this.btnSave.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(245)))));
            this.btnSave.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateTracking.Border.Rounding = 25F;
            this.btnSave.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnSave.TabIndex = 69;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(571, 623);
            this.btnClear.Name = "btnClear";
            this.btnClear.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnClear.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.btnClear.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.OverrideDefault.Border.Rounding = 25F;
            this.btnClear.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnClear.Size = new System.Drawing.Size(155, 57);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.btnClear.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.Rounding = 25F;
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnClear.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnClear.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.btnClear.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateDisabled.Border.Rounding = 25F;
            this.btnClear.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnClear.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnClear.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.btnClear.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateNormal.Border.Rounding = 25F;
            this.btnClear.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnClear.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnClear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.btnClear.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StatePressed.Border.Rounding = 25F;
            this.btnClear.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnClear.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnClear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.btnClear.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateTracking.Border.Rounding = 25F;
            this.btnClear.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.btnClear.TabIndex = 68;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.Location = new System.Drawing.Point(821, 505);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.chkIsActive.Size = new System.Drawing.Size(216, 38);
            this.chkIsActive.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.chkIsActive.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.chkIsActive.StateCommon.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.chkIsActive.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.chkIsActive.StateDisabled.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.chkIsActive.StateDisabled.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.chkIsActive.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.chkIsActive.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.chkIsActive.StateNormal.ShortText.Font = new System.Drawing.Font("Cambria", 10.125F);
            this.chkIsActive.TabIndex = 67;
            this.chkIsActive.Values.Text = "Is Active User?";
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblUsername.Location = new System.Drawing.Point(420, 172);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(143, 32);
            this.lblUsername.TabIndex = 66;
            this.lblUsername.Text = "Username*";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(422, 410);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(237, 32);
            this.lblConfirmPassword.TabIndex = 65;
            this.lblConfirmPassword.Text = "Confirm Passwrod*";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.lblPassword.Location = new System.Drawing.Point(422, 291);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(138, 32);
            this.lblPassword.TabIndex = 64;
            this.lblPassword.Text = "Passwrod*";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(702, 399);
            this.tbConfirmPassword.MaxLength = 12;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(434, 55);
            this.tbConfirmPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbConfirmPassword.StateCommon.Border.Rounding = 25F;
            this.tbConfirmPassword.TabIndex = 8;
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(702, 280);
            this.tbPassword.MaxLength = 12;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(434, 55);
            this.tbPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPassword.StateCommon.Border.Rounding = 25F;
            this.tbPassword.TabIndex = 7;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(702, 161);
            this.tbUsername.MaxLength = 12;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.tbUsername.Size = new System.Drawing.Size(434, 55);
            this.tbUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUsername.StateCommon.Border.Rounding = 25F;
            this.tbUsername.TabIndex = 6;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ucAddNewUser";
            this.Size = new System.Drawing.Size(1573, 806);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Krypton.Toolkit.KryptonTextBox tbPassword;
        private Krypton.Toolkit.KryptonTextBox tbUsername;
        private Krypton.Toolkit.KryptonTextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private Krypton.Toolkit.KryptonCheckBox chkIsActive;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label UserID;
    }
}
