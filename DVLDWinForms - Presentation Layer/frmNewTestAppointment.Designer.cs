namespace DVLDWinForms___Presentation_Layer
{
    partial class frmNewTestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTestAppointment));
            this.lblVisionTestAppointments = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.ucRetakeTest1 = new DVLDWinForms___Presentation_Layer.ucRetakeTest();
            this.ucAddNewTest1 = new DVLDWinForms___Presentation_Layer.ucAddNewTest();
            this.RetakeTestID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPass = new Krypton.Toolkit.KryptonRadioButton();
            this.rbFail = new Krypton.Toolkit.KryptonRadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlTestResults = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlTestResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisionTestAppointments
            // 
            this.lblVisionTestAppointments.AutoSize = true;
            this.lblVisionTestAppointments.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionTestAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lblVisionTestAppointments.Location = new System.Drawing.Point(302, 43);
            this.lblVisionTestAppointments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVisionTestAppointments.Name = "lblVisionTestAppointments";
            this.lblVisionTestAppointments.Size = new System.Drawing.Size(284, 61);
            this.lblVisionTestAppointments.TabIndex = 75;
            this.lblVisionTestAppointments.Text = "Book A Test";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlTestResults);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.lblVisionTestAppointments);
            this.pnlMain.Controls.Add(this.ucRetakeTest1);
            this.pnlMain.Controls.Add(this.ucAddNewTest1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(888, 1004);
            this.pnlMain.TabIndex = 76;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(847, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 94;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(367, 925);
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
            this.btnSave.TabIndex = 77;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucRetakeTest1
            // 
            this.ucRetakeTest1.BackColor = System.Drawing.Color.White;
            this.ucRetakeTest1.Enabled = false;
            this.ucRetakeTest1.Location = new System.Drawing.Point(-1, 616);
            this.ucRetakeTest1.Name = "ucRetakeTest1";
            this.ucRetakeTest1.Size = new System.Drawing.Size(906, 283);
            this.ucRetakeTest1.TabIndex = 1;
            // 
            // ucAddNewTest1
            // 
            this.ucAddNewTest1.BackColor = System.Drawing.Color.White;
            this.ucAddNewTest1.Location = new System.Drawing.Point(-1, 130);
            this.ucAddNewTest1.Name = "ucAddNewTest1";
            this.ucAddNewTest1.Size = new System.Drawing.Size(889, 479);
            this.ucAddNewTest1.TabIndex = 0;
            // 
            // RetakeTestID
            // 
            this.RetakeTestID.AutoSize = true;
            this.RetakeTestID.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetakeTestID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.RetakeTestID.Location = new System.Drawing.Point(52, 43);
            this.RetakeTestID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RetakeTestID.Name = "RetakeTestID";
            this.RetakeTestID.Size = new System.Drawing.Size(87, 32);
            this.RetakeTestID.TabIndex = 93;
            this.RetakeTestID.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(52, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 94;
            this.label1.Text = "Notes";
            // 
            // rbPass
            // 
            this.rbPass.Location = new System.Drawing.Point(314, 38);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(90, 37);
            this.rbPass.TabIndex = 95;
            this.rbPass.Values.Text = "Pass";
            // 
            // rbFail
            // 
            this.rbFail.Location = new System.Drawing.Point(486, 38);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(90, 37);
            this.rbFail.TabIndex = 96;
            this.rbFail.Values.Text = "Fail";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(314, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 152);
            this.textBox1.TabIndex = 97;
            // 
            // pnlTestResults
            // 
            this.pnlTestResults.Controls.Add(this.textBox1);
            this.pnlTestResults.Controls.Add(this.rbFail);
            this.pnlTestResults.Controls.Add(this.rbPass);
            this.pnlTestResults.Controls.Add(this.label1);
            this.pnlTestResults.Controls.Add(this.RetakeTestID);
            this.pnlTestResults.Location = new System.Drawing.Point(-1, 616);
            this.pnlTestResults.Name = "pnlTestResults";
            this.pnlTestResults.Size = new System.Drawing.Size(889, 283);
            this.pnlTestResults.TabIndex = 95;
            this.pnlTestResults.Visible = false;
            // 
            // frmNewTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 1004);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book a Test";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlTestResults.ResumeLayout(false);
            this.pnlTestResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucAddNewTest ucAddNewTest1;
        private ucRetakeTest ucRetakeTest1;
        private System.Windows.Forms.Label lblVisionTestAppointments;
        private System.Windows.Forms.Panel pnlMain;
        private Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlTestResults;
        private System.Windows.Forms.TextBox textBox1;
        private Krypton.Toolkit.KryptonRadioButton rbFail;
        private Krypton.Toolkit.KryptonRadioButton rbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RetakeTestID;
    }
}