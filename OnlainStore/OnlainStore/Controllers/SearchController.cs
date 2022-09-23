﻿using Microsoft.AspNetCore.Mvc;
using Store;

namespace OlineStore.Controllers
{
    public class SearchController : Controller
    {

        private readonly IProductRepository productRepository;

        public SearchController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(string query)
        {
            var product = productRepository.GetAllByProductName(query);
            return View(product);
        }
    }
}