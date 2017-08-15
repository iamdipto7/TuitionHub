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

        Post NewPost = new Post();

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

            //start time combobox
            NewPost.StartTime = metroComboBox4.Text;
            
        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           NewPost.EndTime = metroComboBox5.Text;
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //course select combo box

            NewPost.CourseName = metroComboBox2.Text;

            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dept combo box


            NewPost.DeptName = metroComboBox1.Text;
            TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);
            var Result = from x in tdc.Courses join y in tdc.Depts on x.DeptId equals y.DeptId
                         where y.DeptName == NewPost.DeptName
                         select x;

            metroComboBox2.Items.Clear();
            foreach ( var selected in Result)
            {
              metroComboBox2.Items.Add(selected.CourseName);

            }

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewPost.PostType = metroComboBox3.Text;
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            NewPost.Date = metroDateTime1.Value.Date;
        }

        private void CreatePostButton_Click(object sender, EventArgs e)
        {
            

            if( string.IsNullOrWhiteSpace(metroTextBox1.Text) || string.IsNullOrWhiteSpace(topicTextBox.Text) || string.IsNullOrWhiteSpace(NewPost.StartTime) || string.IsNullOrWhiteSpace(NewPost.EndTime) || string.IsNullOrWhiteSpace(NewPost.DeptName) || string.IsNullOrWhiteSpace(NewPost.CourseName) || string.IsNullOrWhiteSpace(NewPost.PostType) || string.IsNullOrWhiteSpace(NewPost.Date.ToString()) )
            {
                MetroFramework.MetroMessageBox.Show(this, "none of the field can be empty");
            }



            else
            {
                NewPost.PostTitle = metroTextBox1.Text;
                NewPost.Topic = topicTextBox.Text;
                NewPost.UserId = Form1.Instance.LoggedInUser.UserId;


                TutorHubDataContext tdc = new TutorHubDataContext(Login.Instance.connection);

                tdc.Posts.InsertOnSubmit(NewPost);
                tdc.SubmitChanges();


                MetroFramework.MetroMessageBox.Show(this, "Post Published");

                metroComboBox1.SelectedIndex = -1;
                metroComboBox2.SelectedIndex = -1;
                metroComboBox3.SelectedIndex = -1;
                metroComboBox4.SelectedIndex = -1;
                metroComboBox5.SelectedIndex = -1;
                metroDateTime1.Value=DateTime.Now;
                metroTextBox1.Text = "";
                topicTextBox.Text= "";



                NewPost.PostTitle = "";
                NewPost.PostType = "";
                NewPost.StartTime = "";
                NewPost.EndTime = "";
                NewPost.DeptName = "";
                NewPost.CourseName = "";
                NewPost.Topic = "";
                NewPost.Date = DateTime.Now;










                HomePage.Instance.BringToFront();






            }






        }
    }
}
