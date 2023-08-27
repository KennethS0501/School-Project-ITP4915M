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
    public partial class frm_LowLevelProductInventory : Form
    {
        public frm_LowLevelProductInventory()
        {
            InitializeComponent();
        }

        private void lstDetailofLowLevelStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void warehousestockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehousestockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void DetailOfLevel_Load(object sender, EventArgs e)
        {
            using (var Context = new sdpEntities1())
            {
                var warehousestock = (from list in Context.warehousestock select list);    // select * from employees
                var warehouse = (from list in Context.warehouse select list);
                foreach (var warehouseStock in warehousestock.ToList())
                {
                    if (warehouseStock.qty <= warehouseStock.reorderPoint)
                    {
                        var warehousestockName = Context.productlist.Find(warehouseStock.WproductID);
                        lstDetailofLowLevelStock.Items.Add(warehousestockName.name);
                    }
                }
                foreach (var wareHouse in warehouse.ToList())
                {
                    cobWarehouse.Items.Add(wareHouse.warehouseID);
                }


            }

            changeID();

        }

        private void btnBackToInvertorypage_Click(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void cobWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeID();

/*            int warehouseID = Convert.ToInt32(cobWarehouse.Text);
            using (var Context = new sdpEntities1())
            {
                var stock = from w in Context.warehousestock
                            join p in Context.productlist on w.WproductID equals p.productID
                            where w.warehouseID == warehouseID && w.qty < w.reorderPoint
                            select p;
                lstDetailofLowLevelStock.DataSource = stock.ToList();
                lstDetailofLowLevelStock.ValueMember = "name";
                lstDetailofLowLevelStock.DisplayMember = "name";
            }*/
        }

        private void changeID()
        {
            int warehouseID = Convert.ToInt32(cobWarehouse.Text);
            using (var Context = new sdpEntities1())
            {
                var stock = from w in Context.warehousestock
                            join p in Context.productlist on w.WproductID equals p.productID
                            where w.warehouseID == warehouseID && w.qty < w.reorderPoint
                            select p;
                lstDetailofLowLevelStock.DataSource = stock.ToList();
                lstDetailofLowLevelStock.ValueMember = "name";
                lstDetailofLowLevelStock.DisplayMember = "name";
            }
        }
    }
}
