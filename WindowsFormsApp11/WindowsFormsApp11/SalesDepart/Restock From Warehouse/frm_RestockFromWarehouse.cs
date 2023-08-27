using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    public partial class frm_RestockFromWarehouse : Form
    {
        public frm_RestockFromWarehouse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRestockFromWarehouse_Load(object sender, EventArgs e)
        {
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
                int Destinationshop = Convert.ToInt32(cobDestinationshop.Text);
                int warehouseID = Convert.ToInt32(cobWarehouse.Text);
                int qty = Convert.ToInt32(txtQTY.Text);
                bool correctNum = true;

                //DateTime nowTime = DateTime.Now;
                if (txtQTY.Value == 0)
                {
                    correctNum = false;
                    MessageBox.Show("RestockPoint can not be 0 or less than 0!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if(correctNum == true)
                {
                    for (int i = 0; i < plist.Count(); i++)
                    {
                        var restockretailshopproduct = new restockretailproduct();

                        restockretailshopproduct.shopID = Destinationshop;
                        restockretailshopproduct.warehouseID = warehouseID;
                        restockretailshopproduct.productID = plist[i];
                        restockretailshopproduct.qty = qty;
                        restockretailshopproduct.Date = DateTime.Now;

                        classicContext.restockretailproduct.Add(restockretailshopproduct);
                    }
                    classicContext.SaveChanges();
                    MessageBox.Show("The restock request in sent!", "Success message", MessageBoxButtons.OK);
                }
            }
        }

        private void txtQTY_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
