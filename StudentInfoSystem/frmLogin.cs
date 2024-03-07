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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            lbl_benedicto.Parent = pictureBox1;
            lbl_cebu.Parent = pictureBox1;

        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
           
        }

        private void selectuser1_Load(object sender, EventArgs e)
        {

        }
    }
}