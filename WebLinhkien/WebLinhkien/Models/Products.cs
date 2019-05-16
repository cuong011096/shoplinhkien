using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLinhkien.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }
        public string Product_Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Descriptions { get; set; } //mô tả
        public string Parameter { get; set; } // thông số
        public int Quanlity { get; set; } //số lượng
        public float Price { get; set; } //giá
        public string Hot { get; set; }
        public DateTime? Createdates { get; set; }
        public DateTime? Datesupdate { get; set; }
 
        public int viewcount { get; set; }

        public virtual Categories Categories { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual IList<Ordersdetails> Ordersdetails { get; set; }

    }
}