﻿using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Business
{
    public interface IProducService
    {
        List<Product> GetAll();

        void Add(Product product);
    }
}
