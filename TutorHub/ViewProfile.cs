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
            this.metroTabControl1.SelectedIndex = 0;

            if (Form1.Instance.LoggedInUser.UserName.Equals(""))
            {
                metroLabel6.Text = metroLabel5.Text = Form1.Instance.LoggedInUser.FirstName +" " +Form1.Instance.LoggedInUser.LastName;

            }
            else
            {
                metroLabel6.Text = metroLabel5.Text = Form1.Instance.LoggedInUser.UserName;
            }

            if (Form1.Instance.LoggedInUser.FirstName =="" || Form1.Instance.LoggedInUser.FirstName == "")
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


            if (Form1.Instance.LoggedInUser.Gender.Equals(""))
            {
                lblGender.Text = "Not provded";

            }
            else
            {
                lblGender.Text = Form1.Instance.LoggedInUser.Gender;
            }

            
             if(Form1.Instance.LoggedInUser.SkypeId.Equals(""))
            {
                metroLabel13.Text = "Not provded";

            }
            else
            {
                metroLabel13.Text = Form1.Instance.LoggedInUser.SkypeId;
            }


            if (Form1.Instance.LoggedInUser.Description.Equals(""))
            {
                metroTile2.Text = "Not provded";

            }
            else
            {
                metroTile2.Text = Form1.Instance.LoggedInUser.Description;
            }


            if (Form1.Instance.LoggedInUser.phone.Equals(""))
            {
                metroLabel14.Text = "Not provided";
            }
            else
            {
                metroLabel14.Text = Form1.Instance.LoggedInUser.phone;
            }


            if (Form1.Instance.LoggedInUser.Address.Equals(""))
            {
                metroLabel15.Text = "Not provided";
            }
            else
            {
                metroLabel15.Text = Form1.Instance.LoggedInUser.Address;
            }


            if (Form1.Instance.LoggedInUser.Versity.Equals(""))
            {
                metroLabel19.Text = "Not provided";
            }
            else
            {
                metroLabel19.Text = Form1.Instance.LoggedInUser.Versity ;
                
                if(Form1.Instance.LoggedInUser.Department.Equals(""))
                {
                    metroLabel19.Text += "\n Dept: not provided";
                }
                else
                {
                    metroLabel19.Text += "\n Dept: " + Form1.Instance.LoggedInUser.Department;
                }


                if(Form1.Instance.LoggedInUser.Semister.Equals(""))
                {
                    metroLabel19.Text += "\n Semister: Not provided";
                }
                else
                {
                    metroLabel19.Text += "\n Semister: "+ Form1.Instance.LoggedInUser.Semister;

                }

            }


            if (Form1.Instance.LoggedInUser.Email.Equals(""))
            {
                metroLabel2.Text = "Not provided";
            }
            else
            {
                metroLabel12.Text = Form1.Instance.LoggedInUser.Email;

            }




            if (Form1.Instance.LoggedInUser.SSC.Equals(""))
            {
                metroLabel21.Text = "Not provided";
            }
            else
            {
                metroLabel21.Text = Form1.Instance.LoggedInUser.SSC;

                if (!Form1.Instance.LoggedInUser.SSCYear.Equals(""))
                {

                    metroLabel21.Text += " ( " + Form1.Instance.LoggedInUser.SSCYear+ " )";
                }

            }



            if (Form1.Instance.LoggedInUser.HSC.Equals(""))
            {
                metroLabel20.Text = "Not provided";
            }
            else
            {
                metroLabel20.Text = Form1.Instance.LoggedInUser.HSC;

                if (!Form1.Instance.LoggedInUser.HSCYear.Equals(""))
                {

                    metroLabel20.Text += " ( " + Form1.Instance.LoggedInUser.HSCYear + " )";
                }

            }

            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);

            var skls = from x in tdc.Skills
                       where x.UserId == Form1.Instance.LoggedInUser.UserId
                       select x;

            if(skls.Count()==0)
            {
                metroLabel22.Text = "No skills provided";
            }
            else
            {
                metroLabel22.Text = "";
                foreach(var s in skls)
                {
                    
                    metroLabel22.Text += s.SkillName + " ;";
                }
                metroLabel22.Text.Remove(metroLabel22.Text.Length-2, 2);
            }




        }








    }
}
