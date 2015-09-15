using Jas.Utils.AnalyticalGrid;
namespace Jas.DataMerge {
    partial class GridForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv = new Jas.Utils.AnalyticalGrid.AnalyticalGrid();
            this.bBackFill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(885, 478);
            this.dgv.TabIndex = 2;
            this.dgv.ValueHistory = null;
            // 
            // bBackFill
            // 
            this.bBackFill.Location = new System.Drawing.Point(3, 2);
            this.bBackFill.Name = "bBackFill";
            this.bBackFill.Size = new System.Drawing.Size(75, 23);
            this.bBackFill.TabIndex = 3;
            this.bBackFill.Text = "Back Fill";
            this.bBackFill.UseVisualStyleBackColor = true;
            this.bBackFill.Click += new System.EventHandler(this.bBackFill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bBackFill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 28);
            this.panel1.TabIndex = 4;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 506);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Name = "GridForm";
            this.Text = "GridForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AnalyticalGrid dgv;
        private System.Windows.Forms.Button bBackFill;
        private System.Windows.Forms.Panel panel1;
    }
}