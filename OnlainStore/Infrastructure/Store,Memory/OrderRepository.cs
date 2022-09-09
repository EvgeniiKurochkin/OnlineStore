﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store;

namespace Store_Memory
{
    public class OrderRepository : IOrderRepositoty
    {
        private readonly List<Order> orders = new List<Order>();

        public Order Create()
        {
            int nexrId = orders.Count + 1;
            var order = new Order(nexrId, new OrderItem[0]);

            orders.Add(order);

            return order;
        }

        public Order GetById(int id)
        {
            return orders.Single(order => order.Id == id);
        }

        public void Update(Order order)
        {

        }
    }
}
