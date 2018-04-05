using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDemo.Models
{
    public class Product
    {
        public string ProductName { set; get; }
        //public string ProductName
        //{
        //    set { productName = value; }
        //    get { return productName; }
        //}
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}