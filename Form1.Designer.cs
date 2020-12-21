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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studyButton = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.codePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chillPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.studyPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gameButton = new System.Windows.Forms.Button();
            this.codeButton = new System.Windows.Forms.Button();
            this.chillButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.backgroundImageButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.a.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.codePanel.SuspendLayout();
            this.chillPanel.SuspendLayout();
            this.studyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studyButton
            // 
            this.studyButton.Location = new System.Drawing.Point(339, 80);
            this.studyButton.Name = "studyButton";
            this.studyButton.Size = new System.Drawing.Size(82, 37);
            this.studyButton.TabIndex = 3;
            this.studyButton.Text = "Study";
            this.studyButton.UseVisualStyleBackColor = true;
            this.studyButton.Click += new System.EventHandler(this.studyButton_Click);
            // 
            // a
            // 
            this.a.Controls.Add(this.gamePanel);
            this.a.Controls.Add(this.codePanel);
            this.a.Controls.Add(this.chillPanel);
            this.a.Controls.Add(this.studyPanel);
            this.a.Controls.Add(this.gameButton);
            this.a.Controls.Add(this.codeButton);
            this.a.Controls.Add(this.chillButton);
            this.a.Controls.Add(this.closeButton);
            this.a.Controls.Add(this.backgroundImageButton);
            this.a.Controls.Add(this.settingsButton);
            this.a.Controls.Add(this.studyButton);
            this.a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a.Location = new System.Drawing.Point(0, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(1043, 551);
            this.a.TabIndex = 4;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.label4);
            this.gamePanel.Location = new System.Drawing.Point(749, 150);
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
            this.codePanel.Controls.Add(this.label3);
            this.codePanel.Location = new System.Drawing.Point(532, 150);
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
            this.chillPanel.Controls.Add(this.label2);
            this.chillPanel.Location = new System.Drawing.Point(309, 150);
            this.chillPanel.Name = "chillPanel";
            this.chillPanel.Size = new System.Drawing.Size(200, 100);
            this.chillPanel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // studyPanel
            // 
            this.studyPanel.Controls.Add(this.label1);
            this.studyPanel.Location = new System.Drawing.Point(78, 150);
            this.studyPanel.Name = "studyPanel";
            this.studyPanel.Size = new System.Drawing.Size(200, 100);
            this.studyPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // gameButton
            // 
            this.gameButton.Location = new System.Drawing.Point(603, 80);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(82, 37);
            this.gameButton.TabIndex = 6;
            this.gameButton.Text = "Game";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(515, 80);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(82, 37);
            this.codeButton.TabIndex = 5;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // chillButton
            // 
            this.chillButton.Location = new System.Drawing.Point(427, 80);
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
            this.closeButton.Location = new System.Drawing.Point(965, 472);
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
            this.backgroundImageButton.Location = new System.Drawing.Point(821, 472);
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
            this.settingsButton.Location = new System.Drawing.Point(893, 472);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(66, 67);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 551);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.a.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.chillPanel.ResumeLayout(false);
            this.chillPanel.PerformLayout();
            this.studyPanel.ResumeLayout(false);
            this.studyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button studyButton;
        private System.Windows.Forms.Panel a;
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
        private System.Windows.Forms.Label label1;
    }
}

