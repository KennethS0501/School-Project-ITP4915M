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
    public partial class frmRemoveStaff : Form
    {
        public frmRemoveStaff()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frmRemoveStaff_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.sdpDataSet.staff);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = cboStaffID.Text;

            using (var context = new sdpEntities1())
            {
                var staff = new staff { staffID = Convert.ToInt32(id) };
                context.staff.Attach(staff);
                context.staff.Remove(staff);
                context.SaveChanges();
                MessageBox.Show("Staff successfully removed!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
