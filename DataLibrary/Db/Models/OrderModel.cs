﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Db.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public int FoodId { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
