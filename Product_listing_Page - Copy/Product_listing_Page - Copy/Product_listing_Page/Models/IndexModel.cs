using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_listing_Page.Models
{
    public class IndexModel
    {
        public string ImageName { get; set; }

        public decimal price { get; set; }

        public string Catogries { get; set; }

        public string ImagePath1 { get; set; }

        public string ImagePath2 { get; set; }

        public int id { get; set; }
    }
}