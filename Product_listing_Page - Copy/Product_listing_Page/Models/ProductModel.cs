using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_listing_Page.Models
{
    public class ProductModel
    {
        public string ImgName { get; set; }

        public decimal price { get; set; }

        public string Catogries { get; set; }

        public string imgpath { get; set; }

        public int id { get; set; } 
    }
}