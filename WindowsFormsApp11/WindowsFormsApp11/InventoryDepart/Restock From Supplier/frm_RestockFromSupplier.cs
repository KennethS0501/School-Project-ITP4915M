using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.InventoryDepart.Restock_From_Supplier
{
    public partial class frm_RestockFromSupplier : Form
    {
        public frm_RestockFromSupplier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRestockFromWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.supplier' 資料表。您可以視需要進行移動或移除。
            this.supplierTableAdapter.Fill(this.sdpDataSet.supplier);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.warehouse' 資料表。您可以視需要進行移動或移除。
            this.warehouseTableAdapter.Fill(this.sdpDataSet.warehouse);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.retailstore' 資料表。您可以視需要進行移動或移除。
            this.retailstoreTableAdapter.Fill(this.sdpDataSet.retailstore);
            using (var classicContext = new sdpEntities1())
            {
                var productlists = from list in classicContext.productlist
                                   select list;

                foreach (var varproductlists in productlists.ToList())
                {
                    lstRetailShopProduct.Items.Add(Convert.ToInt32(varproductlists.productID));
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var selectbuffer = lstRetailShopProduct.SelectedItem;
            if (selectbuffer == null)
            {
                MessageBox.Show("Please select a product to add!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lstSelectedProduct.Items.Add(selectbuffer);
                lstRetailShopProduct.Items.Remove(selectbuffer);
                using (var classicContext = new sdpEntities1())
                {
                    var productlists = classicContext.productlist.Find(selectbuffer);
                    lstProductName.Items.Add(productlists.name);

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectbuffer = lstSelectedProduct.SelectedItem;
            if (selectbuffer == null)
            {
                MessageBox.Show("Please select a product to delete", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lstRetailShopProduct.Items.Add(selectbuffer);
                lstSelectedProduct.Items.Remove(selectbuffer);
                using (var classicContext = new sdpEntities1())
                {
                    var productlists = classicContext.productlist.Find(selectbuffer);
                    lstProductName.Items.Remove(productlists.name);
                }
            }
        }

        private void btnSubmitRestockWarehoues_Click(object sender, EventArgs e)
        {
            using (var classicContext = new sdpEntities1())
            {
       
                int[] plist = lstSelectedProduct.Items.OfType<int>().ToArray();
                int supplierID = Convert.ToInt32(cbo_supplierID.Text);
                int warehouseID = Convert.ToInt32(cbo_warehouseID.Text);
                int qty = Convert.ToInt32(txtQTY.Text);


                //DateTime nowTime = DateTime.Now;

                for (int i = 0; i < plist.Count(); i++)
                {
                    var restockWarehouseRestock = new restockwarehousestock();

                    restockWarehouseRestock.supplierID = supplierID;
                    restockWarehouseRestock.warehouseID = warehouseID;
                    restockWarehouseRestock.productID = plist[i];
                    restockWarehouseRestock.qty = qty;
                    restockWarehouseRestock.Date = DateTime.Now;

                    classicContext.restockwarehousestock.Add(restockWarehouseRestock);
                }
                classicContext.SaveChanges();
            }
        }
    }
}
