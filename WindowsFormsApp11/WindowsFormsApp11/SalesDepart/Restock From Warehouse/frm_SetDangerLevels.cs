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

namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    public partial class frm_SetDangerLevels : Form
    {
        public frm_SetDangerLevels()
        {
            InitializeComponent();
        }

        private void frmSetDangerLevels_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.retailstore' 資料表。您可以視需要進行移動或移除。
            this.retailstoreTableAdapter.Fill(this.sdpDataSet.retailstore);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.productlist' 資料表。您可以視需要進行移動或移除。
            this.productlistTableAdapter.Fill(this.sdpDataSet.productlist);
            //Checking data in database

        }

        private void btnSetRestockPoint_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cobWarehouseProduct.Text);
            bool numericInput = true;
            int shopID = Convert.ToInt32(cob_ShopID.Text);
            bool correctNum = true;
            bool isNull = false;
            using (var context = new sdpEntities1())
            {
                if (int.TryParse(txtSetReStockPoint.Text, out int result) == false)
                {
                    MessageBox.Show("Please enter a number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    numericInput = false;
                } 

                if(numericInput == true)
                {
                    int ReStockPoint = Convert.ToInt32(txtSetReStockPoint.Text);
                    var warehousestock = context.retailstorestock.Find(id, shopID);

                    if ( Convert.ToInt32(txtSetReStockPoint.Text) <= 0)
                    {
                        MessageBox.Show("RestockPoint can not be 0 or less than 0!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        correctNum = false;
                    }

                    if (txtSetReStockPoint.Text.Equals(""))
                    {
                        MessageBox.Show("Pleace enter a value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        isNull = true;
                    }

                    if (warehousestock != null && isNull == false && correctNum == true && numericInput == true)
                    {
                        warehousestock.restockPoint = ReStockPoint;
                        context.SaveChanges();
                        MessageBox.Show("The restock point sucessfully changed!", "Success message", MessageBoxButtons.OK);
                    }
                }
                
            }
        }
    }
}
