﻿using ObserverPattern.Lab2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Lab2.Concrete
{
    public class ConcreteMember:IMember
    {
        public string Email { get; set; }

        public void Update(Product product) => Console.WriteLine($"{product.ProductName} fiyatı {product.Price} oldu. Bilgilerndirme {Email} adresine gönderildi..!");
    }
}
