using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;
using WebStore.Infrasructure.Interfaces;

namespace WebStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Administrator")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View(_productService
                .GetProducts(new ProductsFilter()));
        }

        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("ProductList");
        }

        public IActionResult Edit(int? id)
        {
            var product = id.HasValue
                ? _productService.GetProductById(id.Value)
                : new Product();

            if (ReferenceEquals(product, null))
                return NotFound();

            return View(product);
        }

        //public IActionResult Details(int? id)
        //{
        //    var product = id.HasValue
        //        ? _productService.GetProductById(id.Value)
        //        : new Product();

        //    if (ReferenceEquals(product, null))
        //        return NotFound();

        //    return View(product);
        //}

        //[HttpPost]
        //public IActionResult Details(Product product)
        //{
        //    if (!ModelState.IsValid)
        //        return View(product);

        //    if (product.Id == 0)
        //    {
        //        _productService.AddNew(product);
        //        return RedirectToAction("ProductList");
        //    }

        //    var tmpProduct = _productService.GetProductById(product.Id);
        //    if (ReferenceEquals(tmpProduct, null))
        //        return NotFound();

        //    tmpProduct. = product.Age;
            

        //    _employeeService.Commit();

        //    return RedirectToAction("Index");
        //}
    }
}