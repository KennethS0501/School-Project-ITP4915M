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
    public partial class frm_ArrangeDeliveryService : Form
    {

        public frm_ArrangeDeliveryService()
        {
            InitializeComponent();
        }

        private void frm_ArrangeDeliveryService_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);

            int deliveryID = Convert.ToInt32(cbo_DeliveryID.SelectedValue);

            using (var context = new sdpEntities1())
            {
                var deliveryDB = from d in context.delivery
                                 select d;

                foreach (var emp1 in deliveryDB.ToList())
                {
                    if (emp1.deliveryID == deliveryID)
                    {
                        if (emp1.status == 0.ToString())
                        {
                            lbl_StateShow.Text = "Invoiced";
                        }
                        else if (emp1.status == 1.ToString())
                        {
                            lbl_StateShow.Text = "Shipping";
                        }
                        else if (emp1.status == 2.ToString())
                        {
                            lbl_StateShow.Text = "Shipped";
                        }
                        else
                        {
                            lbl_StateShow.Text = "Error";
                        }

                    }
                }

                using (var context1 = new sdpEntities1())
                {

                    var staffDB = from list in context.staff
                                  select list;

                    foreach (var emp1 in staffDB.ToList())
                    {
                        if (emp1.titleID == 4)
                        {
                            cbo_DeliveryMan.Items.Add(emp1.staffID.ToString());
                        }
                    }
                }

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

        private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void deliveryBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);
        }

        private void cbo_DeliveryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deliveryID = Convert.ToInt32(cbo_DeliveryID.SelectedValue);

            using (var context = new sdpEntities1())
            {
                var deliveryDB = from d in context.delivery
                                 select d;

                foreach (var emp1 in deliveryDB.ToList())
                {
                    if (emp1.deliveryID == deliveryID)
                    {
                        if (emp1.status == 0.ToString())
                        {
                            lbl_StateShow.Text = "Invoiced";
                        }
                        else if (emp1.status == 1.ToString())
                        {
                            lbl_StateShow.Text = "Shipping";
                        }
                        else if (emp1.status == 2.ToString())
                        {
                            lbl_StateShow.Text = "Shipped";
                        }
                        else
                        {
                            lbl_StateShow.Text = "Error";
                        }
                    }
                }
            }
        }

        private void btn_Arrange_Click(object sender, EventArgs e)
        {
            if (cbo_DeliveryMan.Text == "")
            {
                MessageBox.Show("Please choose a delivery staff!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int deliveryID = Convert.ToInt32(cbo_DeliveryID.Text);
                int staffID = Convert.ToInt32(cbo_DeliveryMan.Text);

                using (var context = new sdpEntities1())
                {
                    var deliveryDB = from list in context.delivery
                                     select list;

                    var staffDB = from list in context.staff
                                  select list;

                    for (int i = 0; i < deliveryDataGridView.Rows.Count; i++)
                    {
                        if (deliveryDataGridView.Rows[i].Cells[0].Value.ToString() == cbo_DeliveryID.Text)
                        {
                            if (deliveryDataGridView.Rows[i].Cells[3].Value.ToString() == "")
                            {
                                foreach (var emp1 in deliveryDB.ToList())
                                {
                                    foreach (var emp2 in staffDB.ToList())
                                    {
                                        if (emp1.deliveryID == deliveryID)
                                        {
                                            emp1.staffID = staffID;
                                            emp1.status = 1.ToString();
                                            emp1.deliveryDate = DateTime.Now;
                                            context.SaveChanges();
                                            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
                                            refrashData();
                                        }
                                    }
                                }
                                MessageBox.Show("Arrange success.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Already arrange a staff!", "Repeat Arrange", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
        }

        private void btn_backTo_Click(object sender, EventArgs e)
        {
            int deliveryID = Convert.ToInt32(cbo_DeliveryID.Text);

            using (var context = new sdpEntities1())
            {
                var deliveryDB = from list in context.delivery
                                 select list;

                foreach (var emp1 in deliveryDB.ToList())
                {
                    if (emp1.deliveryID == deliveryID)
                    {
                        emp1.status = 0.ToString();
                        emp1.staffID = null;
                        context.SaveChanges();
                        this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
                        refrashData();
                    }
                    
                }
            }
        }
    }
}
