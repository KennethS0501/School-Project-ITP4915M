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
    public partial class frm_ArrangeInstallationService : Form
    {

        public frm_ArrangeInstallationService()
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

            int installationID = Convert.ToInt32(cbo_InstallationID.SelectedValue);

            using (var context = new sdpEntities1())
            {
                var installationDB = from i in context.installation
                                 select i;

                foreach (var emp1 in installationDB.ToList())
                {
                    if (emp1.installationID == installationID)
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
                        if (emp1.titleID == 5)
                        {
                            cbo_InstallationMan.Items.Add(emp1.staffID.ToString());
                        }
                    }
                }

                refrashData();
            }
        }

        private void refrashData()
        {
            for (int rows = 0; rows < InstallationDataGridView.Rows.Count; rows++)
            {
                if (InstallationDataGridView.Rows[rows].Cells[4].Value != null)
                {
                    String j = InstallationDataGridView.Rows[rows].Cells[4].Value.ToString();

                    if (j == 0.ToString())
                    {
                        InstallationDataGridView.Rows[rows].Cells[4].Value = "Invoiced";
                        InstallationDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Red;
                    }
                    else if (j == 1.ToString())
                    {
                        InstallationDataGridView.Rows[rows].Cells[4].Value = "Shipping";
                        InstallationDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Orange;
                    }
                    else if (j == 2.ToString())
                    {
                        InstallationDataGridView.Rows[rows].Cells[4].Value = "Shipped";
                        InstallationDataGridView.Rows[rows].Cells[4].Style.ForeColor = Color.Green;
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
            int InstallationID = Convert.ToInt32(cbo_InstallationID.SelectedValue);

            using (var context = new sdpEntities1())
            {
                var InstallationDB = from d in context.installation
                                     select d;

                foreach (var emp1 in InstallationDB.ToList())
                {
                    if (emp1.installationID == InstallationID)
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
            if (cbo_InstallationMan.Text == "")
            {
                MessageBox.Show("Please choose a installation staff!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int installationID = Convert.ToInt32(cbo_InstallationID.Text);
                int staffID = Convert.ToInt32(cbo_InstallationMan.Text);

                using (var context = new sdpEntities1())
                {
                    var installationDB = from list in context.installation
                                         select list;

                    var staffDB = from list in context.staff
                                  select list;

                    for (int i = 0; i < InstallationDataGridView.Rows.Count; i++)
                    {
                        if (InstallationDataGridView.Rows[i].Cells[0].Value.ToString() == cbo_InstallationID.Text)
                        {
                            if (InstallationDataGridView.Rows[i].Cells[3].Value.ToString() == "")
                            {
                                foreach (var emp1 in installationDB.ToList())
                                {
                                    foreach (var emp2 in staffDB.ToList())
                                    {
                                        if (emp1.installationID == installationID)
                                        {
                                            emp1.staffID = staffID;
                                            emp1.status = 1.ToString();
                                            emp1.installtionDate = DateTime.Now;
                                            context.SaveChanges();
                                            this.installationTableAdapter.Fill(this.sdpDataSet.installation);
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
            int installationID = Convert.ToInt32(cbo_InstallationID.Text);

            using (var context = new sdpEntities1())
            {
                var installationDB = from list in context.installation
                                       select list;

                foreach (var emp1 in installationDB.ToList())
                {
                    if (emp1.installationID == installationID)
                    {
                        emp1.status = 0.ToString();
                        emp1.staffID = null;
                        context.SaveChanges();
                        this.installationTableAdapter.Fill(this.sdpDataSet.installation);
                        refrashData();
                    }
                }
            }
        }

        private void deliveryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
