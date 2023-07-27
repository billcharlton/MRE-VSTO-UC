
namespace MRE_VSTO_UC.CtpUserControls
{
    partial class ClsP1
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
            this.tablePanel_P1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel_P1 = new System.Windows.Forms.Panel();
            this.checkBox_P1 = new System.Windows.Forms.CheckBox();
            this.button2_P1 = new System.Windows.Forms.Button();
            this.button1_P1 = new System.Windows.Forms.Button();
            this.label_P1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel_P1)).BeginInit();
            this.tablePanel_P1.SuspendLayout();
            this.panel_P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel_P1
            // 
            this.tablePanel_P1.AutoSize = true;
            this.tablePanel_P1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel_P1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F)});
            this.tablePanel_P1.Controls.Add(this.panel_P1);
            this.tablePanel_P1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_P1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel_P1.Name = "tablePanel_P1";
            this.tablePanel_P1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 0F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel_P1.Size = new System.Drawing.Size(350, 250);
            this.tablePanel_P1.TabIndex = 0;
            this.tablePanel_P1.UseSkinIndents = true;
            // 
            // panel_P1
            // 
            this.tablePanel_P1.SetColumn(this.panel_P1, 0);
            this.panel_P1.Controls.Add(this.label_P1);
            this.panel_P1.Controls.Add(this.checkBox_P1);
            this.panel_P1.Controls.Add(this.button2_P1);
            this.panel_P1.Controls.Add(this.button1_P1);
            this.panel_P1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_P1.Location = new System.Drawing.Point(13, 12);
            this.panel_P1.Name = "panel_P1";
            this.tablePanel_P1.SetRow(this.panel_P1, 0);
            this.panel_P1.Size = new System.Drawing.Size(324, 100);
            this.panel_P1.TabIndex = 0;
            // 
            // checkBox_P1
            // 
            this.checkBox_P1.AutoSize = true;
            this.checkBox_P1.Location = new System.Drawing.Point(3, 71);
            this.checkBox_P1.Name = "checkBox_P1";
            this.checkBox_P1.Size = new System.Drawing.Size(89, 17);
            this.checkBox_P1.TabIndex = 2;
            this.checkBox_P1.Text = "checkBox_P1";
            this.checkBox_P1.UseVisualStyleBackColor = true;
            // 
            // button2_P1
            // 
            this.button2_P1.Location = new System.Drawing.Point(3, 37);
            this.button2_P1.Name = "button2_P1";
            this.button2_P1.Size = new System.Drawing.Size(75, 23);
            this.button2_P1.TabIndex = 1;
            this.button2_P1.Text = "button2_P1";
            this.button2_P1.UseVisualStyleBackColor = true;
            // 
            // button1_P1
            // 
            this.button1_P1.AutoSize = true;
            this.button1_P1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1_P1.Location = new System.Drawing.Point(3, 3);
            this.button1_P1.Name = "button1_P1";
            this.button1_P1.Size = new System.Drawing.Size(73, 23);
            this.button1_P1.TabIndex = 0;
            this.button1_P1.Text = "button1_P1";
            this.button1_P1.UseVisualStyleBackColor = true;
            // 
            // label_P1
            // 
            this.label_P1.AutoSize = true;
            this.label_P1.Location = new System.Drawing.Point(143, 12);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(48, 13);
            this.label_P1.TabIndex = 3;
            this.label_P1.Text = "Parent 1";
            this.label_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClsP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel_P1);
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "ClsP1";
            this.Size = new System.Drawing.Size(350, 250);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel_P1)).EndInit();
            this.tablePanel_P1.ResumeLayout(false);
            this.panel_P1.ResumeLayout(false);
            this.panel_P1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.Utils.Layout.TablePanel tablePanel_P1;
        private System.Windows.Forms.Panel panel_P1;
        private System.Windows.Forms.Button button2_P1;
        private System.Windows.Forms.Button button1_P1;
        private System.Windows.Forms.CheckBox checkBox_P1;
        private System.Windows.Forms.Label label_P1;
    }
}
