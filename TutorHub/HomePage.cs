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
            SignlePostTemplete.Instance.BringToFront();
        }

        private void CreatePostTile_Click(object sender, EventArgs e)
        {
            AddPostPage.Instance.BringToFront();
        }
    }
}
