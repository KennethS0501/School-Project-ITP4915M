using SDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.ITdepart;
using WindowsFormsApp11.ITdepart.Account;
using WindowsFormsApp11.ITdepart.DataAccess;
using WindowsFormsApp11.ITdepart.Staff;
using WindowsFormsApp11.LoginPage;
using WindowsFormsApp11.InventoryDepart.Delivery_Management;
using WindowsFormsApp11.InventoryDepart.Delivery_Management.Daily_Delivery_List_Generater;
using WindowsFormsApp11.SalesDepart.Restock_From_Warehouse;
using WindowsFormsApp11.InventoryDepart.Restock_From_Supplier;
using WindowsFormsApp11.SalesDepart.Sales_Order_Management;
using WindowsFormsApp11.ITDepart.DataAccess;
using WindowsFormsApp11.InventoryDepart;
using WindowsFormsApp11.SalesDepart.Sales_Order_Management.Checkout;

namespace WindowsFormsApp11
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
    }
}