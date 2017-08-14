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

            signUp.NewUser.UserName = txtUserName.Text;
            signUp.NewUser.Email = txtEmail.Text;


            //Console.WriteLine(SignUp.Instance.NewUser.UserName+ SignUp.Instance.NewUser.Email);

            //SignUp2.Instance.txtPass.Text = SignUp.Instance.NewUser.UserName;
            //SignUp2.Instance.BringToFront();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            GoogleClass p = new GoogleClass();
            p.doOAuth();
        }
    }
}
