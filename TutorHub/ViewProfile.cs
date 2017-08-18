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
    }
}
