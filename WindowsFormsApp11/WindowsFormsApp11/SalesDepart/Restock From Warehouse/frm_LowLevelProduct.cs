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
    public partial class frm_LowLevelProduct : Form
    {
        public frm_LowLevelProduct()
        {
            InitializeComponent();
        }

        private void lstDetailofLowLevelStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DetailOfLevel_Load(object sender, EventArgs e)
        {
            using (var Context = new sdpEntities1())
            {
                var warehousestock = (from list in Context.retailstorestock select list);    // select * from employees
                var warehouse = (from list in Context.retailstore select list);
                foreach (var warehouseStock in warehousestock.ToList())
                {
                    if (warehouseStock.qty <= warehouseStock.restockPoint)
                    {
                        var warehousestockName = Context.productlist.Find(warehouseStock.RproductID);
                        lstDetailofLowLevelStock.Items.Add(warehousestockName.name);
                    }
                }
                foreach (var wareHouse in warehouse.ToList())
                {
                    cobWarehouse.Items.Add(wareHouse.shopID);
                }
            }
        }

        private void btnBackToInvertorypage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void cobWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeID();

        }

        private void changeID()
        {
            int warehouseID = Convert.ToInt32(cobWarehouse.Text);
            using (var Context = new sdpEntities1())
            {
                var stock = from w in Context.retailstorestock
                            join p in Context.productlist on w.RproductID equals p.productID
                            where w.shopID == warehouseID && w.qty < w.restockPoint
                            select p;
                lstDetailofLowLevelStock.DataSource = stock.ToList();
                lstDetailofLowLevelStock.ValueMember = "name";
                lstDetailofLowLevelStock.DisplayMember = "name";

            }
        }
    }
}
