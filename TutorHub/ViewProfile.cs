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

            if (Form1.Instance.LoggedInUser.UserName == null)
            {
                metroLabel6.Text = metroLabel5.Text = Form1.Instance.LoggedInUser.FirstName +" " +Form1.Instance.LoggedInUser.LastName;

            }
            else
            {
                metroLabel6.Text = metroLabel5.Text = Form1.Instance.LoggedInUser.UserName;
            }

            if ((Form1.Instance.LoggedInUser.FirstName == null) || (Form1.Instance.LoggedInUser.FirstName== null))
            {
                lblName.Text = Form1.Instance.LoggedInUser.UserName;
            }
            else
            {
                lblName.Text = Form1.Instance.LoggedInUser.FirstName + " " + Form1.Instance.LoggedInUser.LastName + "( " + Form1.Instance.LoggedInUser.UserName + " )";
            }

            if(Form1.Instance.LoggedInUser.DOB.ToString()== null)
            {
                lblDOB.Text = "Not provded";

            }
            else
            {
                lblDOB.Text = Form1.Instance.LoggedInUser.DOB.Value.Date.ToString();
            }


            if (Form1.Instance.LoggedInUser.Gender == null)
            {
                lblGender.Text = "Not provded";

            }
            else
            {
                lblGender.Text = Form1.Instance.LoggedInUser.Gender;
            }

            
             if(Form1.Instance.LoggedInUser.SkypeId== null)
            {
                metroLabel13.Text = "Not provded";

            }
            else
            {
                metroLabel13.Text = Form1.Instance.LoggedInUser.SkypeId;
            }


            if (Form1.Instance.LoggedInUser.Description== null)
            {
                metroTile2.Text = "Not provded";

            }
            else
            {
                metroTile2.Text = Form1.Instance.LoggedInUser.Description;
            }


            if (Form1.Instance.LoggedInUser.phone== null)
            {
                metroLabel14.Text = "Not provided";
            }
            else
            {
                metroLabel14.Text = Form1.Instance.LoggedInUser.phone;
            }


            if (Form1.Instance.LoggedInUser.Address== null)
            {
                metroLabel15.Text = "Not provided";
            }
            else
            {
                metroLabel15.Text = Form1.Instance.LoggedInUser.Address;
            }


            if (Form1.Instance.LoggedInUser.Versity== null)
            {
                metroLabel19.Text = "Not provided";
            }
            else
            {
                metroLabel19.Text = Form1.Instance.LoggedInUser.Versity;

                if (Form1.Instance.LoggedInUser.Department== null)
                {
                    metroLabel19.Text += "\n Dept: not provided";
                }
                else
                {
                    metroLabel19.Text += "\n Dept: " + Form1.Instance.LoggedInUser.Department;
                }


                if (Form1.Instance.LoggedInUser.Semister== null)
                {
                    metroLabel19.Text += "\n Semister: Not provided";
                }
                else
                {
                    metroLabel19.Text += "\n Semister: " + Form1.Instance.LoggedInUser.Semister;

                }

            }


            if (Form1.Instance.LoggedInUser.Email== null)
            {
                metroLabel2.Text = "Not provided";
            }
            else
            {
                metroLabel12.Text = Form1.Instance.LoggedInUser.Email;

            }




            if (Form1.Instance.LoggedInUser.SSC== null)
            {
                metroLabel21.Text = "Not provided";
            }
            else
            {
                metroLabel21.Text = Form1.Instance.LoggedInUser.SSC;

                if (!(Form1.Instance.LoggedInUser.SSCYear== null))
                {

                    metroLabel21.Text += " ( " + Form1.Instance.LoggedInUser.SSCYear + " )";
                }

            }



            if (Form1.Instance.LoggedInUser.HSC== null)
            {
                metroLabel20.Text = "Not provided";
            }
            else
            {
                metroLabel20.Text = Form1.Instance.LoggedInUser.HSC;

                if (!(Form1.Instance.LoggedInUser.HSCYear == null))
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




        //below this is for other
        public void ViewOtherProfile(int x)
        {
            int refer = x;
            TutorHubDataContext td = new TutorHubDataContext(Login.Instance.connection);
            User profile = td.Users.SingleOrDefault(z => z.UserId == refer);

            //User profile=(User)v;
            
           

            

           
            ViewProfile.Instance.BringToFront();



            this.metroTabControl1.SelectedIndex = 0;

            if (profile.UserName== null)
            {
                metroLabel6.Text = metroLabel5.Text = profile.FirstName + " " + profile.LastName;

            }
            else
            {
                metroLabel6.Text = metroLabel5.Text = profile.UserName;
            }

            if (profile.FirstName == "" || profile.FirstName == "")
            {
                lblName.Text = profile.UserName;
            }
            else
            {
                lblName.Text = profile.FirstName + " " + profile.LastName + "( " + profile.UserName + " )";
            }

            if (profile.ToString()== null)
            {
                lblDOB.Text = "Not provded";

            }
            else
            {
                lblDOB.Text = profile.DOB.Value.Date.ToString();
            }


            if ( profile.Gender == null)
            {
                lblGender.Text = "Not provded";

            }
            else
            {
                lblGender.Text = profile.Gender;
            }


            if (profile.SkypeId== null)
            {
                metroLabel13.Text = "Not provded";

            }
            else
            {
                metroLabel13.Text = profile.SkypeId;
            }


            if (profile.Description== null)
            {
                metroTile2.Text = "Not provded";

            }
            else
            {
                metroTile2.Text = profile.Description;
            }


            if (profile.phone== null)
            {
                metroLabel14.Text = "Not provided";
            }
            else
            {
                metroLabel14.Text = profile.phone;
            }


            if (profile.Address== null)
            {
                metroLabel15.Text = "Not provided";
            }
            else
            {
                metroLabel15.Text = profile.Address;
            }


            if (profile.Versity== null)
            {
                metroLabel19.Text = "Not provided";
            }
            else
            {
                metroLabel19.Text = profile.Versity;

                if (profile.Department== null)
                {
                    metroLabel19.Text += "\n Dept: not provided";
                }
                else
                {
                    metroLabel19.Text += "\n Dept: " + profile.Department;
                }


                if (profile.Semister== null)
                {
                    metroLabel19.Text += "\n Semister: Not provided";
                }
                else
                {
                    metroLabel19.Text += "\n Semister: " + profile.Semister;

                }

            }


            if (profile.Email== null)
            {
                metroLabel2.Text = "Not provided";
            }
            else
            {
                metroLabel12.Text = profile.Email;

            }




            if (profile.SSC== null)
            {
                metroLabel21.Text = "Not provided";
            }
            else
            {
                metroLabel21.Text = profile.SSC;

                if (!(profile.SSCYear== null))
                {

                    metroLabel21.Text += " ( " + profile.SSCYear + " )";
                }

            }



            if (profile.HSC== null)
            {
                metroLabel20.Text = "Not provided";
            }
            else
            {
                metroLabel20.Text = profile.HSC;

                if (!(profile.HSCYear == null))
                {

                    metroLabel20.Text += " ( " + profile.HSCYear + " )";
                }

            }

            TutorHubDataContext tdx = new TutorHubDataContext(Login.Instance.connection);

            var skls = from z in tdx.Skills
                       where z.UserId == profile.UserId
                       select z;

            if (skls.Count() == 0)
            {
                metroLabel22.Text = "No skills provided";
            }
            else
            {
                metroLabel22.Text = "";
                foreach (var s in skls)
                {

                    metroLabel22.Text += s.SkillName + " ;";
                }
                metroLabel22.Text.Remove(metroLabel22.Text.Length - 2, 2);
            }




        }








    }
}
