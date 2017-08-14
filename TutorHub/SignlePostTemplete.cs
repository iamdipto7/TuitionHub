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
    public partial class SignlePostTemplete : MetroFramework.Controls.MetroUserControl
    {
        private static SignlePostTemplete instance;
        public static SignlePostTemplete Instance
        {
            get
            {
                if (instance == null)
                    instance = new SignlePostTemplete();
                return instance;
            }
        }
        public SignlePostTemplete()
        {
            InitializeComponent();
        }
    }
}
