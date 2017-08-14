using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorHub
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        public User NewUser;
        SignUp1 signUp1;
        SignUp2 signUp2;
        SignUp3 signUp3;


        //private static SignUp instance;
        //public static SignUp Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new SignUp();
        //        return instance;
        //    }
        //    set
        //    {
        //        instance = value;
        //    }
        //}
        public SignUp()
        {
            InitializeComponent();
            NewUser = new User();
            signUp1 = new SignUp1(this);
            signUp2 = new SignUp2(this);
            signUp3 = new SignUp3(this);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(signUp1))
            {
                this.Controls.Add(signUp1);
                signUp1.Dock = DockStyle.Fill;
                //this.Controls.Add(SignUp2.Instance);
                //SignUp2.Instance.Dock = DockStyle.Fill;
                //this.Controls.Add(SignUp3.Instance);
                //SignUp3.Instance.Dock = DockStyle.Fill;
                //signUp1.BringToFront();
            }
            else
                signUp1.BringToFront();

            
        }



        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
          

        }
    }
}
