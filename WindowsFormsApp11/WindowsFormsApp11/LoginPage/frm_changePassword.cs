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
    public partial class frm_changePassword : Form
    {
        int mov;
        int movX;
        int movY;

        public frm_changePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int staffID = Convert.ToInt32(txt_StaffID.Text);
            int oldPassword = Convert.ToInt32(txt_OldPassword.Text);
            int newPassword1 = Convert.ToInt32(txt_NewPassword1.Text);
            int newPassword2 = Convert.ToInt32(txt_NewPassword2.Text);

            using (var context = new sdpEntities1())
            {
                var account = (from list in context.account select list);

                foreach (var emp1 in account.ToList())
                {
                    if (emp1.staffID == staffID && emp1.password == oldPassword)
                    {
                        if(newPassword1 == newPassword2)
                        {
                            emp1.password = newPassword2;
                            context.SaveChanges();
                            MessageBox.Show("The password changed!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void frm_changePassword_Load(object sender, EventArgs e)
        {
            txt_OldPassword.PasswordChar = '*';
            txt_NewPassword1.PasswordChar = '*';
            txt_NewPassword2.PasswordChar = '*';
        }
    }
}
