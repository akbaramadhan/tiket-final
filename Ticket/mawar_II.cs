﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class mawar_II : Form
    {
        public System.Windows.Forms.Label label;
        public mawar_II()
        {
            InitializeComponent();
        }

        private void Lb_close_MouseUp(object sender, MouseEventArgs e)
        {
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close2.png");
        }

        private void Lb_close_MouseDown(object sender, MouseEventArgs e)
        {
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close1.png");
        }

        int i;
        private void mawar_II_Load(object sender, EventArgs e)
        {
            i = list_mawar.parentY + 150;
            this.Location = new Point(list_mawar.parentX + 220, list_mawar.parentY + 150);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Lb_close_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\X.png");
        }

        private void Lb_close_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button back.png");
        }

        private void Lb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void effectDetail_mawar_II_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                effectDetail_mawar_II.Stop();
            }
            else
            {
                Opacity += .03;
            }

            int y = list_mawar.parentY += 3; //INCREMENT
            this.Location = new Point(list_mawar.parentX + 220, y);
            if (y >= i)
            {
                effectDetail_mawar_II.Stop();
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
