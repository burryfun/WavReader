namespace UI.Views
{
    partial class RightChannelView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignalTitleLabel = new System.Windows.Forms.Label();
            this.SpectrumTitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpectrumPlot = new ScottPlot.FormsPlot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignalPlot = new ScottPlot.FormsPlot();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignalTitleLabel
            // 
            this.SignalTitleLabel.AutoSize = true;
            this.SignalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignalTitleLabel.Location = new System.Drawing.Point(10, 29);
            this.SignalTitleLabel.Name = "SignalTitleLabel";
            this.SignalTitleLabel.Size = new System.Drawing.Size(67, 25);
            this.SignalTitleLabel.TabIndex = 12;
            this.SignalTitleLabel.Text = "Signal";
            // 
            // SpectrumTitleLabel
            // 
            this.SpectrumTitleLabel.AutoSize = true;
            this.SpectrumTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpectrumTitleLabel.Location = new System.Drawing.Point(10, 376);
            this.SpectrumTitleLabel.Name = "SpectrumTitleLabel";
            this.SpectrumTitleLabel.Size = new System.Drawing.Size(96, 25);
            this.SpectrumTitleLabel.TabIndex = 13;
            this.SpectrumTitleLabel.Text = "Spectrum";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.SpectrumPlot);
            this.panel2.Location = new System.Drawing.Point(15, 404);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1237, 316);
            this.panel2.TabIndex = 15;
            // 
            // SpectrumPlot
            // 
            this.SpectrumPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpectrumPlot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SpectrumPlot.Location = new System.Drawing.Point(5, 5);
            this.SpectrumPlot.Name = "SpectrumPlot";
            this.SpectrumPlot.Size = new System.Drawing.Size(984, 306);
            this.SpectrumPlot.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.SignalPlot);
            this.panel1.Location = new System.Drawing.Point(15, 57);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1237, 316);
            this.panel1.TabIndex = 14;
            // 
            // SignalPlot
            // 
            this.SignalPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignalPlot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SignalPlot.Location = new System.Drawing.Point(5, 5);
            this.SignalPlot.Name = "SignalPlot";
            this.SignalPlot.Size = new System.Drawing.Size(984, 306);
            this.SignalPlot.TabIndex = 4;
            // 
            // RightChannelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignalTitleLabel);
            this.Controls.Add(this.SpectrumTitleLabel);
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "RightChannelView";
            this.Text = "RightChannelView";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignalTitleLabel;
        private System.Windows.Forms.Label SpectrumTitleLabel;
        private System.Windows.Forms.Panel panel2;
        private ScottPlot.FormsPlot SpectrumPlot;
        private System.Windows.Forms.Panel panel1;
        private ScottPlot.FormsPlot SignalPlot;
    }
}