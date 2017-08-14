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
        public Email()
        {
            InitializeComponent();
            f = this;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = new MailMessage(txtEmail.Text, txtRecepient.Text);
            message.Subject = txtSubject.Text;
            message.Body = txtBody.Text;

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential(txtEmail.Text, txtPass.Text);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }
            txtRecepient.Text = null;
            txtSubject.Text = null;
            txtBody.Text = null;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            StartReceiving();

        }

        private void StartReceiving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, txtEmail.Text, txtPass.Text, AuthMethod.Login, true))
                {
                    if(client.Supports("IDLE")==false)
                    {
                        MessageBox.Show("Server does not support IMAP IDLE");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
                    while (true) ;
                }
            });
        }
        static void OnNewMessage(Object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New Message received!");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            f.Invoke((MethodInvoker)delegate
            {
                f.txtReceive.AppendText("From: " + m.From + "\n" + "Subject: " + m.Subject + "\n" + "Body: " + m.Body + "\n");
            });
        }
    }
}
