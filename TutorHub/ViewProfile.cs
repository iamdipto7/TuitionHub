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
    public partial class ViewProfile : MetroFramework.Controls.MetroUserControl
    {
        private static ViewProfile instance;
        public static ViewProfile Instance
        {
            get
            {
                if (instance == null)
                    instance = new ViewProfile();
                return instance;
            }
        }
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            

        }

        public void ViewMyProfile()
        {
            if(Form1.Instance.LoggedInUser.FirstName =="" || Form1.Instance.LoggedInUser.FirstName == "")
            {
                lblName.Text = Form1.Instance.LoggedInUser.UserName;
            }
            else
            {
                lblName.Text = Form1.Instance.LoggedInUser.FirstName + " " + Form1.Instance.LoggedInUser.LastName + "( " + Form1.Instance.LoggedInUser.UserName + " )";
            }

            if(Form1.Instance.LoggedInUser.DOB.ToString().Equals(""))
            {
                lblDOB.Text = "Not provded";

            }
            else
            {
                lblDOB.Text = Form1.Instance.LoggedInUser.DOB.ToString();
            }


            //if (Form1.Instance.LoggedInUser.Gender.Equals(""))
            //{
                lblGender.Text = "Not provded";

            //}
            //else
            //{
                //lblGender.Text = Form1.Instance.LoggedInUser.Gender;
            //}

            /*
             if(Form1.Instance.LoggedInUser.SkypeId.Equals(""))
            {
                metroLabel13.Text = "Not provded";

            }
            else
            {
                metroLabel13.Text = Form1.Instance.LoggedInUser.SkypeId;
            }*/


            if (Form1.Instance.LoggedInUser.Description.Equals(""))
            {
                metroTile2.Text = "Not provded";

            }
            else
            {
                metroTile2.Text = Form1.Instance.LoggedInUser.Description;
            }


           // if (Form1.Instance.LoggedInUser.)


















        }








    }
}
