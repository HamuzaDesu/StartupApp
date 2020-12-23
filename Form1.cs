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
        Panel[] panels = new Panel[4];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            //this.TopMost = true;

            // SWAP TWO LINES AROUND TO SHOR OR HIDE TASKBAR

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            MaximizeBox = false;

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
                panel.BackColor = Color.Transparent;
                panel.BorderStyle = BorderStyle.None;
                panel.Size = new Size(600, 400);
                panel.Location = new Point(ClientSize.Width /2 - panel.Size.Width / 2,
                    ClientSize.Height / 2 - panel.Size.Height / 2) ;
            }

            clockTimer.Start();
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

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.TimeOfDay.ToString();
            clockLabel.Text = time.Substring(0, 8);
        }
    }
}
