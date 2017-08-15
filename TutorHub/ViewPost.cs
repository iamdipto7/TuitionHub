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

            var pos = from x in tdc.Posts
                      orderby x.PId descending
                      select x;

            foreach (Post z in pos)
            {
                SinglePost sig = new SinglePost(z);
                mypanel.Controls.Add(sig);
            }
            
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SinglePost sig = new SinglePost();
            mypanel.Controls.Add(sig);
            //sig.Dock = DockStyle.Fill;
        }
    }
}
