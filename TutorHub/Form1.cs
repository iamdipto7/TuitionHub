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
               
                



                Login.Instance.BringToFront();
            }
            else
                Login.Instance.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
