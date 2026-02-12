using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class ucCircularPictureBox : UserControl
    {
        public ucCircularPictureBox()
        {
            InitializeComponent();

            if (DesignMode) return;

            if (pbCircular.Image == null)
            {
                SetDefualtProfilePicture(true);
            }

            if (pbCircular.Image != null)
            {
                pbCircular.Image = ResizeImage(pbCircular.Image, 200, 200);
            }

            MakeCircular(pbCircular);
        }

        public Image CurrentImage
        {
            get { return pbCircular.Image; }
        }
        public enum PictureMode { Small = 0, Large = 1 }
        public bool IsDefault = true;

        public void SetDefualtProfilePicture(bool IsWoman)
        {
            if (IsWoman)
            {
                pbCircular.Image = Properties.Resources.WomanDefaultPitcutre;
            }
            else
            {
                pbCircular.Image = Properties.Resources.ManDefaultPicture;
            }

            IsDefault = true;
        }

        public void SetCustomProfilePicture(string ImageFileName)
        {
            pbCircular.ImageLocation = ImageFileName;
            IsDefault = false;
        }

        public PictureMode Mode
        {
            set
            {
                if (value == PictureMode.Small)
                {
                    this.Size = new Size(50, 55);
                }
                else if (value == PictureMode.Large)
                {
                    this.Size = new Size(397, 391);
                }

                MakeCircular(pbCircular);
            }
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap B = new Bitmap(width, height);

            using (Graphics G = Graphics.FromImage(B))
            {
                G.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                G.DrawImage(img, 0, 0, width, height);
            }
            return B;
        }

        private void MakeCircular(PictureBox PB)
        {
            int d = Math.Min(PB.Width, PB.Height);

            using (var Path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                Path.AddEllipse(0, 0, d, d);
                PB.Region = new Region(Path);
            }
        }
    }
}
