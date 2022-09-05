﻿using System;

namespace Store
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public Product (int id, string name, decimal cost, string description)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;

        }

        public string ToString2()
        {
            return $"{Id}\n{Name}\n{Cost}\n{Description}";
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }

    }
}
