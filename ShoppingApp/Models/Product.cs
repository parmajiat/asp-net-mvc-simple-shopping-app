using System;

namespace Parmajiat.Shopping.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal ComparePrice { get; set; }
        public decimal Discount { get; set; }
        public string ImagePath { get; set; }
        public DateTime Created { get; set; }
    }
}