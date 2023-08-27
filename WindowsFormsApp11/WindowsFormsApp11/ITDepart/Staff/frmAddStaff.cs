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
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private bool CheckValidEmpNum(int staffID)
        {
            bool result = false;
            using (var classicContext = new sdpEntities1())
            {
                var emp = (from list in classicContext.staff select list);    // select * from employees

                foreach (var emp2 in emp.ToList())
                {
                    if (emp2.staffID == staffID)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        private bool CheckEmpty()
        {
            bool result = false;

            using (var context = new sdpEntities1())
            {
                var emp = from list in context.staff select list;

                foreach (var emp2 in emp.ToList())
                {
                    if(emp2 != null)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }


        private void InsertRecord()
        {
            int rowsAffected = 0;
            using (var classicContext = new sdpEntities1())
            {
                var staff = new staff();
                var account = new account();
                bool isNull = false;

                if (txtFirstName.Text != "" && txtLastName.Text != "")
                {
                    staff.firstName = txtFirstName.Text;
                    staff.lastName = txtLastName.Text;
                    staff.staffID = Convert.ToInt32(txtStaffID.Text);
                    account.staffID = Convert.ToInt32(txtStaffID.Text);

                    staff.birthDate = dateBirth.Value;
                    staff.hireDate = dateHire.Value;

                    if (cobGender.Text == "Male")
                    {
                        staff.gender = "M";
                    }
                    else
                    {
                        staff.gender = "F";
                    }

                    staff.departID = Convert.ToInt32(cobDepart.SelectedValue);
                    staff.titleID = Convert.ToInt32(cobTitle.SelectedValue);

                    classicContext.staff.Add(staff);
                    classicContext.account.Add(account);
                    classicContext.SaveChanges();
                    MessageBox.Show("Staff successfully added!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the name!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!CheckValidEmpNum(Convert.ToInt32(txtStaffID.Text)))
            {
                InsertRecord();
            }
            else
                MessageBox.Show(txtStaffID.Text + " is duplicated.");
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.titles' 資料表。您可以視需要進行移動或移除。
            this.titlesTableAdapter.Fill(this.sdpDataSet.titles);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.sdpDataSet.department);



            // TODO: 這行程式碼會將資料載入 'sdpDataSet.staff' 資料表。您可以視需要進行移動或移除。
            using (var classicContext = new sdpEntities1()) 
            {
                
                if (CheckEmpty())
                {
                    int maxID = classicContext.staff.Max(p => p.staffID) + 1;
                    txtStaffID.Text = maxID.ToString();
                    
                } else
                {
                    txtStaffID.Text = "1";
                }


            }
        }
    }
}
