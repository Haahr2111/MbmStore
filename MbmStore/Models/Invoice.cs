using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        private DateTime Orderdate { get; set; }

        private List<OrderItem> items = new List<OrderItem>();
        public List<OrderItem> Items { get {return items; } }

        public Custumer Custumer { get; set; }

        public Invoice (int invoiceid, DateTime orderdate, Custumer custumer)
        {
            InvoiceID = invoiceid;
            Orderdate = orderdate;
            Custumer = custumer;
}
        public void AddOrderItems(OrderItem item)
        {
            items.Add(item);
        }
    }
}
