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
    public partial class SignUp2 : UserControl
    {
        private static SignUp2 instance;
        public static SignUp2 Instance
        {
            get
            {
                if (instance == null)
                    instance = new SignUp2();
                return instance;
            }
        }
        public SignUp2()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SignUp3.Instance.BringToFront();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SignUp1.Instance.BringToFront();
        }
    }
}
