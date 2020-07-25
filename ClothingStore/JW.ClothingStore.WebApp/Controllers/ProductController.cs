using JW.ClothingStore.Domain.Abstract;
using JW.ClothingStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JW.ClothingStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        // private IProductsRepository repository;

        // GET: Product
        //public ProductController(IProductsRepository productsRepository)
        //{
        //   this.repository = productsRepository;
        //}

        public IProductsRepository ProductsRepository { get; set; } = new InMemoryProductsRepository();

        public ViewResult List()
        {
            var model = ProductsRepository.Products;

            return View(model);

            //return View(ProductsRepository.Products);
        }
    }
}