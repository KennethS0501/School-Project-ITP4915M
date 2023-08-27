using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace WindowsFormsApp11.InventoryDepart.Installation_Management.Daily_Installation_List_Generater
{
    public partial class frm_InstallationListGen : Form
    {
        public frm_InstallationListGen()
        {
            InitializeComponent();
        }
        private void frm_DeliveryListGen_Load(object sender, EventArgs e)
        {
            GridViewRefresh();
        }

        private void GridViewRefresh()
        {
            using (var context = new sdpEntities1())
            {

                DateTime date = dateTimePicker1.Value;
                var deliveryDB = from d in context.installation
                                 join s in context.staff on d.staffID equals s.staffID
                                 join o in context.order on d.installationID equals o.installationID
                                 join c in context.customer on o.customerID equals c.customerID
                                 where d.installtionDate == date
                                 select new { s.lastName, c.Name, c.address, c.phone, o.orderID, d.installationID };

                dataGridView1.DataSource = deliveryDB.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Staff Last Name";

                dataGridView1.Columns[1].HeaderCell.Value = "Customer Name";

                dataGridView1.Columns[2].HeaderCell.Value = "Address";
                dataGridView1.Columns[2].Width = 170;

                dataGridView1.Columns[3].HeaderCell.Value = "Customer Phone";

                dataGridView1.Columns[4].HeaderCell.Value = "Order ID";
                dataGridView1.Columns[4].Width = 50;

                dataGridView1.Columns[5].HeaderCell.Value = "installation ID";
                dataGridView1.Columns[5].Width = 50;
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GridViewRefresh();
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnExportToExcel();
        }
        private void btnExportToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Daily Installation Generate_" + dateTimePicker1.Value.ToString("MM_dd_yyyy") + ".xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dataGridView1.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }



        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
