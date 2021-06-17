namespace Parmajiat.Shopping.Models
{
    public class OrderLine 
    {
        public int Id { get; set; }        
        public long OrderId { get; set; }        
        public long ProductId { get; set; }        
        public decimal Price { get; set; }        
        public int Quantity { get; set; }        
        public string Color { get; set;}        
        public string Size { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
