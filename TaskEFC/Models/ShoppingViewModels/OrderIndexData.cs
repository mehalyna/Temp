using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskEFC.Models;

namespace TaskEFC.ShoppingViewModels
{
    public class OrderIndexData
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
