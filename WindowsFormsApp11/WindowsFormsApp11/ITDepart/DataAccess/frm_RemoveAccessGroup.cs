using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.ITDepart.DataAccess
{
    public partial class frm_RemoveAccessGroup : Form
    {
        public frm_RemoveAccessGroup()
        {
            InitializeComponent();
        }

        private void frm_RemoveAccessGroup_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.access' 資料表。您可以視需要進行移動或移除。
            this.accessTableAdapter.Fill(this.sdpDataSet.access);

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            String accessID = cbo_AccessID.Text;

            using (var context = new sdpEntities1())
            {
                var access = new access { AccessID = Convert.ToInt32(accessID) };
                context.access.Attach(access);
                context.access.Remove(access);

                context.SaveChanges();

                MessageBox.Show("Remove Finish");
            }
        }
    }
}
