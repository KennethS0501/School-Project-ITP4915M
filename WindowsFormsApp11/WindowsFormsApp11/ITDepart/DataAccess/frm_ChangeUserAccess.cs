using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.ITdepart.DataAccess
{
    public partial class frmChangeUserAccess : Form
    {
        public frmChangeUserAccess()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void staffBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void frmChangeUserAccess_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.access' 資料表。您可以視需要進行移動或移除。
            this.accessTableAdapter.Fill(this.sdpDataSet.access);
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.sdpDataSet.staff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int staffID = Convert.ToInt32(comboBox1.Text);
            int accessID = Convert.ToInt32(comboBox2.SelectedValue);

            using (var context = new sdpEntities1())
            {
                var result = context.staff.Find(staffID);
                if (result != null)
                {
                    result.accessID = accessID;
                    context.SaveChanges();
                }
            }
        }
    }
}
