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
    public partial class AddPostPage : UserControl
    {
        Post NewPost= new Post();


        private static AddPostPage instance;
        public static AddPostPage Instance
        {
            get
            {
                if (instance == null)
                    instance = new AddPostPage();
                return instance;
            }
        }
        public AddPostPage()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddPostPage_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewPost.EndTime=  cb   .GetItemText
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
           NewPost.CourseName = cbCourse.GetItemText(cbCourse.SelectedItem);
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewPost.DeptName = cbDept.GetItemText(cbDept.SelectedItem);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewPost.PostType = cbType.GetItemText(cbType.SelectedItem);
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            NewPost.Date = metroDateTime1.Value;
        }
    }
}
