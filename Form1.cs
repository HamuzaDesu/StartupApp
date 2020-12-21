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
        Control[] panels = new Control[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            //this.TopMost = true;
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
                //MessageBox.Show(imageFileName);
                Bitmap bgImage = new Bitmap(imageFileName);
                this.BackgroundImage = bgImage;
                this.BackgroundImageLayout = ImageLayout.Stretch;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            panels[0] = studyPanel;
            panels[1] = chillPanel;
            panels[2] = codePanel;
            panels[3] = gamePanel;

            foreach (Panel panel in panels)
            {
                panel.Visible = false;
                panel.BackColor = Color.White;
            }

            //// TRANSPARENT BG
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Box Here");
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //System.Diagnostics.Process.Start(@"https://smartrevise.online/student/revise/11");
        }

        private void backgroundImageButton_Click(object sender, EventArgs e)
        {
            BackgroundImageForm form2 = new BackgroundImageForm();
            form2.Form1 = this;
            form2.ShowDialog();
        }

        private void studyButton_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }
            studyPanel.Visible = true;
        }

        private void chillButton_Click(object sender, EventArgs e)
        {
            foreach(Panel panel in panels)
            {
                panel.Visible = false;
            }
            chillPanel.Visible = true;
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }
            codePanel.Visible = true;
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }
            gamePanel.Visible = true;
        }
    }
}
