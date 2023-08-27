using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.InventoryDepart.Restock_From_Supplier
{
    public partial class frm_SetDangerLevelsInventory : Form
    {
        public frm_SetDangerLevelsInventory()
        {
            InitializeComponent();
        }

        private void frmSetDangerLevels_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.warehouse' 資料表。您可以視需要進行移動或移除。
            this.warehouseTableAdapter.Fill(this.sdpDataSet.warehouse);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.productlist' 資料表。您可以視需要進行移動或移除。
            this.productlistTableAdapter.Fill(this.sdpDataSet.productlist);
            //Checking data in database

        }

        private void lstStockID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checking data in database


        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cobWarehouseProduct.Text);
            int ReStockPoint = Convert.ToInt32(txtSetReStockPoint.Text);
            using (var context = new sdpEntities1())
            {
                var warehousestock = context.warehousestock.Find(id);
                if (warehousestock != null)
                {
                    warehousestock.reorderPoint = ReStockPoint;
                    context.SaveChanges();
                }
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void productlistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productlistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void btnSetRestockPoint_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cobWarehouseProduct.Text);
                int ReStockPoint = Convert.ToInt32(txtSetReStockPoint.Text);
                int inventoryID = Convert.ToInt32(cob_warehouseID.Text);
                using (var context = new sdpEntities1())
                {
                    var warehousestock = context.warehousestock.Find(id, inventoryID);
                    if (warehousestock != null)
                    {
                        warehousestock.reorderPoint = ReStockPoint;
                        context.SaveChanges();
                        MessageBox.Show("Edit complete!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
