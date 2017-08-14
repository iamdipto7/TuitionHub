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
    public partial class SignUp3 : UserControl
    {
        private static SignUp3 instance;
        public static SignUp3 Instance
        {
            get
            {
                if (instance == null)
                    instance = new SignUp3();
                return instance;
            }
        }
        public SignUp3()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SignUp2.Instance.BringToFront();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            HomePage.Instance.BringToFront();
            SignUp.Instance.Close();

        }
    }
}
