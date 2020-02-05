using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

        //public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        return context.Products.ToList();
        //    }
        //}

        //public Product Get(Expression<Func<Product, bool>> filter)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        //return context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
        //        return context.Products.FirstOrDefault(filter);
        //    }
        //}

        //public void Add(Product product)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        context.Products.Add(product);
        //        context.SaveChanges();
        //    }
        //}
        //public void Update(Product product)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //      //  context.Products.Where(p => p.ProductId == product.ProductId).FirstOrDefault();
        //    }
        //}
        //public void Delete(int productId)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        //context.Products.Where(p => p.ProductId == productId).DefaultIfEmpty();
        //    }
        //}
    }
}
