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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf.draw;

namespace WindowsFormsApp11.SalesDepart.Sales_Order_Management.Checkout
{
    public partial class frm_Checkout : Form
    {
        int mov;
        int movX;
        int movY;
        int branch;
        double total;
        public List<int> INT_prodID = new List<int>();
        public List<int> INT_qty = new List<int>();
        public List<double> INT_price = new List<double>();
        public List<string> STRING_prodName = new List<string>();
        bool depositMode;



        public frm_Checkout(List<int> INT_prodID, List<int> INT_qty, double total, int branch, List<double> INT_price, List<string> STRING_prodName, bool depositMode)
        {
            InitializeComponent();
            this.INT_prodID = INT_prodID;
            this.INT_qty = INT_qty;
            this.total = total;
            this.branch = branch;
            this.INT_price = INT_price;
            this.STRING_prodName = STRING_prodName;
            this.depositMode = depositMode;
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

        private void frm_Checkout_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.productlist' 資料表。您可以視需要進行移動或移除。
            this.productlistTableAdapter.Fill(this.sdpDataSet.productlist);

            lbl_Total.Text = total.ToString();

            lbl_deposit.Hide();

            if (depositMode)
            {
                lbl_deposit.Show();
            }
        }

        private string address;
        private int phone;
        private int orderID;
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            using (var context = new sdpEntities1())
            {
                var order = new order();
                var customer = new customer();
                var delivery = new delivery();
                var installation = new installation();

                customer.Name = txt_CusName.Text;
                customer.phone = int.Parse(txt_CusPhone.Text);
                customer.AddDate = DateTime.Now;

                order.payDate = DateTime.Now;
                order.totalPrice = total;

                if (ckb_Other.Checked == true)
                {
                    order.method = "other";
                }
                else if (ckb_Cash.Checked == true)
                {
                    order.method = "cash";
                }

                //Delivery Add data
                if (cob_dMethod.Text != "Self_Service")
                {
                    if (cbo_DeliverySession.Text == "Morning (9:00am - 12:00nn)")
                    {
                        delivery.timeSession = "Morning";
                        installation.timeSession = "Morning";
                    }
                    else if (cbo_DeliverySession.Text == "Afternoon (1:00pm - 5:00pm)")
                    {
                        delivery.timeSession = "Afternoon";
                        installation.timeSession = "Afternoon";
                    }
                    else if (cbo_DeliverySession.Text == "Evening (6:00pm - 10:00pm)")
                    {
                        delivery.timeSession = "Evening";
                        installation.timeSession = "Evening";
                    }
                    delivery.date = dtp_dDate.Value;
                    customer.address = rxt_CusAddress.Text;

                    if (cob_dMethod.Text == "Local Shipping")
                    {
                        order.dMethod = "Local Shipping";
                    }
                    else if (cob_dMethod.Text == "Cross-border Shipping")
                    {
                        order.dMethod = "Cross-border Shipping";
                    }

                    if (!context.delivery.Any())
                    {
                        order.deliveryID = delivery.deliveryID  = 1;
                    }
                    else
                    {
                        order.deliveryID = delivery.deliveryID = context.delivery.Max(d => d.deliveryID) + 1;
                    }

                    delivery.status = 0.ToString();
                    context.delivery.Add(delivery);
                    

                    //Installation Add data
                    if (ckb_Install.Checked)
                    {
                        if (!context.installation.Any())
                        {
                            order.installationID = installation.installationID = 1;
                        }
                        else
                        {
                            order.installationID = installation.installationID = context.installation.Max(i => i.installationID) + 1;
                        }

                        installation.date = dtp_dDate.Value.AddHours(2);

                        context.installation.Add(installation);
                    }
                    //Installation Add data
                }
                else
                {
                    order.dMethod = "Self-Service";
                }

                if (depositMode)
                {
                    order.deposit = "1";
                } else
                {
                    order.deposit = "0";
                }

                //Receipt Add data
                List<receipt> rece = new List<receipt>();
                if (!context.receipt.Any())
                {
                    orderID = 1;
                }
                else
                {
                    orderID = context.receipt.Max(o => o.orderID) + 1;
                }
                for (int i = 0; i < INT_prodID.Count; i++)
                {
                    rece.Add(new receipt { orderID = orderID, productID = INT_prodID[i], qty = INT_qty[i], shopID = 1 });
                }
                //Receipt Add data

                order.Cancel = "0";

                dropRetailStoreStock();
                context.customer.Add(customer);
                context.order.Add(order);
                context.receipt.AddRange(rece);
                context.SaveChanges();
                generaterReceipt();
                this.Close();
                MessageBox.Show("Checkout Complete!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cob_dMethod_TextChanged(object sender, EventArgs e)
        {
            // setings when customer want to delivery the product themselves
            if (cob_dMethod.Text == "Local Shipping" || cob_dMethod.Text == "Border Shipping")
            {
                cbo_DeliverySession.Visible = true;
                lbl_DeliverySession.Visible = true;

                dtp_dDate.Visible = true;
                lbl_dDate.Visible = true;

                ckb_Install.Visible = true;
                lbl_Install.Visible = true;

                rxt_CusAddress.Visible = true;
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

                rxt_CusAddress.Visible = false;
                lbl_CusAddress.Visible = false;
            }
        }

        private void ckb_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Other.Checked == true)
            {
                ckb_Cash.Checked = false;
            }
        }

