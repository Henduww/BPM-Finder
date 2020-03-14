namespace BPM_Finder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.ResetInstructions4 = new System.Windows.Forms.Label();
            this.ResetBPMButton = new System.Windows.Forms.Button();
            this.ResetInstructions3 = new System.Windows.Forms.Label();
            this.ResetInstructions2 = new System.Windows.Forms.Label();
            this.SecondsToReset = new System.Windows.Forms.NumericUpDown();
            this.ResetInstructions1 = new System.Windows.Forms.Label();
            this.TapTimes_Panel = new System.Windows.Forms.Panel();
            this.TapTimes = new System.Windows.Forms.Label();
            this.TapTimes_Label = new System.Windows.Forms.Label();
            this.NearestWhole_Panel = new System.Windows.Forms.Panel();
            this.NearestWhole = new System.Windows.Forms.Label();
            this.NearestWhole_Label = new System.Windows.Forms.Label();
            this.AvgBPM_Panel = new System.Windows.Forms.Panel();
            this.AvgBPM = new System.Windows.Forms.Label();
            this.AvgBPM_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResetTimer = new System.Windows.Forms.Timer(this.components);
            this.TapButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.CreatorLabel = new System.Windows.Forms.Label();
            this.MetronomeImage = new System.Windows.Forms.PictureBox();
            this.InstructionsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsToReset)).BeginInit();
            this.TapTimes_Panel.SuspendLayout();
            this.NearestWhole_Panel.SuspendLayout();
            this.AvgBPM_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetronomeImage)).BeginInit();
            this.InstructionsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPanel.Controls.Add(this.panel2);
            this.InfoPanel.Controls.Add(this.ResetInstructions4);
            this.InfoPanel.Controls.Add(this.ResetBPMButton);
            this.InfoPanel.Controls.Add(this.ResetInstructions3);
            this.InfoPanel.Controls.Add(this.ResetInstructions2);
            this.InfoPanel.Controls.Add(this.SecondsToReset);
            this.InfoPanel.Controls.Add(this.ResetInstructions1);
            this.InfoPanel.Controls.Add(this.TapTimes_Panel);
            this.InfoPanel.Controls.Add(this.TapTimes_Label);
            this.InfoPanel.Controls.Add(this.NearestWhole_Panel);
            this.InfoPanel.Controls.Add(this.NearestWhole_Label);
            this.InfoPanel.Controls.Add(this.AvgBPM_Panel);
            this.InfoPanel.Controls.Add(this.AvgBPM_Label);
            this.InfoPanel.Controls.Add(this.panel1);
            this.InfoPanel.Location = new System.Drawing.Point(377, 13);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(213, 517);
            this.InfoPanel.TabIndex = 1;
            // 
            // ResetInstructions4
            // 
            this.ResetInstructions4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetInstructions4.AutoSize = true;
            this.ResetInstructions4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetInstructions4.ForeColor = System.Drawing.Color.White;
            this.ResetInstructions4.Location = new System.Drawing.Point(53, 481);
            this.ResetInstructions4.Name = "ResetInstructions4";
            this.ResetInstructions4.Size = new System.Drawing.Size(101, 21);
            this.ResetInstructions4.TabIndex = 10;
            this.ResetInstructions4.Text = "to start again";
            // 
            // ResetBPMButton
            // 
            this.ResetBPMButton.Location = new System.Drawing.Point(49, 440);
            this.ResetBPMButton.Name = "ResetBPMButton";
            this.ResetBPMButton.Size = new System.Drawing.Size(110, 36);
            this.ResetBPMButton.TabIndex = 9;
            this.ResetBPMButton.TabStop = false;
            this.ResetBPMButton.Text = "RESET";
            this.ResetBPMButton.UseVisualStyleBackColor = true;
            this.ResetBPMButton.Click += new System.EventHandler(this.ResetBPMButton_Click);
            // 
            // ResetInstructions3
            // 
            this.ResetInstructions3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetInstructions3.AutoSize = true;
            this.ResetInstructions3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetInstructions3.ForeColor = System.Drawing.Color.White;
            this.ResetInstructions3.Location = new System.Drawing.Point(89, 415);
            this.ResetInstructions3.Name = "ResetInstructions3";
            this.ResetInstructions3.Size = new System.Drawing.Size(25, 21);
            this.ResetInstructions3.TabIndex = 8;
            this.ResetInstructions3.Text = "or";
            // 
            // ResetInstructions2
            // 
            this.ResetInstructions2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetInstructions2.AutoSize = true;
            this.ResetInstructions2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetInstructions2.ForeColor = System.Drawing.Color.White;
            this.ResetInstructions2.Location = new System.Drawing.Point(118, 390);
            this.ResetInstructions2.Name = "ResetInstructions2";
            this.ResetInstructions2.Size = new System.Drawing.Size(66, 21);
            this.ResetInstructions2.TabIndex = 7;
            this.ResetInstructions2.Text = "seconds";
            // 
            // SecondsToReset
            // 
            this.SecondsToReset.InterceptArrowKeys = false;
            this.SecondsToReset.Location = new System.Drawing.Point(81, 390);
            this.SecondsToReset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SecondsToReset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SecondsToReset.Name = "SecondsToReset";
            this.SecondsToReset.Size = new System.Drawing.Size(36, 20);
            this.SecondsToReset.TabIndex = 10;
            this.SecondsToReset.TabStop = false;
            this.SecondsToReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SecondsToReset.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SecondsToReset.Click += new System.EventHandler(this.SecondsToReset_Click);
            // 
            // ResetInstructions1
            // 
            this.ResetInstructions1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetInstructions1.AutoSize = true;
            this.ResetInstructions1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetInstructions1.ForeColor = System.Drawing.Color.White;
            this.ResetInstructions1.Location = new System.Drawing.Point(30, 390);
            this.ResetInstructions1.Name = "ResetInstructions1";
            this.ResetInstructions1.Size = new System.Drawing.Size(50, 21);
            this.ResetInstructions1.TabIndex = 5;
            this.ResetInstructions1.Text = "Pause";
            // 
            // TapTimes_Panel
            // 
            this.TapTimes_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TapTimes_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TapTimes_Panel.Controls.Add(this.TapTimes);
            this.TapTimes_Panel.Location = new System.Drawing.Point(25, 293);
            this.TapTimes_Panel.Name = "TapTimes_Panel";
            this.TapTimes_Panel.Size = new System.Drawing.Size(150, 33);
            this.TapTimes_Panel.TabIndex = 3;
            // 
            // TapTimes
            // 
            this.TapTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TapTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapTimes.ForeColor = System.Drawing.Color.Silver;
            this.TapTimes.Location = new System.Drawing.Point(0, 0);
            this.TapTimes.Name = "TapTimes";
            this.TapTimes.Size = new System.Drawing.Size(148, 31);
            this.TapTimes.TabIndex = 0;
            this.TapTimes.Text = "-";
            this.TapTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TapTimes_Label
            // 
            this.TapTimes_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TapTimes_Label.AutoSize = true;
            this.TapTimes_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapTimes_Label.ForeColor = System.Drawing.Color.White;
            this.TapTimes_Label.Location = new System.Drawing.Point(65, 269);
            this.TapTimes_Label.Name = "TapTimes_Label";
            this.TapTimes_Label.Size = new System.Drawing.Size(70, 21);
            this.TapTimes_Label.TabIndex = 4;
            this.TapTimes_Label.Text = "# of taps";
            // 
            // NearestWhole_Panel
            // 
            this.NearestWhole_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NearestWhole_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NearestWhole_Panel.Controls.Add(this.NearestWhole);
            this.NearestWhole_Panel.Location = new System.Drawing.Point(25, 213);
            this.NearestWhole_Panel.Name = "NearestWhole_Panel";
            this.NearestWhole_Panel.Size = new System.Drawing.Size(150, 33);
            this.NearestWhole_Panel.TabIndex = 2;
            // 
            // NearestWhole
            // 
            this.NearestWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NearestWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NearestWhole.ForeColor = System.Drawing.Color.Silver;
            this.NearestWhole.Location = new System.Drawing.Point(0, 0);
            this.NearestWhole.Name = "NearestWhole";
            this.NearestWhole.Size = new System.Drawing.Size(148, 31);
            this.NearestWhole.TabIndex = 0;
            this.NearestWhole.Text = "-";
            this.NearestWhole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NearestWhole_Label
            // 
            this.NearestWhole_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NearestWhole_Label.AutoSize = true;
            this.NearestWhole_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NearestWhole_Label.ForeColor = System.Drawing.Color.White;
            this.NearestWhole_Label.Location = new System.Drawing.Point(46, 189);
            this.NearestWhole_Label.Name = "NearestWhole_Label";
            this.NearestWhole_Label.Size = new System.Drawing.Size(113, 21);
            this.NearestWhole_Label.TabIndex = 2;
            this.NearestWhole_Label.Text = "Nearest Whole";
            // 
            // AvgBPM_Panel
            // 
            this.AvgBPM_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AvgBPM_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgBPM_Panel.Controls.Add(this.AvgBPM);
            this.AvgBPM_Panel.Location = new System.Drawing.Point(25, 133);
            this.AvgBPM_Panel.Name = "AvgBPM_Panel";
            this.AvgBPM_Panel.Size = new System.Drawing.Size(150, 33);
            this.AvgBPM_Panel.TabIndex = 1;
            // 
            // AvgBPM
            // 
            this.AvgBPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvgBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgBPM.ForeColor = System.Drawing.Color.Silver;
            this.AvgBPM.Location = new System.Drawing.Point(0, 0);
            this.AvgBPM.Name = "AvgBPM";
            this.AvgBPM.Size = new System.Drawing.Size(148, 31);
            this.AvgBPM.TabIndex = 0;
            this.AvgBPM.Text = "-";
            this.AvgBPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvgBPM_Label
            // 
            this.AvgBPM_Label.AutoSize = true;
            this.AvgBPM_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgBPM_Label.ForeColor = System.Drawing.Color.White;
            this.AvgBPM_Label.Location = new System.Drawing.Point(48, 109);
            this.AvgBPM_Label.Name = "AvgBPM_Label";
            this.AvgBPM_Label.Size = new System.Drawing.Size(103, 21);
            this.AvgBPM_Label.TabIndex = 0;
            this.AvgBPM_Label.Text = "Average BPM";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 148);
            this.panel1.TabIndex = 11;
            // 
            // ResetTimer
            // 
            this.ResetTimer.Interval = 2000;
            this.ResetTimer.Tick += new System.EventHandler(this.ResetTimer_Tick);
            // 
            // TapButton
            // 
            this.TapButton.Location = new System.Drawing.Point(136, 388);
            this.TapButton.Name = "TapButton";
            this.TapButton.Size = new System.Drawing.Size(75, 23);
            this.TapButton.TabIndex = 1;
            this.TapButton.Text = "button1";
            this.TapButton.UseVisualStyleBackColor = true;
            this.TapButton.Click += new System.EventHandler(this.TapButton_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.Color.White;
            this.InstructionsLabel.Location = new System.Drawing.Point(-1, 0);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(355, 223);
            this.InstructionsLabel.TabIndex = 2;
            this.InstructionsLabel.Text = "Tap any key to the beat";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreatorLabel.Location = new System.Drawing.Point(0, 501);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(357, 16);
            this.CreatorLabel.TabIndex = 3;
            this.CreatorLabel.Text = "www.github.com/Henduww";
            this.CreatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetronomeImage
            // 
            this.MetronomeImage.Image = ((System.Drawing.Image)(resources.GetObject("MetronomeImage.Image")));
            this.MetronomeImage.Location = new System.Drawing.Point(65, 226);
            this.MetronomeImage.Name = "MetronomeImage";
            this.MetronomeImage.Size = new System.Drawing.Size(221, 204);
            this.MetronomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MetronomeImage.TabIndex = 4;
            this.MetronomeImage.TabStop = false;
            // 
            // InstructionsPanel
            // 
            this.InstructionsPanel.Controls.Add(this.panel3);
            this.InstructionsPanel.Controls.Add(this.MetronomeImage);
            this.InstructionsPanel.Controls.Add(this.CreatorLabel);
            this.InstructionsPanel.Controls.Add(this.InstructionsLabel);
            this.InstructionsPanel.Controls.Add(this.TapButton);
            this.InstructionsPanel.Location = new System.Drawing.Point(13, 13);
            this.InstructionsPanel.Name = "InstructionsPanel";
            this.InstructionsPanel.Size = new System.Drawing.Size(357, 517);
            this.InstructionsPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.HeaderLabel);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 80);
            this.panel2.TabIndex = 12;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Silver;
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(214, 78);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "BPM FINDER";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.panel3.Location = new System.Drawing.Point(0, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 1);
            this.panel3.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(602, 542);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.InstructionsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BPM Finder";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsToReset)).EndInit();
            this.TapTimes_Panel.ResumeLayout(false);
            this.NearestWhole_Panel.ResumeLayout(false);
            this.AvgBPM_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetronomeImage)).EndInit();
            this.InstructionsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel NearestWhole_Panel;
        private System.Windows.Forms.Label NearestWhole;
        private System.Windows.Forms.Label NearestWhole_Label;
        private System.Windows.Forms.Panel AvgBPM_Panel;
        private System.Windows.Forms.Label AvgBPM;
        private System.Windows.Forms.Label AvgBPM_Label;
        private System.Windows.Forms.Panel TapTimes_Panel;
        private System.Windows.Forms.Label TapTimes;
        private System.Windows.Forms.Label TapTimes_Label;
        private System.Windows.Forms.Label ResetInstructions2;
        private System.Windows.Forms.NumericUpDown SecondsToReset;
        private System.Windows.Forms.Label ResetInstructions1;
        private System.Windows.Forms.Label ResetInstructions4;
        private System.Windows.Forms.Button ResetBPMButton;
        private System.Windows.Forms.Label ResetInstructions3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer ResetTimer;
        private System.Windows.Forms.Button TapButton;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label CreatorLabel;
        private System.Windows.Forms.PictureBox MetronomeImage;
        private System.Windows.Forms.Panel InstructionsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel panel3;
    }
}

