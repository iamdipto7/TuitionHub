using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace TutorHub
{
    public partial class SignUp3 : UserControl
    {
        int varifyCode;
        Timer timer = new Timer();
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
            
            //complete signup button to go home page
            

            if("TH-"+Convert.ToString(varifyCode)==txtVerification.Text)
            {
                TutorHubDataContext tdc = new TutorHubDataContext(signUp.connection);

                tdc.Users.InsertOnSubmit(signUp.NewUser);
                tdc.SubmitChanges();
                HomePage.Instance.BringToFront();
                signUp.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Verification Failed");
            }

        }

        private void btnSendVerification_Click(object sender, EventArgs e)
        {
            lblVerification.Text = "Varification code has been sent to your email. varify yourself.";
            btnSendVerification.Text = "Resend Verification Code";
            txtVerification.Enabled = true;
            txtVerification.Text = "TH-";

            timer.Interval = 60000;
            timer.Tick += timer_Tick;
            timer.Start();
            btnSendVerification.Enabled = false;

            Random rnd = new Random();

            varifyCode = rnd.Next(100000, 999999);

            var message = new MailMessage("tutorhubsystem@gmail.com", signUp.NewUser.Email);
            message.Subject = "Verification Code [No Reply]";
            message.Body = "TH-"+Convert.ToString(varifyCode);

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential("tutorhubsystem@gmail.com", "c#project");
                mailer.EnableSsl = true;
                mailer.Send(message);
            }

        }

        void timer_Tick(object sender, System.EventArgs e)
        {
            btnSendVerification.Enabled = true;
            timer.Stop();
        }
    }
}
