using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace StartupApp
{
    public partial class BackgroundImageForm : Form
    {

        Form1 form1;

        public Form1 Form1
        {
            get { return form1; }
            set { form1 = value; }
        }

        public BackgroundImageForm()
        {
            InitializeComponent();
        }
            
        private void BackgroundImageForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            this.CenterToScreen();
        }

        private void removeImageButton_Click(object sender, EventArgs e)
        {
            Form1.BackgroundImage = null;
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogue = new OpenFileDialog())
            {
                dialogue.Title = "Choose Background Image";
                dialogue.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

                if (dialogue.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = new Bitmap(dialogue.FileName);

                    // add image to app.config
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings.Remove("bgImage");
                    config.AppSettings.Settings.Add("bgImage", dialogue.FileName);
                    config.Save(ConfigurationSaveMode.Modified);

                    // Set BG image
                    Form1.BackgroundImage = image;
                    Form1.BackgroundImageLayout = ImageLayout.Stretch;
                    //Form1.ActiveForm.BackgroundImage = image;
                    //Form1.ActiveForm.BackgroundImageLayout = ImageLayout.Stretch;

                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
