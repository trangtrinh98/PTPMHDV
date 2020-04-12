using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models.Entities
{
    public class Order
    {
        public int ID{get;set;}
        public int CustomerID{get;set;}
        public DateTime OrderDate{get;set;}
        public Boolean OrderStatus{get;set;}
        public Customer Customer{get;set;}
        public ICollection<OrderDetail> OrderDetails{get;set;}

       
    }
}

