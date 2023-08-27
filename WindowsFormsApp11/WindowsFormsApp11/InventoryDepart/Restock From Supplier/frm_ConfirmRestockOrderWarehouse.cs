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
    public partial class frm_ConfirmRestockOrderWarehouse : Form
    {

        public frm_ConfirmRestockOrderWarehouse()
        {
            InitializeComponent();
        }

        private void restockwarehousestockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restockwarehousestockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frm_ConfirmRestockOrder_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.restockwarehousestock' 資料表。您可以視需要進行移動或移除。
            this.restockwarehousestockTableAdapter.Fill(this.sdpDataSet.restockwarehousestock);

            cbo_Date.Text = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

            addDateToComboBox();
            selectDate();

        }

        private void addDateToComboBox()
        {
            using (var context = new sdpEntities1())
            {
                var date = from r in context.restockwarehousestock
                           select r.Date;

                foreach (var emp1 in date.ToList().Distinct())
                {
                    cbo_Date.Items.Add(emp1.ToString("yyyy-MM-dd HH-mm-ss")); 
                }
            }
        }

        private void selectDate()
        {
            using (var context = new sdpEntities1())
            {
                String sDate = cbo_Date.Text;

                DateTime date = DateTime.ParseExact(sDate, "yyyy-MM-dd HH-mm-ss", System.Globalization.CultureInfo.InvariantCulture);

                var restockDB = from r in context.restockwarehousestock
                                where r.Date == date
                                select new { r.warehouseID, r.supplierID, r.productID, r.qty, r.Date };

                dataGridView1.DataSource = restockDB.ToList();

                dataGridView1.Columns[0].HeaderCell.Value = "Warehouse ID";

                dataGridView1.Columns[1].HeaderCell.Value = "Supplier ID";

                dataGridView1.Columns[2].HeaderCell.Value = "Product ID";

                dataGridView1.Columns[3].HeaderCell.Value = "qty";

                dataGridView1.Columns[4].HeaderCell.Value = "Date";
            }
        }

        private void cbo_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDate();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            using (var context = new sdpEntities1())
            {
                List<int> productID = new List<int>();
                List<int> productQty = new List<int>();

                int warehouseID = Convert.ToInt32(this.dataGridView1.Rows[0].Cells[0].Value);

                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    productID.Add(Convert.ToInt32(this.dataGridView1.Rows[i].Cells[2].Value));
                    productQty.Add(Convert.ToInt32(this.dataGridView1.Rows[i].Cells[3].Value));
                }

                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    var warehouseStock = context.warehousestock.Find(productID[i], warehouseID );

                    warehouseStock.qty += productQty[i];
                }
                context.SaveChanges();
            }
        }
    }
}
