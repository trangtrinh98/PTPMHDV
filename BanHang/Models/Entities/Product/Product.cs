using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models.Entities
{
    public class Product
    {
        public int ID{get;set;}
        public string Name{get;set;}
        public float PricePD{get;set;}
        public int Quantity{get;set;}
        public Boolean Status{get;set;}
        public string Image{get;set;}
        public ICollection<OrderDetail> OrderDetails{get;set;}
    

       
    }
}

