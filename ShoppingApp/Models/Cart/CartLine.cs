namespace Parmajiat.Shopping.Models
{
    public class CartLine
    {
        public int Quantity { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Subtotal => Product.Price * Quantity;
        public Product Product { get; set; }
        public CartLine() { }
        public CartLine(Product product, int quantity) : this()
        {
            Product = product;
            Quantity = quantity;

        }
    }
}