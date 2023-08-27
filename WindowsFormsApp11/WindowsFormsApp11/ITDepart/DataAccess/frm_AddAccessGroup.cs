using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.ITdepart.DataAccess
{
    public partial class frmAddAccessGroup : Form
    {
        public frmAddAccessGroup()
        {
            InitializeComponent();
        }


        private bool CheckEmpty()
        {
            bool result = false;

            using (var context = new sdpEntities1())
            {
                var emp = from list in context.access select list;

                foreach (var emp2 in emp.ToList())
                {
                    if (emp2 != null)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        private void frmAddAccessGroup_Load(object sender, EventArgs e)
        {

            using (var classicContext = new sdpEntities1())
            {

                if (CheckEmpty())
                {
                    int maxID = classicContext.access.Max(p => p.AccessID) + 1;
                    textBox1.Text = maxID.ToString();

                }
                else
                {
                    textBox1.Text = "1";
                }
            }
        }

        private sbyte checkBoxChecker(bool check)
        {
            if (check)
            {
                return 1;
            } else
            {
                return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using( var context = new sdpEntities1())
            {
                var access = new access();

                access.AccessID = Convert.ToInt32(textBox1.Text);
                access.AccessName = accessNameTextBox.Text;

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

                context.access.Add(access);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                MessageBox.Show(" row(s) affected");
            }
        }

        private void addAccountLabel_Click(object sender, EventArgs e)
        {

        }

        private void accessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
