using AutoMapper;
using Product_listing_Page.Entity;
using Product_listing_Page.Models;
using Product_listing_Page.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_listing_Page.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService ProductService)
        {
            _productService = ProductService;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult AddTowishlist()
        {
            return View();
        }

        public ActionResult cart()
        {
            return View();
        }


        [HttpGet]
        public JsonResult GetList(ProductEntity user)
        {

            var proData = Mapper.Map<ProductEntity>(user);
            var resp = _productService.GetList(proData);
            return Json(resp, JsonRequestBehavior.AllowGet);
        }

       /* public JsonResult sortBy(ProductEntity user)
        {

            var proData = Mapper.Map<ProductEntity>(user);
            var resp = _productService.sortBy(proData);
            return Json(resp, JsonRequestBehavior.AllowGet);
        }*/


        public JsonResult GetIndex(IndexEntity user)
        {

            var pro = Mapper.Map<IndexEntity>(user);
            var resp = _productService.GetIndex(pro);
            return Json(resp, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetFilter(FilterEntity user)
        {

            var pro = Mapper.Map<FilterEntity>(user);
            var resp = _productService.GetFilter(pro);
            return Json(resp, JsonRequestBehavior.AllowGet);
        }


        public  ActionResult ProductDetail(int id)
        {
            var rep = _productService.ProductDetail(id);

            return View(rep);
        }

        /*  public JsonResult GetFilter(FilterEntity user)
          {

              var proData = Mapper.Map<FilterEntity>(user);
              var filter = _productService.GetFilter(proData);
              return Json(filter, JsonRequestBehavior.AllowGet);
          }*/

    }

}
