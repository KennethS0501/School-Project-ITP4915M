using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.InventoryDepart.Restock_From_Supplier;
using WindowsFormsApp11.SalesDepart.Restock_From_Warehouse;

namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    public partial class frm_RestockIndex : Form
    {
        int accessID;
        public frm_RestockIndex(int accessID)
        {
            InitializeComponent();

            this.accessID = accessID;
        }
        private bool accessCheck(int accessName)
        {
            using (var context = new sdpEntities1())
            {
                var result = context.access.Find(accessID);

                //accessName 1 = create restock order
                //accessName 2 = confirm restock order
                //accessName 3 = set denger levels sales

                if (accessName == 1 && result.RestockFromWarehouse == 1)
                {
                    return true;
                }
                else if (accessName == 2 && result.CofirmSalesRestock == 1)
                {
                    return true;
                }
                else if (accessName == 3 && result.SetDangerLevelsSales == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            if (accessCheck(1))
            {
                frm_RestockFromWarehouse frm = new frm_RestockFromWarehouse();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You does not have access to use!");
            }

        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
            if (accessCheck(2))
            {
                frm_ConfirmRestockOrderSales frm = new frm_ConfirmRestockOrderSales();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You does not have access to use!");
            }

        }

        private void btnSetdangerlevels_Click(object sender, EventArgs e)
        {
            if (accessCheck(3))
            {
                frm_SetDangerLevels frm = new frm_SetDangerLevels();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You does not have access to use!");
            }
        }






        private void lblNumOfLowLevelProduct_Click(object sender, EventArgs e)
        {

        }

        private void frmInventoryIndex_Load(object sender, EventArgs e)
        {
            noOfShopRestockProduct();
        }

        private void noOfShopRestockProduct()
        {
            int NumLowLevelProduct = 0;
            using (var classicContext = new sdpEntities1())
            {
                var emp = (from list in classicContext.retailstorestock select list);    // select * from employees

                foreach (var emp2 in emp.ToList())
                {
                    if (emp2.qty <= emp2.restockPoint)
                    {
                        NumLowLevelProduct += 1;

                    }
                }
                lblNumOfLowLevelProduct.Text = Convert.ToString(NumLowLevelProduct);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noOfShopRestockProduct();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void btnShowLow_LevelProduct_Click_1(object sender, EventArgs e)
        {
            frm_LowLevelProduct frm = new frm_LowLevelProduct();
            frm.Show();
        }
    }
}
