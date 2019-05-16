using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinhkien.ViewModels
{
    public class ProductsViewModels
    {
        public int ID { get; set; }
        public string Product_Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Descriptions { get; set; }
        public string Parameter { get; set; }

        public int Quanlity { get; set; }
        public float Price { get; set; }
        public string Hot { get; set; }
        public DateTime? Createdates { get; set; }
        public DateTime Datesupdate { get; set; }
        public string NameCate { get; set; }
        public string Type { get; set; }
        public string NameSup { get; set; }
        public string EmailSup { get; set; }
        public string PhoneSup { get; set; }
        public int Categories_ID { get; set; }
        public int Suppliers_ID { get; set; }
        public int viewcount { get; set; }
    }

    public class MenuListSp
    {
        public List<ProductsViewModels> Products { get; set; }
        public string Link { get; set; }
    }
    public class ProductDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Descriptions { get; set; }
        public string Parameter { get; set; }

        public int Quanlity { get; set; }
        public float Price { get; set; }
        public int viewcount { get; set; }

        public DateTime? Createdates { get; set; }
        public string NameCate { get; set; }

        public string NameSup { get; set; }


    }
}