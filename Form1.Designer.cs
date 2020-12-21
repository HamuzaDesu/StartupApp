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
            this.closeButton = new System.Windows.Forms.Button();
            this.backgroundImageButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.chillButton = new System.Windows.Forms.Button();
            this.codeButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.a.SuspendLayout();
            this.SuspendLayout();
            // 
            // studyButton
            // 
            this.studyButton.Location = new System.Drawing.Point(287, 230);
            this.studyButton.Name = "studyButton";
            this.studyButton.Size = new System.Drawing.Size(82, 37);
            this.studyButton.TabIndex = 3;
            this.studyButton.Text = "Study";
            this.studyButton.UseVisualStyleBackColor = true;
            this.studyButton.Click += new System.EventHandler(this.studyButton_Click);
            // 
            // a
            // 
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
            // chillButton
            // 
            this.chillButton.Location = new System.Drawing.Point(375, 230);
            this.chillButton.Name = "chillButton";
            this.chillButton.Size = new System.Drawing.Size(82, 37);
            this.chillButton.TabIndex = 4;
            this.chillButton.Text = "Chill";
            this.chillButton.UseVisualStyleBackColor = true;
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(463, 230);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(82, 37);
            this.codeButton.TabIndex = 5;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            // 
            // gameButton
            // 
            this.gameButton.Location = new System.Drawing.Point(551, 230);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(82, 37);
            this.gameButton.TabIndex = 6;
            this.gameButton.Text = "Game";
            this.gameButton.UseVisualStyleBackColor = true;
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
    }
}

