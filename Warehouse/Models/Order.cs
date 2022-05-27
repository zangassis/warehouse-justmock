﻿namespace Warehouse.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public bool IsCompleted { get; set; }
    }
}