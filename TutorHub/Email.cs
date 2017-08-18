using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;

namespace TutorHub
{
    public partial class Email : MetroFramework.Forms.MetroForm
    {
        static Email f;
        public string receive,sender,senderUsername;
        public Email()
        {
            InitializeComponent();
            f = this;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = new MailMessage("tutorhubsystem@gmail.com", receive);
            message.Subject =  txtSubject.Text;
            message.Body = "From: "+sender+"\nTutorHub UserName: "+senderUsername+"\n"+txtBody.Text;

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential("tutorhubsystem@gmail.com", "c#project");
                mailer.EnableSsl = true;
                mailer.Send(message);
            }
            MetroFramework.MetroMessageBox.Show(this,"Email Has been send!");
            txtSubject.Text = null;
            txtBody.Text = null;
        }

        
        
    }
}
