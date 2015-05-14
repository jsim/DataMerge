using Jas.Utils.AnalyticalGrid;

namespace Jas.DataMerge {
    partial class Form1 {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bPair = new System.Windows.Forms.Button();
            this.bFilterSame = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv1 = new Jas.Utils.AnalyticalGrid.AnalyticalGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bLoad1 = new System.Windows.Forms.Button();
            this.dgv2 = new Jas.Utils.AnalyticalGrid.AnalyticalGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bLoad2 = new System.Windows.Forms.Button();
            this.od1 = new System.Windows.Forms.OpenFileDialog();
            this.bCsvConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bPair);
            this.panel1.Controls.Add(this.bFilterSame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 55);
            this.panel1.TabIndex = 0;
            // 
            // bPair
            // 
            this.bPair.Location = new System.Drawing.Point(180, 16);
            this.bPair.Name = "bPair";
            this.bPair.Size = new System.Drawing.Size(149, 23);
            this.bPair.TabIndex = 2;
            this.bPair.Text = "Pair rows with same key";
            this.bPair.UseVisualStyleBackColor = true;
            this.bPair.Click += new System.EventHandler(this.bPair_Click);
            // 
            // bFilterSame
            // 
            this.bFilterSame.Location = new System.Drawing.Point(12, 16);
            this.bFilterSame.Name = "bFilterSame";
            this.bFilterSame.Size = new System.Drawing.Size(149, 23);
            this.bFilterSame.TabIndex = 1;
            this.bFilterSame.Text = "Filter rows with same key";
            this.bFilterSame.UseVisualStyleBackColor = true;
            this.bFilterSame.Click += new System.EventHandler(this.bFilterSame_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(934, 486);
            this.splitContainer1.SplitterDistance = 475;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 48);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(475, 438);
            this.dgv1.TabIndex = 1;
            this.dgv1.ValueHistory = null;
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bCsvConfig);
            this.panel2.Controls.Add(this.bLoad1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 48);
            this.panel2.TabIndex = 0;
            // 
            // bLoad1
            // 
            this.bLoad1.Location = new System.Drawing.Point(12, 12);
            this.bLoad1.Name = "bLoad1";
            this.bLoad1.Size = new System.Drawing.Size(98, 23);
            this.bLoad1.TabIndex = 0;
            this.bLoad1.Text = "Open CSV...";
            this.bLoad1.UseVisualStyleBackColor = true;
            this.bLoad1.Click += new System.EventHandler(this.bLoad1_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv2.Location = new System.Drawing.Point(0, 48);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Size = new System.Drawing.Size(455, 438);
            this.dgv2.TabIndex = 2;
            this.dgv2.ValueHistory = null;
            this.dgv2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bLoad2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 48);
            this.panel3.TabIndex = 1;
            // 
            // bLoad2
            // 
            this.bLoad2.Location = new System.Drawing.Point(13, 12);
            this.bLoad2.Name = "bLoad2";
            this.bLoad2.Size = new System.Drawing.Size(98, 23);
            this.bLoad2.TabIndex = 1;
            this.bLoad2.Text = "Open CSV...";
            this.bLoad2.UseVisualStyleBackColor = true;
            this.bLoad2.Click += new System.EventHandler(this.bLoad2_Click);
            // 
            // od1
            // 
            this.od1.Filter = "CSV Files|*.csv|All|*.*";
            this.od1.RestoreDirectory = true;
            // 
            // bCsvConfig
            // 
            this.bCsvConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCsvConfig.BackColor = System.Drawing.Color.Silver;
            this.bCsvConfig.ForeColor = System.Drawing.Color.Black;
            this.bCsvConfig.Location = new System.Drawing.Point(361, 11);
            this.bCsvConfig.Name = "bCsvConfig";
            this.bCsvConfig.Size = new System.Drawing.Size(98, 23);
            this.bCsvConfig.TabIndex = 1;
            this.bCsvConfig.Text = "CSV Settings...";
            this.bCsvConfig.UseVisualStyleBackColor = false;
            this.bCsvConfig.Click += new System.EventHandler(this.bCsvConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataMerge Studio";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bLoad1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bLoad2;
        private AnalyticalGrid dgv1;
        private AnalyticalGrid dgv2;
        private System.Windows.Forms.OpenFileDialog od1;
        private System.Windows.Forms.Button bFilterSame;
        private System.Windows.Forms.Button bPair;
        private System.Windows.Forms.Button bCsvConfig;
    }
}

