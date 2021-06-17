using Parmajiat.Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parmajiat.Shopping.Data
{
    public class DataRepository
    {
        public static List<Product> products = new List<Product>
        {
            new Product(){Id =1, Name= "Laptop", Barcode="123456", Price=2000},
            new Product(){Id =2, Name= "iPhone", Barcode="456465", Price=3500},
            new Product(){Id =3, Name= "Keyboard", Barcode="654987", Price=150},
        };
    }
}