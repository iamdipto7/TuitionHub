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
        User newUser;
        //public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\OneDrive\Project Final\TutorHub\TutorHub\TutorHubDatabase.mdf;Integrated Security = True; Connect Timeout = 30";

        public string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\FinalProject\TutionHub\TutorHub\TutorHubDatabase.mdf;Integrated Security = True; Connect Timeout = 30";
        public User NewUser
        {
            get
            {
                return newUser;
            }
        }
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
            newUser = new User();
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
                this.Controls.Add(signUp2);
                signUp2.Dock = DockStyle.Fill;
                this.Controls.Add(signUp3);
                signUp3.Dock = DockStyle.Fill;
                signUp1.BringToFront();
            }
            else
                signUp1.BringToFront();

            
        }



        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
          

        }


        public void SignUp1BringToFront()
        {
            signUp1.BringToFront();
        }



        public void SignUp2BringToFront()
        {
            signUp2.BringToFront();
        }
        public void SignUp3BringToFront()
        {
            signUp3.BringToFront();
        }







    }
}
