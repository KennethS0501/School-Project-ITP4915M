using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.InventoryDepart.Installation_Management;
using WindowsFormsApp11.InventoryDepart.Installation_Management.Daily_Installation_List_Generater;

namespace WindowsFormsApp11.InventoryDepart
{
    public partial class frm_InstallationManagement : Form
    {
        private int accessID;
        public frm_InstallationManagement(int accessID)
        {
            InitializeComponent();
            this.accessID = accessID;
        }

        private void btn_ArrangeDeliveryMan_Click(object sender, EventArgs e)
        {
            openForm(new frm_ArrangeInstallationService());
        }

        private void btn_UpdateDeliveryMan_Click(object sender, EventArgs e)
        {
            openForm(new frm_UpdateInstallation());
        }

        private void btn_TrackDeliveryService_Click(object sender, EventArgs e)
        {
            openForm(new frm_TrackInstallation());
        }

        private void openForm (Form frm)
        {
            frm.ShowDialog();
        }

        private void btn_DeliveryListGen_Click(object sender, EventArgs e)
        {
            openForm(new frm_InstallationListGen());
        }
    }
}
