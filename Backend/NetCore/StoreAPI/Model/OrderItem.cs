﻿using System.Text.Json.Serialization;

namespace StoreAPI.Model
{
    public class OrderItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
