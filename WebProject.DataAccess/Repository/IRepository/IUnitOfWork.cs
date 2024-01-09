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


        void Save();


    }
}
