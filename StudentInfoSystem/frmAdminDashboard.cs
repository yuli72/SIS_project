using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class frmAdminDashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
            ucDashboard1.BringToFront();
        }

        private void item_Dashboard_Click(object sender, EventArgs e)
        {
            ucDashboard1.BringToFront();
        }

        private void item_Allstudent_Click(object sender, EventArgs e)
        {
            ucAllStudents1 .BringToFront();
        }

        private void item_Studentdetails_Click(object sender, EventArgs e)
        {
            ucStudentDetails1.BringToFront();
        }

        private void item_Enrollstudent_Click(object sender, EventArgs e)
        {
            ucEnrollStudents1.BringToFront();
        }

        private void item_addteacher_Click(object sender, EventArgs e)
        {
            ucAddTeacher1.BringToFront();
        }

        private void navBarControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
