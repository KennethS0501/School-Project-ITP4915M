using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.SalesDepart;
using WindowsFormsApp11.SalesDepart.Sales_Order_Management.Checkout;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp11.SalesDepart.Sales_Order_Management
{
    public partial class frm_SalesOrder : Form
    {
        int value;
        int item_Count = 0;
        private string selected_OrderID;
        private MySqlConnection connection;
        private List<Label> itemNoList = new List<Label>();
        private List<Label> prodIDList = new List<Label>();
        private List<Label> prodNameList = new List<Label>();
        private List<NumericUpDown> qtyList = new List<NumericUpDown>();
        public List<int> INT_prodID = new List<int>();
        public List<int> INT_qty = new List<int>();
        public List<double> INT_price = new List<double>();
        public List<string> STRING_prodName = new List<string>();

        private List<string> str_prodName = new List<string>();
        private DataTable dbTable1 = new DataTable();
        private DataTable dbTable2 = new DataTable();
        MySqlDataReader reader1;
        MySqlDataReader reader2;

        public void Add_Item()
        {

            using (var context = new sdpEntities1())
            {
                Boolean productExist = false;
                int shopID = Convert.ToInt32(cob_Branch.SelectedValue);

                var productList = from p in context.retailstorestock
                                  where p.shopID == shopID
                                  select p;

                var productNull = context.retailstorestock.Find(Convert.ToInt32(txt_prodID.Text), shopID);
  
                if (productNull == null)
                {
                    MessageBox.Show("The Product ID is wrong", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (item_Count > 0)
                {
                    for (int i = 0; i < item_Count; i++)
                    {
                        if (prodIDList[i].Text == txt_prodID.Text)
                        {
                            MessageBox.Show("The Product already exist!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            productExist = true;
                        }
                    }
                }

                if (productNull != null && productExist == false)
                {
                    // item number settings
                    itemNoList.Add(new Label());
                    pnl_Item.Controls.Add(itemNoList[item_Count]);
                    itemNoList[item_Count].Name = "lbl_Num" + item_Count;
                    itemNoList[item_Count].Text = (item_Count + 1).ToString();
                    itemNoList[item_Count].Size = new Size(46, 15);
                    itemNoList[item_Count].AutoSize = false;
                    itemNoList[item_Count].Font = new Font("Arial", 9);
                    itemNoList[item_Count].Location = new Point(11, 36 + (25 * (item_Count)) + pnl_Item.AutoScrollPosition.Y);
                    itemNoList[item_Count].TextAlign = ContentAlignment.MiddleCenter;

                    // product ID settings
                    prodIDList.Add(new Label());
                    pnl_Item.Controls.Add(prodIDList[item_Count]);
                    prodIDList[item_Count].Name = "lbl_ProdID" + item_Count;
                    prodIDList[item_Count].Text = txt_prodID.Text;
                    prodIDList[item_Count].AutoSize = false;
                    prodIDList[item_Count].Size = new Size(62, 15);
                    prodIDList[item_Count].Location = new Point(75, 33 + (25 * (item_Count)) + pnl_Item.AutoScrollPosition.Y);
                    prodIDList[item_Count].Font = new Font("Arial", 9);

                    // product Name settings
                    OpenConnection();
                    MySqlCommand command = new MySqlCommand("SELECT name FROM productlist WHERE productID = " + txt_prodID.Text, connection);
                    prodNameList.Add(new Label());
                    pnl_Item.Controls.Add(prodNameList[item_Count]);
                    prodNameList[item_Count].Name = "lbl_ProdName" + item_Count;
                    prodNameList[item_Count].Text = (string)command.ExecuteScalar();
                    prodNameList[item_Count].AutoSize = false;
                    prodNameList[item_Count].Size = new Size(374, 15);
                    prodNameList[item_Count].Location = new Point(156, 33 + (25 * (item_Count)) + pnl_Item.AutoScrollPosition.Y);
                    prodNameList[item_Count].Font = new Font("Arial", 9);
                    CloseConnection();

                    // qty settings
                    qtyList.Add(new NumericUpDown());
                    pnl_Item.Controls.Add(qtyList[item_Count]);
                    qtyList[item_Count].Name = "nud_qty" + item_Count;
                    qtyList[item_Count].Text = "1";
                    qtyList[item_Count].AutoSize = false;
                    qtyList[item_Count].Size = new Size(38, 21);
                    qtyList[item_Count].Location = new Point(969, 33 + (25 * (item_Count)) + pnl_Item.AutoScrollPosition.Y);
                    qtyList[item_Count].Font = new Font("Arial", 9);

                    item_Count++;
                }
            }
        }

        int accessID;
        private bool accessCheck(int accessName)
        {
            using (var context = new sdpEntities1())
            {
                var result = context.access.Find(accessID);
                
                //accessName 1 = Edit Order
                //accessName 2 = Cancel Order
                
                if (accessName == 1 && result.EditOrder == 1)
                {
                    return true;
                }
                else if (accessName == 2 && result.CancelOrder == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public frm_SalesOrder(int accessID)
        {
            InitializeComponent();
            this.accessID = accessID;


            connection = new MySqlConnection("SERVER=218.252.6.99;DATABASE=sdp;UID=labtop1;PASSWORD=5833628299qQ");
            MySqlCommand command = new MySqlCommand("select name from productlist", connection);

            OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i <= reader.FieldCount - 1; i++)
                {
                    str_prodName.Add(reader.GetString(i));
                }
            }

            CloseConnection();
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Please contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            double total = 0;
            int branch = 0;
            bool depositMode = false;
            string noStockProductString = "";
            bool qtyInput = true;

            try
            {
                branch = Convert.ToInt32(cob_Branch.SelectedValue);

                if (item_Count != 0)
                {
                    using (var database = new sdpEntities1())
                    {
                        var order = new order();

                        for (int i = 0; i < item_Count; i++)
                        {
                            if (Convert.ToInt32(qtyList[i].Text) == 0)
                            {
                                qtyInput = false;
                                MessageBox.Show("The qty cannot be 0 or less than 0!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                qtyInput = true;
                            }
                        }

                        if (qtyInput == true)
                        {
                            for (int i = 0; i < item_Count; i++)
                            {
                                INT_prodID.Add(int.Parse(prodIDList[i].Text));
                                INT_qty.Add(int.Parse(qtyList[i].Text));

                                var product = from p in database.productlist
                                                   select p;

                                var retailProduct = from r in database.retailstorestock
                                                    select r;

                                foreach (var p in product.ToList()) //Total price
                                {
                                    if (INT_prodID[i] == p.productID)
                                    {
                                        total += p.price * INT_qty[i];
                                        INT_price.Add(p.price);
                                        STRING_prodName.Add(p.name);
                                    }
                                }

                                foreach (var r in retailProduct.ToList())
                                {
                                    if (r.shopID == branch && INT_prodID[i] == r.RproductID)
                                    {
                                        if (INT_qty[i] > r.qty) //如果沒有貨
                                        {
                                            noStockProductString += "Item No: " + (i+1).ToString() + "\n";
                                            depositMode = true;
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                }

                if (qtyInput == true)
                {
                    if (prodIDList.Count == 0)
                    {
                        MessageBox.Show("The list is empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } 
                    else if (!depositMode && prodIDList.Count != 0)
                    {
                        frm_Checkout frm = new frm_Checkout(INT_prodID, INT_qty, total, branch, INT_price, STRING_prodName, depositMode);
                        frm.ShowDialog();

                        INT_prodID.Clear();
                        INT_qty.Clear();
                    }
                    else //false
                    {
                        string message = "Following list product does not have stock\nAsk customer want to deposit service\n" + noStockProductString;
                        string title = "Some product does not have stock";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            frm_Checkout frm = new frm_Checkout(INT_prodID, INT_qty, total, branch, INT_price, STRING_prodName, depositMode);
                            frm.ShowDialog();
                        }

                        INT_prodID.Clear();
                        INT_qty.Clear();
                    }
                }

                
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (item_Count > 0)
                {
                    //remove prodID
                    pnl_Item.Controls.Remove(itemNoList[item_Count - 1]);
                    itemNoList.RemoveAt(itemNoList.Count - 1);

                    // remove item number
                    pnl_Item.Controls.Remove(prodIDList[item_Count - 1]);
                    prodIDList.RemoveAt(prodIDList.Count - 1);

                    //remove prodName
                    pnl_Item.Controls.Remove(prodNameList[item_Count - 1]);
                    prodNameList.RemoveAt(prodNameList.Count - 1);

                    //remove qty
                    pnl_Item.Controls.Remove(qtyList[item_Count - 1]);
                    qtyList.RemoveAt(qtyList.Count - 1);

                    --item_Count;


                    INT_prodID.RemoveAt(INT_prodID.Count - 1);
                    INT_qty.RemoveAt(INT_qty.Count - 1);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txt_prodID.Text.Equals("") && int.TryParse(txt_prodID.Text, out value))
                {
                    Add_Item();
                }
                else if (txt_prodID.Text.Equals(""))
                {
                    MessageBox.Show("Please enter product ID");
                }
                else
                {
                    MessageBox.Show("Invalid product ID");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void frm_SalesOrder_Load_1(object sender, EventArgs e)
        {

            // TODO: 這行程式碼會將資料載入 'sdpDataSet.customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter.Fill(this.sdpDataSet.customer);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.receipt' 資料表。您可以視需要進行移動或移除。
            this.receiptTableAdapter.Fill(this.sdpDataSet.receipt);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.retailstore' 資料表。您可以視需要進行移動或移除。
            this.retailstoreTableAdapter.Fill(this.sdpDataSet.retailstore);

            OpenConnection();
            MySqlCommand getTable = new MySqlCommand("Select distinct sdp.order.orderID as 'Order ID', customer.name as 'Customer Name', sdp.order.method as 'Payment Method', sdp.order.totalPrice as 'Total Price', sdp.order.dMethod as 'Delivery Method', sdp.order.payDate as 'Create Date' from customer, sdp.order where customer.customerID = sdp.order.customerID AND sdp.order.Cancel = 0 group by orderID", connection);

            reader1 = getTable.ExecuteReader();
            dbTable1.Load(reader1);
            dgv_Order.DataSource = dbTable1;

            MySqlCommand getDesopitTable = new MySqlCommand("Select distinct sdp.order.orderID as 'Order ID', customer.name as 'Customer Name', sdp.order.method as 'Payment Method', sdp.order.totalPrice as 'Total Price', sdp.order.dMethod as 'Delivery Method', sdp.order.payDate as 'Create Date' from customer, sdp.order where customer.customerID = sdp.order.customerID AND sdp.order.deposit = 1 AND sdp.order.Cancel = 0 group by orderID", connection);

            reader2 = getDesopitTable.ExecuteReader();
            dbTable2.Load(reader2);
            dgv_depositOrder.DataSource = dbTable2;

            CloseConnection();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetProductList();
        }

        private void resetProductList()
        {
            for (int i = item_Count - 1; i >= 0; i--)
            {
                //remove prodID
                pnl_Item.Controls.Remove(itemNoList[i]);
                itemNoList.RemoveAt(itemNoList.Count - 1);

                // remove item number
                pnl_Item.Controls.Remove(prodIDList[i]);
                prodIDList.RemoveAt(prodIDList.Count - 1);

                //remove prodName
                pnl_Item.Controls.Remove(prodNameList[i]);
                prodNameList.RemoveAt(prodNameList.Count - 1);

                //remove qty
                pnl_Item.Controls.Remove(qtyList[i]);
                qtyList.RemoveAt(qtyList.Count - 1);

                item_Count = 0;
            }
            INT_prodID.Clear();
            INT_qty.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchIDValue = txt_SearchID.Text;
            string searchNameValue = txt_SearchName.Text;
            bool numericInput = true;
            bool nameInput = true;

            dgv_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                if (int.TryParse(searchIDValue, out int result) == false && searchIDValue != "")
                {
                    MessageBox.Show("Please enter a number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    numericInput = false;
                } else if (int.TryParse(searchNameValue, out int result2) == true && searchNameValue != "")
                {
                    MessageBox.Show("Please enter a name!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nameInput = false;
                }

                if (numericInput == true && nameInput == true)
                {
                    foreach (DataGridViewRow row in dgv_Order.Rows)
                    {

                        row.Selected = false;

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (txt_SearchID.Text != null)
                            {
                                if (row.Cells[i].Value.ToString().Equals(searchIDValue))
                                {
                                    selected_OrderID = row.Cells[i].Value.ToString();
                                    row.Selected = true;
                                    break;
                                }
                            }


                            if (txt_SearchName.Text != null)
                            {
                                if (row.Cells[i].Value.ToString().Equals(searchNameValue))
                                {
                                    selected_OrderID = row.Cells[i].Value.ToString();
                                    row.Selected = true;
                                    break;
                                }
                            }

                        }
                    }
                    txt_SearchID.Text = "";
                    txt_SearchName.Text = "";
                    }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)

        {
            if (accessCheck(1))
            {
                selected_OrderID = (dgv_Order.CurrentCell.RowIndex).ToString();
            	//row = 0
            	string orderIDStr = dgv_Order.Rows[Convert.ToInt32(selected_OrderID)].Cells[0].Value.ToString();
            	int orderID = Convert.ToInt32(orderIDStr);
            
                frm_EditOrder frm = new frm_EditOrder(Convert.ToInt32(orderID));
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You does not have access to use!");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ((DataTable)dgv_Order.DataSource).Rows.Clear();
            
            OpenConnection();
            MySqlCommand getTable = new MySqlCommand("Select distinct sdp.order.orderID as 'Order ID', customer.name as 'Customer Name', sdp.order.method as 'Payment Method', sdp.order.totalPrice as 'Total Price', sdp.order.dMethod as 'Delivery Method', sdp.order.payDate as 'Create Date' from customer, sdp.order where customer.customerID = sdp.order.customerID AND sdp.order.Cancel = 0 group by orderID", connection);

            reader1 = getTable.ExecuteReader();
            dbTable1.Load(reader1);
            dgv_Order.DataSource = dbTable1;

            CloseConnection();
        }

        private void dgv_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btn_DepositRefresh_Click(object sender, EventArgs e)
        {
            ((DataTable)dgv_depositOrder.DataSource).Rows.Clear();
            OpenConnection();

            MySqlCommand getDesopitTable = new MySqlCommand("Select distinct sdp.order.orderID as 'Order ID', customer.name as 'Customer Name', sdp.order.method as 'Payment Method', sdp.order.totalPrice as 'Total Price', sdp.order.dMethod as 'Delivery Method', sdp.order.payDate as 'Create Date' from customer, sdp.order where customer.customerID = sdp.order.customerID AND sdp.order.deposit = 1 AND sdp.order.Cancel = 0 group by orderID", connection);

            reader2 = getDesopitTable.ExecuteReader();
            dbTable2.Load(reader2);
            dgv_depositOrder.DataSource = dbTable2;

            CloseConnection();
        }

        private void btn_DepositSearch_Click(object sender, EventArgs e)
        {
            string searchIDValue = txt_SearchDepositID.Text;
            string searchNameValue = txt_SearchDepositName.Text;
            bool numericInput = true;
            bool nameInput = true;

            dgv_depositOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                if (int.TryParse(searchIDValue, out int result) == false && searchIDValue != "")
                {
                    MessageBox.Show("Please enter a number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    numericInput = false;
                }
                else if (int.TryParse(searchNameValue, out int result2) == true && searchNameValue != "")
                {
                    MessageBox.Show("Please enter a name!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nameInput = false;
                }

                if (numericInput == true && nameInput == true)
                {
                    foreach (DataGridViewRow row in dgv_depositOrder.Rows)
                    {

                        row.Selected = false;

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (txt_SearchDepositID.Text != "")
                            {
                                if (row.Cells[i].Value.ToString().Equals(searchIDValue))
                                {
                                    selected_OrderID = row.Cells[i].Value.ToString();
                                    row.Selected = true;
                                    break;
                                }
                            }

                            if (txt_SearchDepositName.Text != "")
                            {
                                if (row.Cells[i].Value.ToString().Equals(searchNameValue))
                                {
                                    selected_OrderID = row.Cells[i].Value.ToString();
                                    row.Selected = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_purchaseFinish_Click(object sender, EventArgs e)
        {
            selected_OrderID = (dgv_depositOrder.CurrentCell.RowIndex).ToString();
            //row = 0
            string orderIDStr = dgv_depositOrder.Rows[Convert.ToInt32(selected_OrderID)].Cells[0].Value.ToString();
            int orderID = Convert.ToInt32(orderIDStr);


            int shopID = 0;
            List<string> productID = new List<string>();
            List<string> productQty = new List<string>();

            using (var database = new sdpEntities1())
            {
                var orderDB = from o in database.order
                              select o;

                var receipt = from r in database.receipt
                              select r;

                var retailStock = from r in database.retailstorestock
                                  select r;

                foreach (var o in orderDB.ToList())
                {
                    if (o.orderID == orderID)
                    {
                        o.deposit = "0";
                    }
                }

                foreach (var r in receipt.ToList())
                {
                    if (r.orderID == orderID)
                    {
                        shopID = r.shopID;
                        productID.Add(r.productID.ToString());
                        productQty.Add(r.qty.ToString());

                    }
                }

                for (int i = 0; i < productID.Count; i++)
                {
                    foreach(var r in retailStock.ToList())
                    {
                        if(r.RproductID == Convert.ToInt32(productID[i]) && r.shopID == shopID)
                        {
                            r.qty -= Convert.ToInt32(productQty[i]);
                        }
                    }
                }


                database.SaveChanges();
            }

            MessageBox.Show("The order is finish now.");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (accessCheck(2))
            {
                selected_OrderID = (dgv_Order.CurrentCell.RowIndex).ToString();
                //row = 0
                string orderIDStr = dgv_Order.Rows[Convert.ToInt32(selected_OrderID)].Cells[0].Value.ToString();
                int orderID = Convert.ToInt32(orderIDStr);

                using (var database = new sdpEntities1())
                {
                    var orderDB = from o in database.order
                                  select o;

                    foreach (var o in orderDB.ToList())
                    {
                        if (o.orderID == orderID)
                        {
                            o.Cancel = "1";
                        }
                    }
                    database.SaveChanges();
                }

                MessageBox.Show("Cancel complete");
            }
            else
            {
                MessageBox.Show("You does not have access to use!");
            }


        }

        private void btu_defectItem_Click(object sender, EventArgs e)
        {
            selected_OrderID = (dgv_Order.CurrentCell.RowIndex).ToString();
            //row = 0
            string orderIDStr = dgv_Order.Rows[Convert.ToInt32(selected_OrderID)].Cells[0].Value.ToString();
            int orderID = Convert.ToInt32(orderIDStr);

            int shopID = 0;
            List<string> productID = new List<string>();
            List<string> productQty = new List<string>();

            using (var database = new sdpEntities1())
            {
                var orderDB = from o in database.order
                              select o;

                var deliveryDB = from d in database.delivery
                                 select d;

                var installationDB = from i in database.installation
                                     select i;

                var receipt = from r in database.receipt
                              select r;

                var retailStock = from r in database.retailstorestock
                                  select r;

                int deliveryID = 0;
                int installationID = 0;

                foreach (var o in orderDB.ToList())
                {
                    if (o.orderID == orderID)
                    {
                        deliveryID = Convert.ToInt32(o.deliveryID);
                        installationID = Convert.ToInt32(o.installationID);
                    }
                }

                if (deliveryID != 0)
                {
                    foreach (var d in deliveryDB.ToList())
                    {
                        if(deliveryID == d.deliveryID)
                        {
                            d.status = "0";
                        }
                    }
                }

                if (installationID != 0)
                {
                    foreach (var i in installationDB.ToList())
                    {
                        if (installationID == i.installationID)
                        {
                            i.status = "0";
                        }
                    }
                }

                foreach (var r in receipt.ToList())
                {
                    if (r.orderID == orderID)
                    {
                        shopID = r.shopID;
                        productID.Add(r.productID.ToString());
                        productQty.Add(r.qty.ToString());

                    }
                }

                for (int i = 0; i < productID.Count; i++)
                {
                    foreach (var r in retailStock.ToList())
                    {
                        if (r.RproductID == Convert.ToInt32(productID[i]) && r.shopID == shopID)
                        {
                            r.qty -= Convert.ToInt32(productQty[i]);
                        }
                    }
                }

                database.SaveChanges();
            }

            MessageBox.Show("Handle defect item complete");
        }

        private void txt_SearchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prodID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
