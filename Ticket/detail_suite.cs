using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Ticket
{
    public partial class detail_suite : Form
    {


        public detail_suite()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left.png");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left2.png");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left efek.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left.png");
        }




        int i;
        private void detail_suite_Load(object sender, EventArgs e)
        {
            i = list_suite.parentY + 150;
            this.Location = new Point(list_suite.parentX + 220, list_suite.parentY + 220);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void effectDetail_timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                //effectDetail_timer.Stop();
            }
            else
            {
                Opacity += .03;
            }

            //int y = list_suite.parentY += 3; //INCREMENT
            //this.Location = new Point(list_suite.parentX + 220, y);
            //if (y >= i)
            //{
            //    effectDetail_timer.Stop();
            //}
        }
    }

}
