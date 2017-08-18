﻿using System;
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
    public partial class SinglePost : MetroFramework.Controls.MetroUserControl
    {

        Post p;
        
        public SinglePost()
        {
            InitializeComponent();
            //BackColor = Color.Red;
            
 
        }

        public SinglePost( Post m)
        {
            InitializeComponent();
            p = m;

            postTitleLnk.Text = p.PostTitle;
            metroLabel6.Text = p.DeptName;
            metroLabel9.Text = p.Date.ToString();
            metroLabel7.Text = p.CourseName;
            metroLabel8.Text = p.Topic;
            lblUserID.Text = Convert.ToString(p.UserId);
            lblUserID.Visible = false;


            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);


            var by =   tdc.Users.SingleOrDefault(x => x.UserId == p.UserId);

            if(by.UserName.Equals(""))
            {
                metroLink1.Text = by.FirstName;


            }
            else
            {
                metroLink1.Text = by.UserName;

            }


            



        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
          
            //int x = Convert.ToInt32(this.lblUserID.Text);

            //TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);
            //var poster = from y in tdc.Users
            //             where y.UserId == x
            //             select y;
            


           ViewProfile.Instance.ViewOtherProfile(int.Parse(this.lblUserID.Text));



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, lblUserID.Text);
        }
    }
}
