using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinForms___Presentation_Layer
{
    static public class clsUpperBarSettings
    {
        static public void ClearingEffectsFromOneButton(KryptonButton button)
        {
            button.StateCommon.Back.Color1 = Color.FromArgb(26, 23, 40);
            button.StateCommon.Back.Color2 = Color.FromArgb(26, 23, 40);

            button.StateCommon.Border.Color1 = Color.FromArgb(26, 23, 40);
            button.StateCommon.Border.Color2 = Color.FromArgb(26, 23, 40);

            button.StateCommon.Border.Rounding = 20;
            button.StateCommon.Border.Width = -1;

            button.StateNormal.Back.Color1 = Color.FromArgb(26, 23, 40);
            button.StateNormal.Back.Color2 = Color.FromArgb(26, 23, 40);

            button.StateNormal.Border.Color1 = Color.FromArgb(26, 23, 40);
            button.StateNormal.Border.Color2 = Color.FromArgb(26, 23, 40);

            button.StateNormal.Border.Rounding = 20;
            button.StateNormal.Border.Width = -1;

        }

        static public void ClickPageEffect(KryptonButton button)
        {
            button.StateCommon.Back.Color1 = Color.FromArgb(18, 18, 32);
            button.StateCommon.Back.Color2 = Color.FromArgb(18, 18, 32);

            button.StateCommon.Border.Color1 = Color.White;
            button.StateCommon.Border.Color2 = Color.Gray;

            button.StateCommon.Border.ColorAngle = 20;
            button.StateCommon.Border.Rounding = 20;
            button.StateCommon.Border.Width = 1;

            button.StateNormal.Back.Color1 = Color.FromArgb(18, 18, 32);
            button.StateNormal.Back.Color2 = Color.FromArgb(18, 18, 32);

            button.StateNormal.Border.Color1 = Color.White;
            button.StateNormal.Border.Color2 = Color.Gray;

            button.StateCommon.Border.ColorAngle = 20;
            button.StateNormal.Border.Rounding = 20;
            button.StateNormal.Border.Width = 1;
        }
    }
}
