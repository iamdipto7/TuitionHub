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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private static Form1 instance;
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(Login.Instance))
            {
                this.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;

                this.Controls.Add(HomePage.Instance);
                HomePage.Instance.Dock = DockStyle.Fill;

                this.Controls.Add(ViewProfile.Instance);
                ViewProfile.Instance.Dock = DockStyle.Fill;

                this.Controls.Add(SignlePostTemplete.Instance);
                SignlePostTemplete.Instance.Dock = DockStyle.Fill;

                this.Controls.Add(AddPostPage.Instance);
                AddPostPage.Instance.Dock = DockStyle.Fill;

                Login.Instance.BringToFront();
            }
            else
                Login.Instance.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
