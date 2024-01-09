using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.DataAccess.Repository.IRepository;
using WebProject.Models;
using WebProject.WebProject.DataAccess;

namespace WebProject.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRespository
    {

        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }


    }
}
