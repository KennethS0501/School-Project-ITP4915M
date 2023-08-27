using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.InventoryDepart.Installation_Management
{
    public partial class frm_UpdateInstallation : Form
    {

        public frm_UpdateInstallation()
        {
            InitializeComponent();
        }

        private void frm_ArrangeInstallationService_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.installation' 資料表。您可以視需要進行移動或移除。
            this.installationTableAdapter.Fill(this.sdpDataSet.installation);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);
            this.deliveryTableAdapter.Fill(this.sdpDataSet.delivery);

            int installationID = Convert.ToInt32(cbo_installationID.SelectedValue);

            using (var context = new sdpEntities1())
            {
                var installationDB = from d in context.delivery
                                 select d;

                foreach (var emp1 in installationDB.ToList())
                {
                    if (emp1.deliveryID == installationID)
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

                refrashData();
            }
        }

        private void refrashData()
        {
            for (int rows = 0; rows < installationDataGridView.Rows.Count; rows++)
            {
                if (installationDataGridView.Rows[rows].Cells[4].Value != null)
                {
                    String j = installationDataGridView.Rows[rows].Cells[4].Value.ToString();

                    if (j == 0.ToString())
                    {
                        installationDataGridView.Rows[rows].Cells[4].Value = "Invoiced";
                        installationDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Red;
                    }
                    else if (j == 1.ToString())
                    {
                        installationDataGridView.Rows[rows].Cells[4].Value = "Shipping";
                        installationDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Orange;
                    }
                    else if (j == 2.ToString())
                    {
                        installationDataGridView.Rows[rows].Cells[4].Value = "Shipped";
                        installationDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Green;
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
            int deliveryID = Convert.ToInt32(cbo_installationID.SelectedValue);

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


        private void btn_backTo_Click(object sender, EventArgs e)
        {
            int deliveryID = Convert.ToInt32(cbo_installationID.Text);

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

        private void btn_Shipped_Click(object sender, EventArgs e)
        {
            int installationID = Convert.ToInt32(cbo_installationID.Text);

            using (var context = new sdpEntities1())
            {
                var installationDB = from list in context.installation
                                     select list;

                foreach (var emp1 in installationDB.ToList())
                {
                    if (emp1.installationID == installationID)
                    {
                        emp1.status = 2.ToString();
                        context.SaveChanges();
                        this.installationTableAdapter.Fill(this.sdpDataSet.installation);
                        refrashData();
                    }
                }
            }
        }

        private void lbl_StateShow_Click(object sender, EventArgs e)
        {

        }
    }
}
