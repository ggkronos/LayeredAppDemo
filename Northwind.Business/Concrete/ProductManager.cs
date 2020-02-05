using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        //Kötü bir yazım tarzı efproductdal ı kullanmak çünkü bağımlılığa sebep oluyor.
        // EfProductDal _productDal = new EfProductDal();


        //dependency injection tekniği
        private IProductDal _productDal;
        //yapıcı metot kullanıyoruz.
        //ProductManager newlendiğinde bir productDal ver ve onu kullanacağımız
        //_procuctDal a ata
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetProducts()
        {
            //Business code
            return _productDal.GetAll();
        }
    }
}
