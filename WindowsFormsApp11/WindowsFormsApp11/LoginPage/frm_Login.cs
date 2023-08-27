using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11;
using WindowsFormsApp11.ITdepart;
using WindowsFormsApp11.LoginPage;

namespace SDP
{
    public partial class frm_Login : Form
    {

        private int empid;
        private string department;
        private string firstName;

        int mov;
        int movX;
        int movY;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool login_flag = false;
            if (!txt_StaffID.Text.Trim().Equals(""))
            {
                int empid = Convert.ToInt32(txt_StaffID.Text);
                this.empid = empid;
                int password = Convert.ToInt32(txt_PW.Text);

                //Checking data in database
                using (var classicContext = new sdpEntities1())
                {
                    var emp = (from list in classicContext.account select list);    // select * from employees

                    foreach (var emp2 in emp.ToList())
                    {
                        if (emp2.staffID == empid && emp2.password == password)
                        {
                            login_flag = true;
                            break;
                        }

                    }
                }
            }
            //Display result
            int departID = 0;
            int accessID = 0;
            String lastName = "";
            String title = "";
            String accessName = "";

            if (login_flag)

                using (var context = new sdpEntities1())
                {
                    var staff = from list in context.staff select list;
                    var titles = from list in context.titles select list;
                    var access = from list in context.access select list;
                    var departmentDB = from list in context.department select list;

                    foreach (var emp1 in staff.ToList())
                    {
                        if (emp1.staffID == empid)
                        {


                            departID = emp1.departID;
                            lastName = emp1.lastName;
                            firstName = emp1.firstName;
                            accessID = (int)emp1.accessID;
                            
                            foreach (var emp2 in titles.ToList())
                            {
                                if (emp1.titleID == emp2.titleID)
                                {
                                    title = emp2.title;
                                }
                            }

                            foreach (var emp3 in access.ToList())
                            {
                                if (emp1.accessID == emp3.AccessID)
                                {
                                    accessName = emp3.AccessName;
                                }
                            }

                            foreach (var emp4 in departmentDB.ToList())
                            {
                                if (emp1.departID == emp4.departID)
                                {
                                    department = emp4.departName;
                                }
                            }
                        }
                    }

                    switch (departID)
                    {
                        case 1:
                            OpenForm(new frm_SalesHomePage(firstName, lastName, title, accessName, accessID, department));
                            break;
                        case 2:
                            OpenForm(new frm_IThomePage(firstName, lastName, title, accessName, accessID, department));
                            break;
                        case 3:
                            OpenForm(new frm_InventoryHomePage(firstName, lastName, title, accessName, accessID, department));
                            break;
                        case 4:
                            OpenForm(new frm_TechnicalHomePage(firstName, lastName, title, accessName, accessID, department));
                            break;
                        case 5:
                            OpenForm(new frm_PurchaseHomePage(firstName, lastName, title, accessName, accessID, department));
                            break;
                        default:
                            MessageBox.Show("Your department not use PC to work.");
                            break;
                    }
                }
            else
                MessageBox.Show("Login failed");
        }
        private void OpenForm(Form frm)
        {
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void frm_forgotPassword_Click(object sender, EventArgs e)
        {
            frm_forgotPassword frm = new frm_forgotPassword();
            frm.ShowDialog();
        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Move_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            frm_changePassword frm = new frm_changePassword();
            frm.ShowDialog();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_PW.PasswordChar = '*';
        }
    }
}
