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
    
    public partial class EditProfilePanel : UserControl
    {
        private static EditProfilePanel instance;
        public static EditProfilePanel Instance
        {
            get
            {
                if (instance == null)
                    instance = new EditProfilePanel();
                return instance;
            }
        }
        public EditProfilePanel()
        {
            InitializeComponent();
        }

        private void EditProfilePanel_Load(object sender, EventArgs e)
        {
            flowPanel.AutoScroll = false;
            flowPanel.HorizontalScroll.Enabled = false;
            flowPanel.HorizontalScroll.Visible = false;
            flowPanel.HorizontalScroll.Maximum = 0;
            flowPanel.AutoScroll = true;

            
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
