using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Shop
{
    // data annotations 
    //public class Product
    //{
    //    [Key]
    //    public int Code { get; set; }

    //    public int Id { get; set; }

    //    [MaxLength(100)]
    //    public string Title { get; set; }

    //    public string Description { get; set; }
    //}

    // fluent api 
    public class Product
    {       
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Barcode { get; set; }

        public double Price { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}