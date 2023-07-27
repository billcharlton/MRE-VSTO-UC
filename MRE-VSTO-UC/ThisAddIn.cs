using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Ribbon;
using MRE_VSTO_UC.CtpUserControls;
using System;

namespace MRE_VSTO_UC
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Globals.ThisAddIn.Application.DocumentChange += ThisAddIn_DocumentChange;

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        internal void ThisAddIn_DocumentChange()
        {
            try
            {
                if (CustomTaskPanes.Count == 0)
                {
                    (Globals.ThisAddIn.CustomTaskPanes.Add(control: new ClsC1(), title: Globals.Ribbons.Ribbon1.toggleButton1_P1.Label, window: Globals.ThisAddIn.Application.ActiveWindow)).VisibleChanged += Ctp_VisibleChanged;

                    //=========

                    (Globals.ThisAddIn.CustomTaskPanes.Add(control: new ClsC2(), title: Globals.Ribbons.Ribbon1.toggleButton2_P1.Label, window: Globals.ThisAddIn.Application.ActiveWindow)).VisibleChanged += Ctp_VisibleChanged;

                    //=========
                    (Globals.ThisAddIn.CustomTaskPanes.Add(control: new ClsC1(), title: Globals.Ribbons.Ribbon1.toggleButton1_P2.Label, window: Globals.ThisAddIn.Application.ActiveWindow)).VisibleChanged += Ctp_VisibleChanged;

                    //=========

                    (Globals.ThisAddIn.CustomTaskPanes.Add(control: new ClsC2(), title: Globals.Ribbons.Ribbon1.toggleButton2_P2.Label, window: Globals.ThisAddIn.Application.ActiveWindow)).VisibleChanged += Ctp_VisibleChanged;
                }
            }
            catch (Exception e)
            {
                if (e.Message.Equals("This command is not available because no document is open."))
                {
                    // remain silent
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// <para>=======================================================================================</para>
        /// <para>DOES NOT FIRE EVERY TIME A CTP's VISIBILITY CHANGES!</para>
        /// <para></para>
        /// <para>FIRES ONLY WHEN:</para>
        /// <para>Case 1: ONCE when a user clicks "X" on a visible task pane.</para>
        /// <para>Case 2: TWICE when a user does, e.g., clicks the File button (e.g., to do File->Open)***.</para>
        /// <para>=======================================================================================</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ctp_VisibleChanged(object sender, System.EventArgs e)
        {
            CustomTaskPane ctp = ((CustomTaskPane)sender);

            if (ctp.Visible == false)
            {
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

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
