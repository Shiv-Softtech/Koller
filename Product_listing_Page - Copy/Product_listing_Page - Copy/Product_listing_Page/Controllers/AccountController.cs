using AutoMapper;
using Product_listing_Page.Entity;
using Product_listing_Page.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_listing_Page.Controllers
{
    public class AccountController : Controller
    {
        private readonly IProductService _productService;
        public AccountController(IProductService ProductService)
        {
            _productService = ProductService;
        }

        public ActionResult Adduser()
        {
            return View();
        }

        public void insertData(RegistrationEntity postdata)
        {
            _productService.Getdetail(postdata);
        }


        public ActionResult login()
        {
            return View();
        }
       
    }
}
