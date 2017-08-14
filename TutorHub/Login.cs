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
    public partial class Login : MetroFramework.Controls.MetroUserControl
    {
        private static Login instance;
        public static Login Instance
        {
            get
            {
                if (instance == null)
                    instance = new Login();
                return instance;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            
            signUp.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            HomePage.Instance.BringToFront();
        }
    }
}
