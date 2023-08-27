using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.ITdepart.Staff
{
    public partial class frmModifyStaff : Form
    {
        public frmModifyStaff()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frmModifyStaff_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.titles' 資料表。您可以視需要進行移動或移除。
            this.titlesTableAdapter.Fill(this.sdpDataSet.titles);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.sdpDataSet.department);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.sdpDataSet.staff);

        }

        private void btuModify_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && cboGender.Text != "")

            {
                using (var classicContext = new sdpEntities1())
                {
                    var staff = new staff();
                    var account = new account();

                    int id = Convert.ToInt32(cboStaffID.Text);

                    var result = classicContext.staff.Find(id);
                    if (result != null)
                    {
                        result.firstName = txtFirstName.Text;
                        result.lastName = txtLastName.Text;
                    }

                    if (cboGender.Text == "Male")
                    {
                        result.gender = "M";
                    }
                    else
                    {
                        result.gender = "F";
                    }

                    result.departID = Convert.ToInt32(cboDepart.SelectedValue);
                    result.titleID = Convert.ToInt32(cboTitle.SelectedValue);
                    classicContext.SaveChanges();
                    MessageBox.Show("Staff successfully modified!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }

            }
            else if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Please enter the name!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please choose a gender!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
