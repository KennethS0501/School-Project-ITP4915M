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

namespace WindowsFormsApp11.InventoryDepart.Restock_From_Supplier
{
    public partial class frm_RestockInventoryIndex : Form
    {
        public frm_RestockInventoryIndex()
        {
            InitializeComponent();
        }

        private void btnSetdangerlevels_Click(object sender, EventArgs e)
        {
            frm_SetDangerLevelsInventory frm = new frm_SetDangerLevelsInventory();
            frm.ShowDialog();

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
                var emp = (from list in classicContext.warehousestock select list);    // select * from employees

                foreach (var emp2 in emp.ToList())
                {
                    if (emp2.qty <= emp2.reorderPoint)
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

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            frm_RestockFromSupplier frm = new frm_RestockFromSupplier();
            frm.ShowDialog();
        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
            frm_ConfirmRestockOrderWarehouse frm = new frm_ConfirmRestockOrderWarehouse();
            frm.ShowDialog();
        }

        private void btnShowLow_LevelProduct_Click_1(object sender, EventArgs e)
        {
            frm_LowLevelProductInventory frm = new frm_LowLevelProductInventory();
            frm.Show();
        }
    }
}
