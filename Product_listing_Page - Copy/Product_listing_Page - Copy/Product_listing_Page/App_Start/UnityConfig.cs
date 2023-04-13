
using Product_listing_Page.Data;
using Product_listing_Page.Repository;
using Product_listing_Page.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Product_listing_Page
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

           container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductRepository, Repository.ProductRepository>();
            container.RegisterType<IProData, ProData>();



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}