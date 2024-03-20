using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PurchaseRequest
    {
        public CustomerType CustomerType { get; set; }
        public List<Book> Books { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
