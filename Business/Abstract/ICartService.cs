﻿using Entities.Concrete;
using Entities.Dtos.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void RemoveFromCart(Cart cart, int productID);
        List<CartLine> List(Cart cart);
    }
}
