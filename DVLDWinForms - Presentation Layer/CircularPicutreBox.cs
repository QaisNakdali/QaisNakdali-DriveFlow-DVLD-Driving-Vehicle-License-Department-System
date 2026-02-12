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
    public partial class CircularPicutreBox : UserControl
    {
        public CircularPicutreBox()
        {
            InitializeComponent();
        }

        private Image ResizeImage(Image img,int width,int height)
        {
            Bitmap B = new Bitmap(width,height);

            using (Graphics G = Graphics.FromImage(B))
            {
                G.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                G.DrawImage(img,0,0,width,height);
            }
            return B;
        }

        private void MakeCircular(PictureBox PB)
        {
            int d = Math.Min(PB.Width,PB.Height);

            using (var Path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                Path.AddEllipse(0,0,d,d);
                PB.Region = new Region(Path);
            }
        }
        private void pbCircular_Resize(object sender, EventArgs e)
        {
            pbCircular.Image = ResizeImage(pbCircular.Image, pbCircular.Width, pbCircular.Height);
            MakeCircular(pbCircular);
        }
    }
}
