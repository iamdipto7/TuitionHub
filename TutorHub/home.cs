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
    public partial class home : MetroFramework.Controls.MetroUserControl
    {
        public home()
        {
            InitializeComponent();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            ViewProfile.Instance.ViewMyProfile();
            ViewProfile.Instance.BringToFront();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            AddPostPage.Instance.BringToFront();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            EditProfilePanel.Instance.flowPanel.Controls.Add(new Editprofile());
            EditProfilePanel.Instance.BringToFront();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ViewPost.Instance.BringToFront();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //my post button
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            //log out
            Form1.Instance.status = false;
            Form1.Instance.LoggedInUser = null;
            Login.Instance.BringToFront();
        }
    }
}
