using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace newlounge171
{
    public partial class menu : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public menu()
        {
            InitializeComponent();
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            home1.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            stockordering1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            inventoryreport1.BringToFront();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            home1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            iteminfo1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
            costomizeorder1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            helpdesk sss = new helpdesk();
            sss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button6.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
