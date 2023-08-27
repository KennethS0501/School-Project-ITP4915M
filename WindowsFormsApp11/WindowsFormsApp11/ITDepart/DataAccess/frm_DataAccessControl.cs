using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.ITdepart.DataAccess;
using WindowsFormsApp11.ITDepart.DataAccess;

namespace WindowsFormsApp11
{
    public partial class frmDataAccessControl : Form
    {
        public frmDataAccessControl()
        {
            InitializeComponent();
        }

        private void btn_AddAccess_Click(object sender, EventArgs e)
        {
            frmAddAccessGroup frm = new frmAddAccessGroup();
            frm.Show();
        }

        private void btn_ModifyAccess_Click(object sender, EventArgs e)
        {
            frm_ModifyAccessGroup frm = new frm_ModifyAccessGroup();
            frm.Show();
        }

        private void btn_DeleteAccess_Click(object sender, EventArgs e)
        {
            frm_RemoveAccessGroup frm = new frm_RemoveAccessGroup();
            frm.Show();
        }

        private void btn_ChangeUserAccessGroup_Click(object sender, EventArgs e)
        {
            frmChangeUserAccess frm = new frmChangeUserAccess();
            frm.Show();
        }
    }
}
