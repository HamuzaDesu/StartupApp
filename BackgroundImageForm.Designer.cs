
namespace StartupApp
{
    partial class BackgroundImageForm
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
            this.removeImageButton = new System.Windows.Forms.Button();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeImageButton
            // 
            this.removeImageButton.Location = new System.Drawing.Point(12, 12);
            this.removeImageButton.Name = "removeImageButton";
            this.removeImageButton.Size = new System.Drawing.Size(141, 39);
            this.removeImageButton.TabIndex = 0;
            this.removeImageButton.Text = "Remove Image";
            this.removeImageButton.UseVisualStyleBackColor = true;
            this.removeImageButton.Click += new System.EventHandler(this.removeImageButton_Click);
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(159, 12);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(141, 39);
            this.chooseImageButton.TabIndex = 1;
            this.chooseImageButton.Text = "Choose Image";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 57);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(288, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // BackgroundImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 113);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.removeImageButton);
            this.Name = "BackgroundImageForm";
            this.Text = "Choose Image";
            this.Load += new System.EventHandler(this.BackgroundImageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeImageButton;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.Button closeButton;
    }
}