using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.sdpDataSet.staff);
        }

        private void btuAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int staffID1 = Convert.ToInt32(cobSelectID.Text);
                int password2 = Convert.ToInt32(txtPassword.Text);
                using (var classicContext = new sdpEntities1())
                {
                    var emp2 = new account
                    {
                        staffID = staffID1,
                        password = password2
                    };

                    classicContext.account.Add(emp2);

                    classicContext.SaveChanges();

                }
                MessageBox.Show("An account is added!");
                this.Close();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input! Please try again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Account already exist!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mov;
        int movX;
        int movY;
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
    }
}
