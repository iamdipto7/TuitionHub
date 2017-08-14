using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TutorHub
{
    public partial class SignUp1 : MetroFramework.Controls.MetroUserControl
    {
        //private static SignUp1 instance;
        //public static SignUp1 Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new SignUp1();
        //        return instance;
        //    }
        //}

        SignUp signUp;
        string emailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+ "@"+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
        public SignUp1()
        {
            InitializeComponent();
        }

        public SignUp1(SignUp signUp)
        {
            InitializeComponent();
            this.signUp = signUp;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnNextSignUp1_Click(object sender, EventArgs e)
        {
            TutorHubDataContext tdc = new TutorHubDataContext(signUp.connection);

            


            signUp.NewUser.UserName = txtUserName.Text;
            signUp.NewUser.Email = txtEmail.Text;

            if (signUp.NewUser.UserName.Equals("") || signUp.NewUser.Email.Equals("") || signUp.NewUser.Email.StartsWith(" ") || signUp.NewUser.UserName.StartsWith(" ") || signUp.NewUser.Email.Contains(" "))
            {
                MetroFramework.MetroMessageBox.Show(this, "User Name or Email can not be empty");

            }

            else if(!Regex.IsMatch(txtEmail.Text,emailPattern))
            {
                MetroFramework.MetroMessageBox.Show(this, "Email is not valid!");
            }

            else
            {
                if (tdc.Users.Any(t => t.UserName.Equals(txtUserName.Text)))
                {
                    MetroFramework.MetroMessageBox.Show(this, "UserName is Taken! Use Another.");
                }
                else if (tdc.Users.Any(t => t.Email.Equals(txtEmail.Text)))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Email is used already! Use Another.");
                }
                else
                    signUp.SignUp2BringToFront();

            }






            
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            GoogleClass p = new GoogleClass();
            p.doOAuth(signUp);

            
        }
    }
}
