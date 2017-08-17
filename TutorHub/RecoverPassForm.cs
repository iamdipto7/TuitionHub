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
    public partial class RecoverPassForm : MetroFramework.Forms.MetroForm
    {
        public RecoverPassForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (metroTextBox1.Text.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "can not be empty");
            }

            else
            {


                TutorHubDataContext tdc = new TutorHubDataContext();


                var x = tdc.Users.Where(p => p.Email.Equals(metroTextBox1.Text) || p.UserName.Equals(metroTextBox1.Text));


                if (x.Count() == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "user name or email is not correct!!\nEnter a registered username or email");
                }

                else
                {
                    User p = (User)x;
                    string email = p.Email;
                    MetroFramework.MetroMessageBox.Show(this, "Password has been sent to the emmail");
                    this.Hide();




                }

            }


            



           





        }
    }
}
