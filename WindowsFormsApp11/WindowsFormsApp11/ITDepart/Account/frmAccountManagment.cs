using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.ITdepart.Account;

namespace WindowsFormsApp11
{
    public partial class frmAccountManagement : Form
    {
        int accessID = 0;

        public frmAccountManagement(int accessID)
        {
            InitializeComponent();

            this.accessID = accessID;
        }

        

        private bool accessCheck(int accessName)
        {
            using (var context = new sdpEntities1())
            {
                var result = context.access.Find(accessID);

                if (accessName == 1 && result.AddAccount == 1)
                {
                    return true;
                } else if (accessName == 2 && result.RemoveAccount == 1)
                {
                    return true;
                } else if (accessName == 3 && result.ModifyAccount == 1)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        private void btuAddAccount_Click(object sender, EventArgs e)
        {
            if (accessCheck(1))
            {
                frmAddAccount frm = new frmAddAccount();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You does not have access to use!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (accessCheck(2))
            {
                frmRemoveAccount frm = new frmRemoveAccount();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You does not have access to use!");
            }
        }

        private void btuModifyAccount_Click(object sender, EventArgs e)
        {
            if (accessCheck(3))
            {
                frmModifyAccount frm = new frmModifyAccount();
                frm.ShowDialog();
            } else
            {
                MessageBox.Show("You does not have access to use!");
            }
        }

        private void SystemSecurity_Load(object sender, EventArgs e)
        {

        }
    }
}
