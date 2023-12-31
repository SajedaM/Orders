﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ordering.Models
{
    internal class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
