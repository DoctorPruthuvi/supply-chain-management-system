using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newlounge171
{
    public partial class iteminfo : UserControl
    {
        public iteminfo()
        {
            InitializeComponent();
            itemspanel.Width = b1.Width;
            itemspanel.Left = b1.Left;
            dryfoodinfo1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemspanel.Width = b1.Width;
            itemspanel.Left = b1.Left;
            dryfoodinfo1.BringToFront();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            itemspanel.Width = b2.Width;
            itemspanel.Left = b2.Left;
            fruitveginfo1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itemspanel.Width = b3.Width;
            itemspanel.Left = b3.Left;
            supply_info1.BringToFront();
        }

        private void supply_info1_Load(object sender, EventArgs e)
        {

        }
    }
}
