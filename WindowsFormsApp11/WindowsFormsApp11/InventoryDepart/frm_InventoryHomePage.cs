using SDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.InventoryDepart;
using WindowsFormsApp11.InventoryDepart.Restock_From_Supplier;
using WindowsFormsApp11.InventoryDepart.RestockSalesConfirm;
using WindowsFormsApp11.ITdepart.Account;
using WindowsFormsApp11.ITdepart.Staff;
using WindowsFormsApp11.LoginPage;

namespace WindowsFormsApp11
{
    public partial class frm_InventoryHomePage : Form
    {
        int mov;
        int movX;
        int movY;
        private Form activeForm = null;

        private String firstName, lastName, title, accessName, department;
        private int accessID;

        public frm_InventoryHomePage(String firstName, String lastName, String title, String accessName, int accessID, String department)
        {
            InitializeComponent();
            //OpenChildForm(new frm_Home());
            pnl_Nav.Height = btn_DeliveryManagement.Height;
            pnl_Nav.Top = btn_DeliveryManagement.Top;
            pnl_Nav.Left = btn_DeliveryManagement.Left;
            btn_DeliveryManagement.BackColor = Color.FromArgb(45, 50, 70);

            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
            this.accessName = accessName;
            this.accessID = accessID;
            this.department = department;
        }

        private void frm_IThomePage_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = firstName + " " + lastName;
            lbl_Department.Text = department + " Department";
            lbl_Title.Text = title;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_ChildForm.Controls.Add(childForm);
            this.pnl_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void UpdateNav(Button b)
        {
            pnl_Nav.Top = b.Top;
            pnl_Nav.Left = b.Left;
            b.BackColor = Color.FromArgb(45, 50, 70);
        }

        private void btu_DeliveryManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DeliveryManagement(accessID));

            UpdateNav(btn_DeliveryManagement); //Update Nav when click
        }

        private void btn_InstallationManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_InstallationManagement(accessID));

            UpdateNav(btn_InstallationManagement); //Update Nav when click
        }

        private void btn_restockControl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_RestockInventoryIndex());

            UpdateNav(btn_restockControl); //Update Nav when click
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Logout?","Confirm Logout",MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                frm_Login frm = new frm_Login();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }

            UpdateNav(btn_Logout); //Update Nav when click
        }

        private void btu_DeliveryManagement_Leave(object sender, EventArgs e)
        {
            btn_DeliveryManagement.BackColor = Color.FromArgb(25, 30, 50); //update Nav when leave
        }

        private void btn_InstallationManagement_Leave(object sender, EventArgs e)
        {
            btn_InstallationManagement.BackColor = Color.FromArgb(25, 30, 50); //update Nav when leave
        }

        private void btn_restockControl_Leave(object sender, EventArgs e)
        {
            btn_restockControl.BackColor = Color.FromArgb(25, 30, 50); //update Nav when leave
        }

        private void btn_Logout_Leave(object sender, EventArgs e)
        {
            btn_Logout.BackColor = Color.FromArgb(25, 30, 50); //update Nav when leave
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // close window
        }

        //when click on the bar activate updater and save x, y
        private void pnl_Move_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X + 209;
            movY = e.Y;
        }

        private void btn_CofirmSalesRestock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ConfirmRestockSales());

            UpdateNav(btn_CofirmSalesRestock); //Update Nav when click
        }

        private void btn_CofirmSalesRestock_Leave(object sender, EventArgs e)
        {
            btn_CofirmSalesRestock.BackColor = Color.FromArgb(25, 30, 50);
        }

        //when moving mouse update x and y
        private void pnl_Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        //when release mouse unactivate updater
        private void pnl_Move_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void pnl_ChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
