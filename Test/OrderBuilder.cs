﻿using System;
using Core.Model;

namespace Test
{
    public class OrderBuilder
    {
        private Order order;

        private OrderBuilder(Order order)
        {
            this.order = order;
        }

        public static OrderBuilder Create()
        {
            return new OrderBuilder(new Order());
        }

        public OrderBuilder AddDetail(int taxRate, int quantity, decimal unitPrice, int id = -1, int discountRate = 0)

        public Order GetOrder()

    }
}