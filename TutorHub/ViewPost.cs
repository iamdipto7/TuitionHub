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
    public partial class ViewPost : UserControl
    {
        private static ViewPost instance;
        public static ViewPost Instance
        {
            get
            {
                if (instance == null)
                    instance = new ViewPost();
                return instance;
            }
        }
        public ViewPost()
        {
            InitializeComponent();
        }

        private void ViewPost_Load(object sender, EventArgs e)
        {
            mypanel.AutoScroll = false;
            mypanel.HorizontalScroll.Enabled = false;
            mypanel.HorizontalScroll.Visible = false;
            mypanel.HorizontalScroll.Maximum = 0;
            mypanel.AutoScroll = true;

            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);


          



            var pos = tdc.Posts.OrderByDescending(a=> a.PId);

            foreach (var z in pos)
            {
                SinglePost sig = new SinglePost(z);


                mypanel.Controls.Add(sig);
                //MetroFramework.MetroMessageBox.Show(this, z.PostTitle);
            }

            //SinglePost sige = new SinglePost(new Post());
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            //sig.Dock = DockStyle.Fill;
            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);
            var p = from x in tdc.Posts
                     where x.PostTitle.Contains(metroTextBox1.Text)
                    select x;
            mypanel.Controls.Clear();

            foreach (Post r in p)
            {
                SinglePost sig = new SinglePost(r);


                mypanel.Controls.Add(sig);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //changed search function in  :v

            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);
            var p = from x in tdc.Posts
                    join y in tdc.Users on x.UserId equals y.UserId
                    where (y.UserName.Contains(metroTextBox2.Text)  &&   
                           x.PostTitle.Contains(metroComboBox1.Text) )
                    select x;
           // metroComboBox1.Text = "";
            //metroComboBox2.Text = "";
            mypanel.Controls.Clear();
            



            //List<Post> result = from 




            foreach( Post r in p)
            {
                SinglePost sig = new SinglePost(r);


                mypanel.Controls.Add(sig);

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
