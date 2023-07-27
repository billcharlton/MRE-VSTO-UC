
namespace MRE_VSTO_UC
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.toggleButton1_P1 = this.Factory.CreateRibbonToggleButton();
            this.toggleButton2_P1 = this.Factory.CreateRibbonToggleButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.toggleButton1_P2 = this.Factory.CreateRibbonToggleButton();
            this.toggleButton2_P2 = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "WORD VSTO MRE";
            this.tab1.Name = "tab1";
            this.tab1.Position = this.Factory.RibbonPosition.BeforeOfficeId("HelpTab");
            // 
            // group1
            // 
            this.group1.Items.Add(this.toggleButton1_P1);
            this.group1.Items.Add(this.toggleButton2_P1);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.toggleButton1_P2);
            this.group1.Items.Add(this.toggleButton2_P2);
            this.group1.Label = "Show P1 or P2 or neither";
            this.group1.Name = "group1";
            // 
            // toggleButton1_P1
            // 
            this.toggleButton1_P1.Label = "P1 - C1";
            this.toggleButton1_P1.Name = "toggleButton1_P1";
            this.toggleButton1_P1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton_Click);
            // 
            // toggleButton2_P1
            // 
            this.toggleButton2_P1.Label = "P1 - C2";
            this.toggleButton2_P1.Name = "toggleButton2_P1";
            this.toggleButton2_P1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // toggleButton1_P2
            // 
            this.toggleButton1_P2.Label = "P2 - C1";
            this.toggleButton1_P2.Name = "toggleButton1_P2";
            this.toggleButton1_P2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton_Click);
            // 
            // toggleButton2_P2
            // 
            this.toggleButton2_P2.Label = "P2 - C2";
            this.toggleButton2_P2.Name = "toggleButton2_P2";
            this.toggleButton2_P2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1_P1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton2_P1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton2_P2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1_P2;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
