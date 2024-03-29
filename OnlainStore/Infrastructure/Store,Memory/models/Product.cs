﻿using System;
using System.Collections.Generic;

namespace Store_Memory
{
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public List<CartItem> CartItems { get; set; }

    }
}
