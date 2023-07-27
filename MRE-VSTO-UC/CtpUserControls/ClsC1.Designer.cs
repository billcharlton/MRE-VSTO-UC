
namespace MRE_VSTO_UC
{
    partial class ClsC1
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
            this.panel_C1 = new System.Windows.Forms.Panel();
            this.textBox_C1 = new System.Windows.Forms.TextBox();
            this.label2_C1 = new System.Windows.Forms.Label();
            this.label1_C1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel_P1)).BeginInit();
            this.tablePanel_P1.SuspendLayout();
            this.panel_C1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel_P1
            // 
            this.tablePanel_P1.Controls.Add(this.panel_C1);
            this.tablePanel_P1.Controls.SetChildIndex(this.panel_C1, 0);
            // 
            // panel_C1
            // 
            this.tablePanel_P1.SetColumn(this.panel_C1, 0);
            this.panel_C1.Controls.Add(this.label1_C1);
            this.panel_C1.Controls.Add(this.textBox_C1);
            this.panel_C1.Controls.Add(this.label2_C1);
            this.panel_C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_C1.Location = new System.Drawing.Point(13, 116);
            this.panel_C1.Name = "panel_C1";
            this.tablePanel_P1.SetRow(this.panel_C1, 1);
            this.panel_C1.Size = new System.Drawing.Size(224, 121);
            this.panel_C1.TabIndex = 1;
            // 
            // textBox_C1
            // 
            this.textBox_C1.Location = new System.Drawing.Point(98, 57);
            this.textBox_C1.Name = "textBox_C1";
            this.textBox_C1.Size = new System.Drawing.Size(100, 21);
            this.textBox_C1.TabIndex = 1;
            this.textBox_C1.Text = "data entry C1";
            // 
            // label2_C1
            // 
            this.label2_C1.AutoSize = true;
            this.label2_C1.Location = new System.Drawing.Point(14, 61);
            this.label2_C1.Name = "label2_C1";
            this.label2_C1.Size = new System.Drawing.Size(78, 13);
            this.label2_C1.TabIndex = 0;
            this.label2_C1.Text = "C1 data entry:";
            this.label2_C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1_C1
            // 
            this.label1_C1.AutoSize = true;
            this.label1_C1.Location = new System.Drawing.Point(14, 15);
            this.label1_C1.Name = "label1_C1";
            this.label1_C1.Size = new System.Drawing.Size(39, 13);
            this.label1_C1.TabIndex = 2;
            this.label1_C1.Text = "Child 1";
            this.label1_C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClsC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ClsC1";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel_P1)).EndInit();
            this.tablePanel_P1.ResumeLayout(false);
            this.panel_C1.ResumeLayout(false);
            this.panel_C1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_C1;
        private System.Windows.Forms.TextBox textBox_C1;
        private System.Windows.Forms.Label label2_C1;
        private System.Windows.Forms.Label label1_C1;
    }
}
