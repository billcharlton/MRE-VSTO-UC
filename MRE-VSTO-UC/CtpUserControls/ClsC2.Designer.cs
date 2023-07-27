
namespace MRE_VSTO_UC.CtpUserControls
{
    partial class ClsC2
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
            this.panel_C2 = new System.Windows.Forms.Panel();
            this.label2_C2 = new System.Windows.Forms.Label();
            this.textBox_C2 = new System.Windows.Forms.TextBox();
            this.label1_C2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel_P1)).BeginInit();
            this.tablePanel_P1.SuspendLayout();
            this.panel_C2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel_P1
            // 
            this.tablePanel_P1.Controls.Add(this.panel_C2);
            this.tablePanel_P1.Controls.SetChildIndex(this.panel_C2, 0);
            // 
            // panel_C2
            // 
            this.tablePanel_P1.SetColumn(this.panel_C2, 0);
            this.panel_C2.Controls.Add(this.label1_C2);
            this.panel_C2.Controls.Add(this.label2_C2);
            this.panel_C2.Controls.Add(this.textBox_C2);
            this.panel_C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_C2.Location = new System.Drawing.Point(13, 116);
            this.panel_C2.Name = "panel_C2";
            this.tablePanel_P1.SetRow(this.panel_C2, 1);
            this.panel_C2.Size = new System.Drawing.Size(224, 121);
            this.panel_C2.TabIndex = 1;
            // 
            // label2_C2
            // 
            this.label2_C2.AutoSize = true;
            this.label2_C2.Location = new System.Drawing.Point(19, 67);
            this.label2_C2.Name = "label2_C2";
            this.label2_C2.Size = new System.Drawing.Size(78, 13);
            this.label2_C2.TabIndex = 1;
            this.label2_C2.Text = "C2 data entry:";
            this.label2_C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_C2
            // 
            this.textBox_C2.Location = new System.Drawing.Point(112, 63);
            this.textBox_C2.Name = "textBox_C2";
            this.textBox_C2.Size = new System.Drawing.Size(100, 21);
            this.textBox_C2.TabIndex = 0;
            this.textBox_C2.Text = "data entry C2";
            // 
            // label1_C2
            // 
            this.label1_C2.AutoSize = true;
            this.label1_C2.Location = new System.Drawing.Point(19, 28);
            this.label1_C2.Name = "label1_C2";
            this.label1_C2.Size = new System.Drawing.Size(39, 13);
            this.label1_C2.TabIndex = 3;
            this.label1_C2.Text = "Child 2";
            this.label1_C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClsC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ClsC2";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel_P1)).EndInit();
            this.tablePanel_P1.ResumeLayout(false);
            this.panel_C2.ResumeLayout(false);
            this.panel_C2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_C2;
        private System.Windows.Forms.Label label2_C2;
        private System.Windows.Forms.TextBox textBox_C2;
        private System.Windows.Forms.Label label1_C2;
    }
}
