using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.ITdepart.Staff
{
    public partial class frmStaffManagement : Form
    {
        public frmStaffManagement()
        {
            InitializeComponent();
        }

        private void btuAddAccount_Click(object sender, EventArgs e)
        {
            frmAddStaff frm = new frmAddStaff();
            frm.ShowDialog();
        }

        private void btuRemoveStaff_Click(object sender, EventArgs e)
        {
            frmRemoveStaff frm = new frmRemoveStaff();
            frm.ShowDialog();

        }

        private void btuModifyStaff_Click(object sender, EventArgs e)
        {
            frmModifyStaff frm = new frmModifyStaff();
            frm.ShowDialog();
        }

        private void btuDetailofStaff_Click(object sender, EventArgs e)
        {
            frmDetailStaff frm = new frmDetailStaff();
            frm.ShowDialog();
        }
    }
}
