using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Ribbon;

namespace MRE_VSTO_UC
{
    public partial class Ribbon1
    {
        private void ToggleButton_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonToggleButton ribbonToggleButtonClicked = ((RibbonToggleButton)sender);

            foreach (CustomTaskPane ctp in Globals.ThisAddIn.CustomTaskPanes)
            {
                if (ctp.Title.Equals(ribbonToggleButtonClicked.Label))
                {
                    ctp.Visible ^= true;
                    ribbonToggleButtonClicked.Checked = ctp.Visible;
                }
                else
                {
                    if (ctp.Visible)
                    {
                        ctp.Visible = false;

                        // whatever ctp this is, manage its toggleButton.Checked
                        foreach (RibbonControl ribbonControl in Globals.Ribbons.Ribbon1.group1.Items)
                        {
                            if (ribbonControl is RibbonToggleButton button)
                            {
                                if (button.Label.Equals(ctp.Title))
                                {
                                    if (button.Checked)
                                    {
                                        button.Checked = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
