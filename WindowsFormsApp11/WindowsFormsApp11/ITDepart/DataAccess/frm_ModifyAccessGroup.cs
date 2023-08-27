using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.ITDepart.DataAccess
{
    public partial class frm_ModifyAccessGroup : Form
    {
        public frm_ModifyAccessGroup()
        {
            InitializeComponent();
        }

        private void accessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frm_ModifyAccessGroup_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.access' 資料表。您可以視需要進行移動或移除。
            this.accessTableAdapter.Fill(this.sdpDataSet.access);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbo_AccessID.Text);

            using (var context = new sdpEntities1())
            {
                var access = context.access.Find(id);

                access.AddAccount = checkBoxChecker(addAccountCheckBox.Checked);
                access.RemoveAccount = checkBoxChecker(removeAccountCheckBox.Checked);
                access.ModifyAccount = checkBoxChecker(modifyAccountCheckBox.Checked);

                access.AddProduct = checkBoxChecker(addProductCheckBox.Checked);
                access.RemoveProduct = checkBoxChecker(removeProductCheckBox.Checked);
                access.ModifyProduct = checkBoxChecker(modifyProductCheckBox.Checked);

                access.AddStaff = checkBoxChecker(addStaffCheckBox.Checked);
                access.RemoveStaff = checkBoxChecker(removeStaffCheckBox.Checked);
                access.ModifyStaff = checkBoxChecker(modifyStaffCheckBox.Checked);
                access.DetailStaff = checkBoxChecker(detailStaffCheckBox.Checked);

                access.Payment = checkBoxChecker(paymentCheckBox.Checked);
                access.EditOrder = checkBoxChecker(editOrderCheckBox.Checked);
                access.CancelOrder = checkBoxChecker(cancelOrderCheckBox.Checked);

                access.RestockIndex = checkBoxChecker(restockIndexCheckBox.Checked);
                access.RestockFromWarehouse = checkBoxChecker(restockFromWarehouseCheckBox1.Checked);
                access.CofirmSalesRestock = checkBoxChecker(cofirmSalesRestockCheckBox.Checked);
                access.SetDangerLevelsSales = checkBoxChecker(setDangerLevelsSalesCheckBox.Checked);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Modify Finish");
            }
        }

        private sbyte checkBoxChecker(bool check)
        {
            if (check)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
