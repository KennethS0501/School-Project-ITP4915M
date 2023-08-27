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
    public partial class frmRemoveAccount : Form
    {
        public frmRemoveAccount()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frmRemoveAccount_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.account' 資料表。您可以視需要進行移動或移除。
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.sdpDataSet.staff);

        }

        private void btuRemove_Click(object sender, EventArgs e)
        {
            try
            {
                String id = staffIDComboBox.Text;

                using (var context = new sdpEntities1())
                {
                    var staff = new account { staffID = Convert.ToInt32(id) };
                    context.account.Attach(staff);
                    context.account.Remove(staff);
                    context.SaveChanges();
                }

                MessageBox.Show("Account successfully removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
            {
                MessageBox.Show("There is no account exist!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
