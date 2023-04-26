using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            using (var db = new POSDBEntities());

                
        }
        public static string dbConnectionString = "Data Source=ELIS_LAPTOP\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";

    }
}
