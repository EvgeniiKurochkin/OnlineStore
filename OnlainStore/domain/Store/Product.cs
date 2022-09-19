﻿using System;

namespace Store
{
    public class Product
    {
        private static int instCounter = 1;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }
        public string Link { get; }



        public Product (string name, decimal cost, string description, string link)
        {
            Id = instCounter;
            Name = name;
            Cost = cost;
            Description = description;
            Link = link;
            instCounter += 1;

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
