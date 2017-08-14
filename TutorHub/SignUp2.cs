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
        //private static SignUp2 instance;
        //public static SignUp2 Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new SignUp2();
        //        return instance;
        //    }
        //}
        SignUp signUp;
        public SignUp2()
        {
            InitializeComponent();
        }

        public SignUp2(SignUp signUp)
        {
            InitializeComponent();
            this.signUp = signUp;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //SignUp3.Instance.BringToFront();

            string confirmPass = txtConfirmPass.Text;
            signUp.NewUser.Password = txtPass.Text;
            if( confirmPass.Equals(signUp.NewUser.Password) && signUp.NewUser.Password.Length >= 8 )
            {
                signUp.SignUp3BringToFront();

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "password must be eight charater long and both has to be same");
            }



           




        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //btn previous on sign up 2 page to go sign up 1
            
            signUp.SignUp1BringToFront();
        }
    }
}
