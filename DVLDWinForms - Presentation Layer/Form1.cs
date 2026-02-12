using DVLDWinFormsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDWinFormsBusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.CompilerServices;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            clsNavigationService.Initialize(MainPanel, ucUpperBar1);
          
        }
    }
    
}
