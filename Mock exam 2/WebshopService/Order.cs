using System;
using System.Runtime.Serialization;

namespace WebshopService
{
    [DataContract]

    public class Order
    {
        public Order(int orderId, string productId, DateTime moment)
        {
            OrderId = orderId;
            ProductId = productId;
            Moment = moment;
        }
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public DateTime Moment { get; set; }
    }
}
