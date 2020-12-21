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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            // Panel visibility
            a.Visible = true;
            a.BackColor = Color.Transparent;
            //studyPanel.Visible = false;

            // get bgImage from app.config and set as BG
            try
            {
                string imageFileName = ConfigurationManager.AppSettings[0];
                Bitmap bgImage = new Bitmap(imageFileName);
                this.BackgroundImage = bgImage;
            }
            catch (Exception ex) { }


            //// TRANSPARENT BG
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nom");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //System.Diagnostics.Process.Start(@"https://smartrevise.online/student/revise/11");
        }

        private void backgroundImageButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialogue = new OpenFileDialog())
            {
                dialogue.Title = "Choose Background Image";
                dialogue.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

                if(dialogue.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = new Bitmap(dialogue.FileName);

                    // add image to app.config
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings.Add("bgImage", dialogue.FileName);
                    config.Save(ConfigurationSaveMode.Modified);

                    // Set BG image
                    this.BackgroundImage = image;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    //Form1.ActiveForm.BackgroundImage = image;
                    //Form1.ActiveForm.BackgroundImageLayout = ImageLayout.Stretch;

                }
            }
        }

        private void studyButton_Click(object sender, EventArgs e)
        {
            //mainPanel.Visible = false;
            //studyPanel.Visible = true;
        }
    }
}
