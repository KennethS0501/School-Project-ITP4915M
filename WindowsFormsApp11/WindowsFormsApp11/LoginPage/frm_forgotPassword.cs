using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.LoginPage
{
    public partial class frm_forgotPassword : Form
    {
        int mov;
        int movX;
        int movY;

        public frm_forgotPassword()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            String lastName = txt_LastName.Text;
            DateTime birthDate = date_birth.Value;
            DateTime hireDate = date_hire.Value;
            bool correctInfo = false;

            using (var context = new sdpEntities1())
            {
                var staff = (from list in context.staff select list);

                if (lastName != "")
                {
                    foreach (var emp2 in staff.ToList())
                    {
                        if (emp2.lastName == lastName && emp2.birthDate == birthDate && emp2.hireDate == hireDate)
                        {
                            var password = from list in context.account select list;

                            foreach (var emp3 in password.ToList())
                            {
                                if (emp2.staffID == emp3.staffID)
                                {
                                    MessageBox.Show("Your staff id is " + emp2.staffID + "\nYour password is " + emp3.password);
                                    correctInfo = true;
                                }
                                
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Some detail is missing");
                }

                if (correctInfo == false)
                {
                    MessageBox.Show("The information is wrong! Please try again.", "Wrong Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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

        private void frm_forgotPassword_Load(object sender, EventArgs e)
        {
            
        }
    }
}
