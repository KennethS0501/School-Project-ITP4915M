using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.ITdepart.Account
{
    public partial class frmModifyAccount : Form
    {
        public frmModifyAccount()
        {
            InitializeComponent();
        }

        private void btuModify_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboStaffID.Text);
                int password = Convert.ToInt32(txtPassword.Text);

                using (var context = new sdpEntities1())
                {
                        var result = context.account.Find(id);
                        if (result != null)
                        {
                            result.password = password;
                            context.SaveChanges();
                            MessageBox.Show("Password change success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("There is no account exist!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input! Please try again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frmModifyAccount_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.sdpDataSet.staff);
        }
    }
}
