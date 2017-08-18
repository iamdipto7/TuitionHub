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
    }
}
