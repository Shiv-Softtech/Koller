using AutoMapper;
using Product_listing_Page.Data;
using Product_listing_Page.Entity;
using Product_listing_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Product_listing_Page
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ProductEntity, ProductModel>();
                cfg.CreateMap<FilterEntity, FilterModel>();
                cfg.CreateMap<ProductID_2022Result, ProductModel>();

            });
        }
    }
}
