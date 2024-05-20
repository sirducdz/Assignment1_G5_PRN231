using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ObjectBusiness.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; } = null!;
        [JsonIgnore]
        public virtual Product Product { get; set; } = null!;
    }
}
