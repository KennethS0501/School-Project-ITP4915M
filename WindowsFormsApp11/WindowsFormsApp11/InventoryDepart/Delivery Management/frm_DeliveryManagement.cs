using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.InventoryDepart.Delivery_Management;
using WindowsFormsApp11.InventoryDepart.Delivery_Management.Daily_Delivery_List_Generater;

namespace WindowsFormsApp11.InventoryDepart
{
    public partial class frm_DeliveryManagement : Form
    {
        private int accessID;
        public frm_DeliveryManagement(int accessID)
        {
            InitializeComponent();
            this.accessID = accessID;
        }

        private void btn_ArrangeDeliveryMan_Click(object sender, EventArgs e)
        {
            openForm(new frm_ArrangeDeliveryService());
        }

        private void btn_UpdateDeliveryMan_Click(object sender, EventArgs e)
        {
            openForm(new frm_UpdateDelivery());
        }

        private void btn_TrackDeliveryService_Click(object sender, EventArgs e)
        {
            openForm(new frm_TrackDelivery());
        }

        private void openForm (Form frm)
        {
            frm.ShowDialog();
        }

        private void btn_DeliveryListGen_Click(object sender, EventArgs e)
        {
            openForm(new frm_DeliveryListGen());
        }
    }
}
