namespace StartupApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studyButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.codePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chillPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.studyPanel = new System.Windows.Forms.Panel();
            this.gameButton = new System.Windows.Forms.Button();
            this.codeButton = new System.Windows.Forms.Button();
            this.chillButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.backgroundImageButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePanel.SuspendLayout();
            this.codePanel.SuspendLayout();
            this.chillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studyButton
            // 
            this.studyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studyButton.Location = new System.Drawing.Point(359, 67);
            this.studyButton.Name = "studyButton";
            this.studyButton.Size = new System.Drawing.Size(82, 37);
            this.studyButton.TabIndex = 3;
            this.studyButton.Text = "Study";
            this.studyButton.UseVisualStyleBackColor = true;
            this.studyButton.Click += new System.EventHandler(this.studyButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamePanel.Controls.Add(this.label4);
            this.gamePanel.Location = new System.Drawing.Point(775, 268);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(200, 100);
            this.gamePanel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // codePanel
            // 
            this.codePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codePanel.Controls.Add(this.label3);
            this.codePanel.Location = new System.Drawing.Point(766, 143);
            this.codePanel.Name = "codePanel";
            this.codePanel.Size = new System.Drawing.Size(200, 100);
            this.codePanel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // chillPanel
            // 
            this.chillPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chillPanel.Controls.Add(this.label2);
            this.chillPanel.Location = new System.Drawing.Point(800, 386);
            this.chillPanel.Name = "chillPanel";
            this.chillPanel.Size = new System.Drawing.Size(200, 100);
            this.chillPanel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // studyPanel
            // 
            this.studyPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studyPanel.Location = new System.Drawing.Point(70, 152);
            this.studyPanel.Name = "studyPanel";
            this.studyPanel.Size = new System.Drawing.Size(600, 400);
            this.studyPanel.TabIndex = 7;
            // 
            // gameButton
            // 
            this.gameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameButton.Location = new System.Drawing.Point(623, 67);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(82, 37);
            this.gameButton.TabIndex = 6;
            this.gameButton.Text = "Game";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // codeButton
            // 
            this.codeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeButton.Location = new System.Drawing.Point(535, 67);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(82, 37);
            this.codeButton.TabIndex = 5;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // chillButton
            // 
            this.chillButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chillButton.Location = new System.Drawing.Point(447, 67);
            this.chillButton.Name = "chillButton";
            this.chillButton.Size = new System.Drawing.Size(82, 37);
            this.chillButton.TabIndex = 4;
            this.chillButton.Text = "Chill";
            this.chillButton.UseVisualStyleBackColor = true;
            this.chillButton.Click += new System.EventHandler(this.chillButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(972, 549);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(66, 67);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // backgroundImageButton
            // 
            this.backgroundImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundImageButton.BackgroundImage")));
            this.backgroundImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundImageButton.Location = new System.Drawing.Point(828, 549);
            this.backgroundImageButton.Name = "backgroundImageButton";
            this.backgroundImageButton.Size = new System.Drawing.Size(66, 67);
            this.backgroundImageButton.TabIndex = 2;
            this.backgroundImageButton.UseVisualStyleBackColor = true;
            this.backgroundImageButton.Click += new System.EventHandler(this.backgroundImageButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(900, 549);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(66, 67);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(96, 24);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(62, 20);
            this.clockLabel.TabIndex = 11;
            this.clockLabel.Text = "CLOCK";
            // 
            // clockTimer
            // 
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 628);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.codePanel);
            this.Controls.Add(this.chillButton);
            this.Controls.Add(this.chillPanel);
            this.Controls.Add(this.studyButton);
            this.Controls.Add(this.studyPanel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.backgroundImageButton);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.closeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.chillPanel.ResumeLayout(false);
            this.chillPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button studyButton;
        private System.Windows.Forms.Button backgroundImageButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button chillButton;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Panel studyPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel codePanel;
        private System.Windows.Forms.Panel chillPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
    }
}

