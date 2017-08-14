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
    public partial class SignUp1 : MetroFramework.Controls.MetroUserControl
    {
        private static SignUp1 instance;
        public static SignUp1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new SignUp1();
                return instance;
            }
        }
        public SignUp1()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp2.Instance.BringToFront();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            GoogleClass p = new GoogleClass();
            p.doOAuth();
        }
    }
}
