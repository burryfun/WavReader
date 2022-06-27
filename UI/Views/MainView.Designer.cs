namespace UI.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ShowMetadataButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignalPlot = new ScottPlot.FormsPlot();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.SignalTitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpectrumPlot = new ScottPlot.FormsPlot();
            this.SpectrumTitleLabel = new System.Windows.Forms.Label();
            this.ShowRightChannelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowMetadataButton
            // 
            this.ShowMetadataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowMetadataButton.Location = new System.Drawing.Point(1113, 15);
            this.ShowMetadataButton.Name = "ShowMetadataButton";
            this.ShowMetadataButton.Size = new System.Drawing.Size(75, 23);
            this.ShowMetadataButton.TabIndex = 3;
            this.ShowMetadataButton.Text = "Metadata";
            this.ShowMetadataButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.SignalPlot);
            this.panel1.Controls.Add(this.ShowMetadataButton);
            this.panel1.Location = new System.Drawing.Point(15, 57);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1237, 316);
            this.panel1.TabIndex = 5;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileDropDownButton
            // 
            this.FileDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.FileDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FileDropDownButton.Image")));
            this.FileDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileDropDownButton.Name = "FileDropDownButton";
            this.FileDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.FileDropDownButton.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 739);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(45, 13);
            this.FilePathLabel.TabIndex = 7;
            this.FilePathLabel.Text = "FilePath";
            this.FilePathLabel.Visible = false;
            // 
            // SignalTitleLabel
            // 
            this.SignalTitleLabel.AutoSize = true;
            this.SignalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignalTitleLabel.Location = new System.Drawing.Point(10, 29);
            this.SignalTitleLabel.Name = "SignalTitleLabel";
            this.SignalTitleLabel.Size = new System.Drawing.Size(67, 25);
            this.SignalTitleLabel.TabIndex = 8;
            this.SignalTitleLabel.Text = "Signal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.SpectrumPlot);
            this.panel2.Location = new System.Drawing.Point(15, 404);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1237, 316);
            this.panel2.TabIndex = 6;
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
            // SpectrumTitleLabel
            // 
            this.SpectrumTitleLabel.AutoSize = true;
            this.SpectrumTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpectrumTitleLabel.Location = new System.Drawing.Point(10, 376);
            this.SpectrumTitleLabel.Name = "SpectrumTitleLabel";
            this.SpectrumTitleLabel.Size = new System.Drawing.Size(96, 25);
            this.SpectrumTitleLabel.TabIndex = 9;
            this.SpectrumTitleLabel.Text = "Spectrum";
            // 
            // ShowRightChannelButton
            // 
            this.ShowRightChannelButton.Location = new System.Drawing.Point(156, 31);
            this.ShowRightChannelButton.Name = "ShowRightChannelButton";
            this.ShowRightChannelButton.Size = new System.Drawing.Size(89, 23);
            this.ShowRightChannelButton.TabIndex = 10;
            this.ShowRightChannelButton.Text = "RightChannel";
            this.ShowRightChannelButton.UseVisualStyleBackColor = true;
            this.ShowRightChannelButton.Visible = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.ShowRightChannelButton);
            this.Controls.Add(this.SpectrumTitleLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SignalTitleLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "MainView";
            this.Text = "WavReader";
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowMetadataButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label SignalTitleLabel;
        private ScottPlot.FormsPlot SignalPlot;
        private System.Windows.Forms.Panel panel2;
        private ScottPlot.FormsPlot SpectrumPlot;
        private System.Windows.Forms.Label SpectrumTitleLabel;
        private System.Windows.Forms.Button ShowRightChannelButton;
    }
}

