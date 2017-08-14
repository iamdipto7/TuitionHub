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
        //private static SignUp3 instance;
        //public static SignUp3 Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new SignUp3();
        //        return instance;
        //    }
        //}
        SignUp signUp;
        public SignUp3()
        {
            InitializeComponent();
        }

        public SignUp3(SignUp signUp)
        {
            InitializeComponent();
            this.signUp = signUp;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            signUp.SignUp2BringToFront();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int varify = 0001;


            if (varify != int.Parse(metroTextBox1.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Code did not matched, enter the code sent in you mail");
            }

            else
            {
                HomePage.Instance.BringToFront();
                //SignUp1.Instance.Hide();
                //SignUp2.Instance.Hide();
                signUp.Hide();
                
                //SignUp.Instance.Hide();
            }

        }
    }
}
