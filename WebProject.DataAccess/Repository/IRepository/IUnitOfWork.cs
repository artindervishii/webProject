﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {

        ICategoryRepository Category { get; }

        IProductRespository Product { get; }


        ICompanyRepository Company { get; }

        IShoppingCartRepository ShoppingCart { get; }

        IApplicationUserRepository ApplicationUser { get; }


        void Save();


    }
}
