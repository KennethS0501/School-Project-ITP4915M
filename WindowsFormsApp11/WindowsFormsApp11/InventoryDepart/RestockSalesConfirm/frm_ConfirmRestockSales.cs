using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.InventoryDepart.RestockSalesConfirm
{
    public partial class frm_ConfirmRestockSales : Form
    {
        public frm_ConfirmRestockSales()
        {
            InitializeComponent();
        }

        private void addDateToComboBox()
        {
            using (var context = new sdpEntities1())
            {
                var date = from r in context.restockretailproduct
                           where r.Status == "0" || r.Status == null
                           orderby r.Date ascending
                           select r.Date;

                foreach (var emp1 in date.ToList().Distinct())
                {
                    cbo_Date.Items.Add(emp1.ToString("yyyy-MM-dd HH-mm-ss"));
                }
            }
        }

        private void frm_ConfirmRestockSales_Load(object sender, EventArgs e)
        {
            addDateToComboBox();
        }

        private void selectDate()
        {
            using (var context = new sdpEntities1())
            {

                String sDate = cbo_Date.Text;

                DateTime date = DateTime.ParseExact(sDate, "yyyy-MM-dd HH-mm-ss", System.Globalization.CultureInfo.InvariantCulture);


                var restockDB = from r in context.restockretailproduct
                                where r.Date == date
                                select new { r.shopID, r.warehouseID, r.productID, r.qty, r.Date };

                dataGridView1.DataSource = restockDB.ToList();

                dataGridView1.Columns[0].HeaderCell.Value = "Shop ID";

                dataGridView1.Columns[1].HeaderCell.Value = "Warehouse ID";

                dataGridView1.Columns[2].HeaderCell.Value = "Product ID";

                dataGridView1.Columns[3].HeaderCell.Value = "qty";

                dataGridView1.Columns[4].Width = 400;
                dataGridView1.Columns[4].HeaderCell.Value = "Date";
            }
        }

        private void cbo_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDate();
        }
    }
}
