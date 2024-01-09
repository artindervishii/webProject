using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.DataAccess.Repository.IRepository
{
    public interface IProductRespository :IRepository<Product>
    {
        void Update(Product obj);

    }
}
