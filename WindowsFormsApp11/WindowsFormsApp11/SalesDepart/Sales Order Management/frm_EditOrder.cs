using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp11.SalesDepart.Sales_Order_Management
{
    public partial class frm_EditOrder : Form
    {
        int mov;
        int movX;
        int movY;
        bool install;
        string delivery;
        private int selected_OrderID;
        private MySqlConnection connection;
        public frm_EditOrder(int selected_OrderID)
        {
            InitializeComponent();
            this.selected_OrderID = selected_OrderID;
            connection = new MySqlConnection("SERVER=218.252.6.99;DATABASE=sdp;UID=labtop1;PASSWORD=5833628299qQ");
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_Move_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pnl_Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnl_Move_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        string selected_deliveryID;
        private void frm_EditOrder_Load(object sender, EventArgs e)
        {
            lbl_OrderID.Text = "Order ID : " + selected_OrderID;

            OpenConnection();
            MySqlCommand List1 = new MySqlCommand("Select customer.name, customer.address, customer.phone, sdp.order.deliveryID, sdp.order.installationID, order.dMethod from customer, sdp.order where customer.customerID = sdp.order.customerID AND SDP.order.orderID = " + selected_OrderID + " group by orderID", connection);
            MySqlCommand List2 = new MySqlCommand("Select timeSession, date from delivery, sdp.order where delivery.deliveryID = sdp.order.deliveryID AND SDP.order.orderID = " + selected_OrderID, connection);

            using (MySqlDataReader reader = List1.ExecuteReader())
            {
                if (reader.Read())
                {
                    selected_deliveryID = String.Format("{0}", reader["deliveryID"]);
                    txt_CusName.Text = String.Format("{0}", reader["name"]);
                    txt_CusPhone.Text = String.Format("{0}", reader["phone"]);

                    if (String.Format("{0}", reader["deliveryID"]) == "")
                    {
                        cbo_dMethod.SelectedText = "Self-Service";
                    }
                    else
                    {
                        txt_CusAddress.Text = String.Format("{0}", reader["address"]);
                        cbo_dMethod.SelectedText = String.Format("{0}", reader["dMethod"]);
                    }
                    if (String.Format("{0}", reader["installationID"]) == "")
                    {
                        ckb_Install.Checked = false;
                    }
                    else
                    {
                        ckb_Install.Checked = true;
                    }
                }
                install = ckb_Install.Checked;
                delivery = cbo_dMethod.Text;
            }

            using (MySqlDataReader reader = List2.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (String.Format("{0}", reader["timeSession"]) == "Morning")
                    {
                        cbo_DeliverySession.Text = "Morning (9:00am - 12:00nn)";
                    }
                    else if (String.Format("{0}", reader["timeSession"]) == "Afternoon")
                    {
                        cbo_DeliverySession.Text = "Afternoon (1:00pm - 5:00pm)";
                    }
                    else if (String.Format("{0}", reader["timeSession"]) == "Evening")
                    {
                        cbo_DeliverySession.Text = "Evening (6:00pm - 10:00pm)";
                    }

                    dtp_dDate.Text = String.Format("{0}", reader["date"]);
                }
            }

            CloseConnection();
        }

        private void cob_dMethod_TextChanged(object sender, EventArgs e)
        {
            if (cbo_dMethod.Text == "Local Shipping" || cbo_dMethod.Text == "Cross-border Shipping")
            {
                cbo_DeliverySession.Visible = true;
                lbl_DeliverySession.Visible = true;

                dtp_dDate.Visible = true;
                lbl_dDate.Visible = true;

                ckb_Install.Visible = true;
                lbl_Install.Visible = true;

                txt_CusAddress.Visible = true;
                lbl_CusAddress.Visible = true;

            }
            else
            {
                cbo_DeliverySession.Visible = false;
                lbl_DeliverySession.Visible = false;

                dtp_dDate.Visible = false;
                lbl_dDate.Visible = false;

                ckb_Install.Visible = false;
                lbl_Install.Visible = false;

                txt_CusAddress.Visible = false;
                lbl_CusAddress.Visible = false;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            int orderID = selected_OrderID;

            using (var context = new sdpEntities1())
            {
                var CustomerDB = (from o in context.order
                                  join c in context.customer on o.customerID equals c.customerID
                                  where o.orderID == orderID
                                  select new { o.orderID, c.customerID }).ToList();

                var deliveryDB = (from o in context.order
                                 join d in context.delivery on o.deliveryID equals d.deliveryID
                                 where o.orderID == orderID
                                 select new { o.orderID, d.deliveryID }).ToList();

                var installationDB = (from o in context.order
                                     join i in context.installation on o.installationID equals i.installationID
                                     where o.orderID == orderID
                                     select new { o.orderID, i.installationID }).ToList();

                int customerID = 0;
                int deliveryID = 0;
                int installationID = 0;

                foreach (var emp1 in CustomerDB)
                {
                    customerID = emp1.customerID;
                }

                foreach (var emp1 in deliveryDB)
                {
                    deliveryID = emp1.deliveryID;
                }

                foreach (var emp1 in installationDB)
                {
                    installationID = emp1.installationID;
                }

                string timeSession = "";

                if(cbo_DeliverySession.Text == "Morning")
                {
                    timeSession = "Morning";
                }
                else if (cbo_DeliverySession.Text ==  "Afternoon")
                {
                    timeSession = "Afternoon";
                }
                else if (cbo_DeliverySession.Text == "Evening")
                {
                    timeSession = "Evening";
                }

                var customerDetail = context.customer.Find(customerID);
                if (txt_CusName.Text == "")
                {
                    MessageBox.Show("The name cannot be null!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    customerDetail.Name = txt_CusName.Text; //No null
                }

                if (txt_CusPhone.Text == "")
                {
                    MessageBox.Show("The phone cannot be null!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    customerDetail.phone = Convert.ToInt32(txt_CusPhone.Text); //No null
                }

                if (cbo_dMethod.Text == "Self_Service") //不要Delivery服務
                {
                    if(deliveryID != 0) //如果有資料
                    {
                        //delete Delivery Method
                        var deleteDmethod = context.order.Find(orderID);
                        deleteDmethod.dMethod = "Self_Service";

                        //delete Delivery ID, Delivery Session, Delivery Date, Installtion
                        var delivery = new delivery { deliveryID = Convert.ToInt32(deliveryID) };
                        context.delivery.Attach(delivery);
                        context.delivery.Remove(delivery);
                    }

                    if (installationID != 0)
                    {
                        //delete installtionID
                        var installation = new installation { installationID = Convert.ToInt32(installationID) };
                        context.installation.Attach(installation);
                        context.installation.Remove(installation);
                    }
                }

                if (cbo_dMethod.Text != "Self_Service") //要Delivery服務
                {
                    if(cbo_dMethod.Text == "Local Shipping")
                    {
                        var addDmethod = context.order.Find(orderID);
                        addDmethod.dMethod = "Local Shipping";
                    }
                    else
                    {
                        var addDmethod = context.order.Find(orderID);
                        addDmethod.dMethod = "Cross-border Shipping";
                    }

                    if (deliveryID == 0) //如果沒有Delivery資料 新增
                    {
                        var deliveryAdd = new delivery();
                        var addressAdd = context.customer.Find(customerID);
                        var orderDeliveryIDAdd = context.order.Find(orderID);
                        if (!context.delivery.Any())
                        {
                            orderDeliveryIDAdd.deliveryID  = deliveryAdd.deliveryID = 1;
                            deliveryAdd.timeSession = timeSession;
                            deliveryAdd.date = dtp_dDate.Value;
                            deliveryAdd.status = 0.ToString();
                            context.delivery.Add(deliveryAdd);

                        }
                        else
                        {
                            orderDeliveryIDAdd.deliveryID = deliveryAdd.deliveryID = context.delivery.Max(d => d.deliveryID) + 1;
                            deliveryAdd.timeSession = timeSession;
                            deliveryAdd.date = dtp_dDate.Value;
                            deliveryAdd.status = 0.ToString();
                            context.delivery.Add(deliveryAdd);
                        }

                        //customerID check out時必需輸入 更改那行的Address即可
                        addressAdd.address = txt_CusAddress.Text;
                        
                    }
                    else //如果有Delivery資料 更改
                    {
                        var deliveryModify = context.delivery.Find(deliveryID);
                        deliveryModify.timeSession = timeSession;
                        deliveryModify.date = dtp_dDate.Value;
                        deliveryModify.status = 0.ToString();

                        var addressModify = context.customer.Find(customerID);
                        addressModify.address = txt_CusAddress.Text;
                    }

                    var orderInstallationIDAdd = context.order.Find(orderID);
                    if (ckb_Install.Checked && installationID == 0) //如果要Install 並且 沒有資料
                    {
                        //新增Installation row
                        var installation = new installation();
                        orderInstallationIDAdd.installationID = installation.installationID = 1;
                        installation.date = dtp_dDate.Value;
                        context.installation.Add(installation);
                    }
                    else if(!ckb_Install.Checked && installationID != 0)//如果不要Install 並且 有資料
                    {
                        //delete installtion row
                        var installation = new installation { installationID = Convert.ToInt32(installationID) };
                        context.installation.Attach(installation);
                        context.installation.Remove(installation);
                    }

                }

                MessageBox.Show("Edit Successfully!", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                context.SaveChanges();
                this.Close();
            }



            /*OpenConnection();
            string deliveryID, session = "";
            if (delivery == "Self-Service" && delivery != cob_dMethod.Text)
            {
                using (var context = new sdpEntities1())
                {
                    if (context.delivery.Any())
                    {
                        deliveryID = (context.delivery.Max(i => i.deliveryID) + 1).ToString();
                    }
                    else
                    {
                        deliveryID = 1.ToString();
                    }
                }
                if (cbo_DeliverySession.Text == "Morning (9:00am - 12:00nn)")
                {
                    session = "Morning";
                }
                else if (cbo_DeliverySession.Text == "Afternoon (1:00pm - 5:00pm)")
                {
                    session = "Afternoon";
                }
                else if (cbo_DeliverySession.Text == "Evening (6:00pm - 10:00pm)")
                {
                    session = "Evening";
                }

                MySqlCommand addDelivery = new MySqlCommand("INSERT INTO delivery VALUES (" + deliveryID + ", " + DateTime.Now.ToString() + ", '" + session + "', NULL, NULL, NULL); " +
                    "UPDATE sdp.order SET deliveryID = " + deliveryID + " WHERE orderID = " + selected_OrderID, connection);
                addDelivery.ExecuteReader();
            }
            else if (delivery != "Self-Service" && cob_dMethod.Text == "Self-Service")
            {
                using (var content = new sdpEntities1())
                {
                    var delivery = from d in content.delivery
                                   join o in content.order on d.deliveryID equals o.deliveryID
                                   where o.orderID == int.Parse(selected_OrderID)
                                   select new { d.deliveryID };
                    deliveryID = delivery.ToString();
                }

                MySqlCommand deleteDelivery = new MySqlCommand("DELETE from delivery WHERE deliveryID = " + deliveryID +
                    "UPDATE delivery SET deliveryID = " + null + " WHERE deliveryID = " + deliveryID, connection);
                deleteDelivery.ExecuteReader();

                cbo_DeliverySession.Text = "";
                dtp_dDate.Text = "";
                ckb_Install.Checked = false;
                rxt_CusAddress.Text = "";
            }

            string installationID;
            if (ckb_Install.Checked != install && install == false)
            {
                using (var context = new sdpEntities1())
                {
                    if (context.installation.Any())
                    {
                        installationID = (context.installation.Max(i => i.installationID) + 1).ToString();
                    }
                    else
                    {
                        installationID = 1.ToString();
                    }
                }

                MySqlCommand addInstall = new MySqlCommand("INSERT INTO installation VALUES (" + installationID + ", " + DateTime.Now + ", NULL, NULL);" +
                    "UPDATE sdp.order SET installationID = " + installationID + " WHERE orderID = " + selected_OrderID, connection);
                addInstall.ExecuteReader();
            }

            else if (ckb_Install.Checked != install && install == true)
            {
                using (var content = new sdpEntities1())
                {
                    var installation = from i in content.installation
                                       join o in content.order on i.installationID equals o.installationID
                                       where o.orderID == int.Parse(selected_OrderID)
                                       select new { i.installationID };
                    installationID = installation.ToString();
                }

                MySqlCommand deleteInstall = new MySqlCommand("DELETE from installation WHERE installationID = " + installationID +
                    "UPDATE installation SET installationID = " + null + " WHERE installationID = " + installationID, connection);
                deleteInstall.ExecuteReader();
            }

            MySqlCommand update = new MySqlCommand("UPDATE sdp.order SET dMethod = '" + cob_dMethod.Text + "' WHERE orderID = " + selected_OrderID +
            ";UPDATE customer SET name = '" + txt_CusName.Text + "', address = '" + rxt_CusAddress.Text + "', phone = " + txt_CusPhone.Text + " WHERE customerID = " + selected_OrderID +
            ";UPDATE sdp.delivery d INNER JOIN sdp.order o on o.deliveryID = d.deliveryID SET d.timesession = '" + cbo_DeliverySession.Text + "', date = " + dtp_dDate.Value + " WHERE o.orderID = " + selected_deliveryID, connection);
            update.ExecuteReader();
            
            CloseConnection();

            this.Close();*/
        }
    }
}
