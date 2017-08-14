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
        private static SignUp instance;
        public static SignUp Instance
        {
            get
            {
                if (instance == null)
                    instance = new SignUp();
                return instance;
            }
        }
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SignUp1.Instance))
            {
                this.Controls.Add(SignUp1.Instance);
                SignUp1.Instance.Dock = DockStyle.Fill;
                this.Controls.Add(SignUp2.Instance);
                SignUp2.Instance.Dock = DockStyle.Fill;
                this.Controls.Add(SignUp3.Instance);
                SignUp3.Instance.Dock = DockStyle.Fill;
                SignUp1.Instance.BringToFront();
            }
            else
                SignUp1.Instance.BringToFront();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
          

        }
    }
}
