using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.InventoryDepart.Delivery_Management
{
    public partial class frm_TrackDelivery : Form
    {

        public frm_TrackDelivery()
        {
            InitializeComponent();
        }

        private void frm_ArrangeService_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);


            using (var context = new sdpEntities1())
            {
                var deliveryDB = from d in context.delivery
                                 select d;

                refrashData();
            }
        }

        private void refrashData()
        {
            for (int rows = 0; rows < deliveryDataGridView.Rows.Count; rows++)
            {
                if (deliveryDataGridView.Rows[rows].Cells[4].Value != null)
                {
                    String j = deliveryDataGridView.Rows[rows].Cells[4].Value.ToString();

                    if (j == 0.ToString())
                    {
                        deliveryDataGridView.Rows[rows].Cells[4].Value = "Invoiced";
                        deliveryDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Red;
                    }
                    else if (j == 1.ToString())
                    {
                        deliveryDataGridView.Rows[rows].Cells[4].Value = "Shipping";
                        deliveryDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Orange;
                    }
                    else if (j == 2.ToString())
                    {
                        deliveryDataGridView.Rows[rows].Cells[4].Value = "Shipped";
                        deliveryDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void deliveryBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
            refrashData();
        }
    }
}
