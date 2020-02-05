using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;

namespace Morthwind.WebFormsUI
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal()); 
            _categoryService= new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Burada dal kullanılmaz business kullanılır
            //ProductManager productManager = new ProductManager(new EfProductDal());

            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
           
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetProducts();
        }
    }
}
