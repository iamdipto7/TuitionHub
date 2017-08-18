using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorHub
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public User LoggedInUser;
        int i = 0;

        private static Form1 instance;
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }
        }

        //private static Form1 instanceValued;
        //public static Form1 InstanceValued
        //{
        //    get
        //    {
        //        return instanceValued;
        //    }
        //}
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            if (!panelMain.Controls.Contains(Login.Instance))
            {
                panelMain.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;

                panelMain.Controls.Add(HomePage.Instance);
                HomePage.Instance.Dock = DockStyle.Fill;

                panelMain.Controls.Add(ViewProfile.Instance);
                ViewProfile.Instance.Dock = DockStyle.Fill;

                panelMain.Controls.Add(ViewPost.Instance);
                ViewPost.Instance.Dock = DockStyle.Fill;

                panelMain.Controls.Add(AddPostPage.Instance);
                AddPostPage.Instance.Dock = DockStyle.Fill;


                panelMain.Controls.Add(EditProfilePanel.Instance);
                EditProfilePanel.Instance.Dock = DockStyle.Fill;


                Login.Instance.BringToFront();
            }
            else
                Login.Instance.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(HomePage.Instance.metroTile1.BackColor== Color.LightSkyBlue)
            {
                HomePage.Instance.metroTile1.BackColor = Color.YellowGreen;
                HomePage.Instance.metroTile1.Refresh();
            }
            else
            {
                HomePage.Instance.metroTile1.BackColor = Color.LightSkyBlue;
                HomePage.Instance.metroTile1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //home button navbar

            
            
            if (i == 0)
            {
                home1.BringToFront();
                i++;
            }
            else
            {
                home1.SendToBack();
                
                i--;
            }
                
                
            
            //homePage1.Visible = true;
        }
    }
}
