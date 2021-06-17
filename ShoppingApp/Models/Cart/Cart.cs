using System.Collections.Generic;
using System.Linq;

namespace Parmajiat.Shopping.Models
{
    public class Cart : List<CartLine>
    {
        public long StoreId { get; set; }
        public decimal Discount { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal TotalPrice => this.Sum(x => x.Subtotal);
        public Cart() { }
        public Order Order { get; set; }
    }
}