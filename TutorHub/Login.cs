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
        // public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\OneDrive\Project Final\TutorHub\TutorHub\TutorHubDatabase.mdf;Integrated Security = True; Connect Timeout = 30";

        public string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\FinalProject\TutionHub\TutorHub\TutorHubDatabase.mdf;Integrated Security = True; Connect Timeout = 30";

        User loggedInUser;
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
            //sign in button 

            TutorHubDataContext tdc = new TutorHubDataContext(connection);




            int recordCount = 0;
            recordCount = tdc.Users.Where(x => x.UserName == txtUserName.Text && x.Password == txtLoginPass.Text).Count();

            if (recordCount > 0)
            {
                loggedInUser = tdc.Users.SingleOrDefault(x => x.UserName == txtUserName.Text && x.Password == txtLoginPass.Text);
                Form1.Instance.LoggedInUser = loggedInUser;
                HomePage.Instance.BringToFront();
            }
            
            else
            {
                
                int xt= 0;

               xt = tdc.Users.Where(x => x.Email == txtUserName.Text && x.Password == txtLoginPass.Text).Count();

                if (xt > 0)
                {
                    loggedInUser = tdc.Users.SingleOrDefault(x => x.Email == txtUserName.Text && x.Password == txtLoginPass.Text);
                    Form1.Instance.LoggedInUser = loggedInUser;
                    HomePage.Instance.BringToFront();
                }

                else
                {

                    MetroFramework.MetroMessageBox.Show(this, "UserName/Password Incorrect");

                }
            }


            






            //if (tdc.Users.Any(t => t.UserName.Equals(txtUserName.Text)))
            //{
            //    if (tdc.Users(t => t.Password.Equals(txtUserName.Text)))
            //    {

            //        MetroFramework.MetroMessageBox.Show(this, "UserName is Taken! Use Another.");
            //    }
            //    MetroFramework.MetroMessageBox.Show(this, "UserName is Taken! Use Another.");
            //}
            //else if (tdc.Users.Any(t => t.Email.Equals(txtEmail.Text)))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Email is used already! Use Another.");
            //}

            

        }

        public static void SignUpCheck(User user)
        {
            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);
            User u = user;
            if (tdc.Users.Any(t => t.GoogleId.Equals(u.GoogleId)))
            {
                MetroFramework.MetroMessageBox.Show(Login.instance, "This Google  ID is Already registered! Use Another.");
            }
            else
            {
                tdc.Users.InsertOnSubmit(user);
                tdc.SubmitChanges();
                MetroFramework.MetroMessageBox.Show(Login.instance, "Sign Up Cpmpleted!");
            }
        }

        public void LoginCheck(User user)
        {
            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);

            User u = user;
            int recordCount = 0;
            recordCount = tdc.Users.Where(x => x.GoogleId == u.GoogleId).Count();

            if (recordCount > 0)
            {
                loggedInUser = tdc.Users.SingleOrDefault(x => x.GoogleId == u.GoogleId);
                Form1.Instance.LoggedInUser = loggedInUser;
                HomePage.Instance.BringToFront();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Use Registered Google Account!");
            }
        }

        private void GoogleLoginTile_Click(object sender, EventArgs e)
        {
            GoogleLoginClass p = new GoogleLoginClass();
            p.doOAuth();

           
            


            
        }
    }
}
