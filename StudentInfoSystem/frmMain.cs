using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            side_panel.Height = btn_home .Height;
            side_panel.Top = btn_home.Top;
            home1.BringToFront();

            // to move borderless form
            //this.MouseDown += Form1_MouseDown;
            //this.MouseMove += Form1_MouseMove;
            //this.MouseUp += Form1_MouseUp;

            panel_main.MouseDown += Form1_MouseDown;
            panel_main.MouseMove += Form1_MouseMove;
            panel_main.MouseUp += Form1_MouseUp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            side_panel.Height = btn_student.Height;
            side_panel.Top = btn_student.Top;
            studentinfo1.BringToFront();
        }

        private void btn_schooldetails_Click(object sender, EventArgs e)
        {
            side_panel.Height = btn_schooldetails.Height;
            side_panel.Top = btn_schooldetails.Top;
            schooldetails1.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            side_panel.Height = btn_home.Height;
            side_panel.Top = btn_home.Top;
            home1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}