        private void ckb_Cash_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Cash.Checked == true)
            {
                ckb_Other.Checked = false;
            }
        }

        private void dropRetailStoreStock()
        {

            if (!depositMode)
            {
                using (var context = new sdpEntities1())
                {
                    for (int i = 0; i < INT_prodID.Count; i++)
                    {
                        var storeStock = context.retailstorestock.Find(INT_prodID[i], branch);

                        storeStock.qty -= INT_qty[i];
                        context.SaveChanges();
                    }
                }
            }
            //INT_prodID List
            //INT_qty List

        }

        private void generaterReceipt()
        {
            using (var context = new sdpEntities1())
            {
                var shopDetail = from r in context.retailstore
                                 where r.shopID == branch
                                 select new { r.address, r.phone };

                foreach (var emp1 in shopDetail.ToList())
                {
                    address = emp1.address;
                    phone = emp1.phone;
                }
            }

            Document doc = new Document();
            //copy the path where want to save the file
            //becare is / not \
            PdfWriter.GetInstance(doc, new FileStream("../../../../WindowsFormsApp11/Receipt/" + "OrderID" + Convert.ToString(orderID) + ".pdf", FileMode.Create));
            string chMingliu1FontPath = "c:\\windows\\fonts\\mingliu.ttc,1";
            BaseFont chBaseFont = BaseFont.CreateFont(chMingliu1FontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            // 設定文字(字型、字體大小、一般0/粗體1/斜體2)
            var header = new iTextSharp.text.Font(chBaseFont, 36, 1);
            var titleFont14pt = new iTextSharp.text.Font(chBaseFont, 14, 2);
            var pDescripText = new iTextSharp.text.Font(chBaseFont, 32, 1);
            var pDetailText = new iTextSharp.text.Font(chBaseFont, 29, 0);
            //設定段落的字體大小,文字內容,字型

            doc.Open();
            List<Paragraph> receiptGener = new List<Paragraph>();
            string star = "*******************************************************************************";

            receiptGener.Add(new Paragraph("Better Limited", header));
            receiptGener[0].Alignment = Element.ALIGN_CENTER;

            receiptGener.Add(new Paragraph("Address: " + address, titleFont14pt));
            receiptGener[1].Alignment = Element.ALIGN_CENTER;

            receiptGener.Add(new Paragraph("Telp: " + phone, titleFont14pt));
            receiptGener[2].Alignment = Element.ALIGN_CENTER;
            receiptGener[2].SpacingAfter = 10;

            receiptGener.Add(new Paragraph(star, titleFont14pt));
            receiptGener[3].Alignment = Element.ALIGN_CENTER;

            receiptGener.Add(new Paragraph("CASH RECEIPT OrderID: " + orderID.ToString(), titleFont14pt));
            receiptGener[4].Alignment = Element.ALIGN_CENTER;


            receiptGener.Add(new Paragraph(star, titleFont14pt));
            receiptGener[5].Alignment = Element.ALIGN_CENTER;

            //Product Description
            Chunk glue = new Chunk(new VerticalPositionMark());
            Paragraph pDescription = new Paragraph("Description", pDescripText);
            pDescription.Add(new Chunk(glue));
            pDescription.Add("Price      qty");

            List<Paragraph> pDetail = new List<Paragraph>();
            //Product Detail
            for (int i = 0; i < INT_prodID.Count; i++)
            {
                pDetail.Add(new Paragraph(STRING_prodName[i].ToString(), pDetailText));
                pDetail[i].Add(new Chunk(glue));
                pDetail[i].Add(INT_price[i].ToString() + "            " + INT_qty[i].ToString());
            }

            receiptGener.Add(new Paragraph(star, titleFont14pt));
            receiptGener[6].Alignment = Element.ALIGN_CENTER;

            receiptGener.Add(new Paragraph("Total: " + Convert.ToString(total) , titleFont14pt));
            receiptGener[7].Alignment = Element.ALIGN_CENTER;

            receiptGener.Add(new Paragraph(star, titleFont14pt));
            receiptGener[8].Alignment = Element.ALIGN_CENTER;

            receiptGener.Add(new Paragraph("THANK YOU", header));
            receiptGener[9].Alignment = Element.ALIGN_CENTER;


            for (int i = 0; i <= 5; i++)
            {
                doc.Add(receiptGener[i]);
            }

            doc.Add(pDescription);

            for(int i = 0; i < INT_prodID.Count; i++)
            {
                doc.Add(pDetail[i]);
            }

            doc.Add(receiptGener[6]);
            doc.Add(receiptGener[7]);
            doc.Add(receiptGener[8]);
            doc.Add(receiptGener[9]);


            //將段落加入表格
            doc.Close();
        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Checkout_Click(object sender, EventArgs e)
        {

        }

        private void txt_CusName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
