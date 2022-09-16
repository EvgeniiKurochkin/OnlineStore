﻿using Store;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Memory
{
    public class ProductRepository
    {
        private static readonly Product[] products = new[]
        {
            new Product("Iphone 13 Pro Max", 125000, "512 gb"),
            new Product("Sony PS5", 55000, "Video game console"),
            new Product("War and Peace", 1500, "Literary work by the Russian author Leo Tolstoy")
        };

        public Product[] GetAllbiIds(IEnumerable<int> productIds)
        {
            var faundProduct = from product in products
                               join productId in productIds on product.Id equals productId
                               select product;

            return faundProduct.ToArray();
        }

        public Product[] GetAllProduct()
        {
            return products;
        }
        public string ReturnAllIdNameCostProduct()
        {
            var result = "";

            for (int i = 0; i < ProductRepository.products.Length; i++)
            {
                result += products[i] + "\n\n";
            }

            return result;
        }

        public Product ReturnIdNameCostDescriptionProduct(int id)
        {
            Product result = null;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Id == id)
                {
                    result = products[i]; 
                }    
                
            }

            return result;
        }
    }
}
