using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorHub
{
    public partial class HomePage : UserControl
    {
        private static HomePage instance;
        public static HomePage Instance
        {
            get
            {
                if (instance == null)
                    instance = new HomePage();
                return instance;
            }
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void profileTile_Click(object sender, EventArgs e)
        {
            ViewProfile.Instance.lblName.Text = Form1.Instance.LoggedInUser.UserName;
            ViewProfile.Instance.BringToFront();
        }

        private void viewPostTile_Click(object sender, EventArgs e)
        {
            ViewPost.Instance.BringToFront();
        }

        private void CreatePostTile_Click(object sender, EventArgs e)
        {
            AddPostPage.Instance.BringToFront();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            ViewProfile.Instance.ViewMyProfile();
            ViewProfile.Instance.BringToFront();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ViewPost.Instance.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(metroTile2.BackColor== Color.LightSkyBlue)
            {
                metroTile2.BackColor = Color.Red;
               
            }
            else
            {

                metroTile2.BackColor = Color.LightSkyBlue; 
            }

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            EditProfilePanel.Instance.flowPanel.Controls.Add(new Editprofile());
            EditProfilePanel.Instance.BringToFront();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //create post
            AddPostPage.Instance.BringToFront();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form1.Instance.LoggedInUser = null;
            Form1.Instance.status = false;
            Login.Instance.BringToFront();
        }
    }
}
