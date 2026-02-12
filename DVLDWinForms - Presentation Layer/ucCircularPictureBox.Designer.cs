namespace DVLDWinForms___Presentation_Layer
{
    partial class ucCircularPictureBox
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
            this.pbCircular = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircular)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCircular
            // 
            this.pbCircular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCircular.Image = global::DVLDWinForms___Presentation_Layer.Properties.Resources.ManDefaultPicture;
            this.pbCircular.Location = new System.Drawing.Point(0, 0);
            this.pbCircular.Name = "pbCircular";
            this.pbCircular.Size = new System.Drawing.Size(150, 150);
            this.pbCircular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCircular.TabIndex = 0;
            this.pbCircular.TabStop = false;
            // 
            // ucCircularPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pbCircular);
            this.Name = "ucCircularPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbCircular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCircular;
    }
}
