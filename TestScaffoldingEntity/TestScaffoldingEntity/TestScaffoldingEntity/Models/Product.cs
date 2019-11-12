﻿using System;

namespace TestScaffoldingEntity.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}