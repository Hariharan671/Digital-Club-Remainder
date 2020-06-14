using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Club_Remainder
{
    public partial class AbtUserControl : UserControl
    {

        private static AbtUserControl instance;

        public static AbtUserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AbtUserControl();
                }
                return instance;
            }
        }

        public AbtUserControl()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
