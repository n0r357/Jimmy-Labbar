﻿using Labb16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16.Repositories
{
    interface IProductRepository
    {
        void Add();
        List<Product> Get(int id);
        List<Product> GetAll();
        void Update(Product updatedProduct);
        void Delete(int id);
    }
}
