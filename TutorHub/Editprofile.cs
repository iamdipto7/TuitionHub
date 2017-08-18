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
    public partial class Editprofile : UserControl
    {
        private static Editprofile instance;
        string imagePath;
        User updateUser,myUser;
        TutorHubDataContext tdc;
        public static Editprofile Instance
        {
            get
            {
                if (instance == null)
                    instance = new Editprofile();
                return instance;
            }
        }
        public Editprofile()
        {
            InitializeComponent();
            updateUser = new User();

            tdc = new TutorHubDataContext(Login.Instance.connection);
            myUser = Form1.Instance.LoggedInUser;

            updateUser.UserId = Form1.Instance.LoggedInUser.UserId;

            getValue();

        }

        private void getValue()
        {
            txtAddress.Text = myUser.Address;
            txtDesc.Text = myUser.Description;
            txtEmail.Text = myUser.Email;
            txtDOB.Text = myUser.DOB.Value.Date.ToString();
            txtFristName.Text = myUser.FirstName;
            txtLastName.Text = myUser.LastName;
            txtHSC.Text = myUser.HSC;
            txtPhone.Text = myUser.phone;

            var skls = from x in tdc.Skills
                       where x.UserId == Form1.Instance.LoggedInUser.UserId
                       select x;

            if (skls.Count() == 0)
            {
                metroLabel9.Text = "No skills provided";
            }
            else
            {
                metroLabel9.Text = "";
                foreach (var s in skls)
                {

                    metroLabel9.Text += s.SkillName + " ;";
                }
                metroLabel9.Text.Remove(metroLabel9.Text.Length - 2, 2);
            }

            //metroLabel8.Image = new Bitmap(myUser.Image);
            txtSkype.Text = myUser.SkypeId;
            txtSSC.Text = myUser.SSC;
            txtUName.Text = myUser.UserName;
            txtUniversity.Text = myUser.Versity;
            cmbDept.SelectedText = myUser.Department;
            cmbGender.SelectedText = myUser.Gender;
            cmbHSCYear.SelectedText = myUser.HSCYear;
            cmbSemister.SelectedText = myUser.Semister;
            cmbSSCYear.SelectedText = myUser.SSCYear;

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void Editprofile_Load(object sender, EventArgs e)
        {

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            //update profile

             updateUser = tdc.Users.SingleOrDefault(x =>x.UserId == Form1.Instance.LoggedInUser.UserId);

            //p.Name = txtName.Text;
            //p.Phone = txtPhone.Text;

            updateUser.Address = txtAddress.Text;
             updateUser.Description=txtDesc.Text;
             updateUser.Email=txtEmail.Text;
             //updateUser.DOB=Convert.TodtxtDOB.Text;
             updateUser.FirstName=txtFristName.Text;
             updateUser.LastName=txtLastName.Text;
             updateUser.HSC=txtHSC.Text;
             updateUser.phone=txtPhone.Text;

            //var skls = from x in tdc.Skills
            //           where x.UserId == Form1.Instance.LoggedInUser.UserId
            //           select x;

            //if (skls.Count() == 0)
            //{
            //    metroLabel9.Text = "No skills provided";
            //}
            //else
            //{
            //    metroLabel9.Text = "";
            //    foreach (var s in skls)
            //    {

            //        metroLabel9.Text += s.SkillName + " ;";
            //    }
            //    metroLabel9.Text.Remove(metroLabel9.Text.Length - 2, 2);
            //}

            updateUser.Image = imagePath;
            updateUser.SkypeId=txtSkype.Text;
            updateUser.SSC=txtSSC.Text;
            updateUser.UserName=txtUName.Text;
            updateUser.Versity=txtUniversity.Text;
            updateUser.Department=cmbDept.SelectedText;
            updateUser.Gender=cmbGender.SelectedText;
            updateUser.HSCYear=cmbHSCYear.SelectedText;
            updateUser.Semister=cmbSemister.SelectedText;
            updateUser.SSCYear = cmbSSCYear.SelectedText;
            tdc.SubmitChanges();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //change image

            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                metroLabel8.Image = new Bitmap(open.FileName);
                // image file path  
                imagePath = open.FileName;
            }
        }
    }
}
