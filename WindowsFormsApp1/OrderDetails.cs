using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class OrderDetails
    {
        private string dbConnectionString = "Data Source=ELIS_LAPTOP\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";
        public static POSDBEntities db;

        private int orderDetailsId;
        private int orderId;
        private int productId;
        private int quantity;

        public int OrderDetailsId
        {
            get { return orderDetailsId; }
            set { orderDetailsId = value; }
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
