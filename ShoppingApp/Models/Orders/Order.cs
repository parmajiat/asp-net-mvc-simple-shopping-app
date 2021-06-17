using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Parmajiat.Shopping.Models
{
    public class Order
    {
        public int Id { get; set; }
        public long No { get; set; }
        public string Identity { get; set; }
        public int? CustomerId { get; set; }
        public decimal Discount { get; set; } = 0;
        public string Copuon { get; set; }
        public string Address { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhoneNumber { get; set; }
        public string DeliveryTime { get; set; }
        public decimal ShippingFee { get; set; }
        public string Note { get; set; }
        public string ShippingNo { get; set; }
        public string InvoiceNo { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsShipped { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsReturned { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public string Reference { get; set; }
        public string UnderProcessNote { get; set; }
        public string WaitingDeliveryNote { get; set; }
        public string DeliveredNote { get; set; }
        public string CanceledNote { get; set; }
        public string Culture { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string PaymentMethod { get; set; }
        public string ShippingMethod { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}