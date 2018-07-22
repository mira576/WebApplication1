using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameEng { get; set; }
        public string NameAr { get; set; }
        public long price { get; set; }

        public virtual Category Category { get; set; }
    }
}