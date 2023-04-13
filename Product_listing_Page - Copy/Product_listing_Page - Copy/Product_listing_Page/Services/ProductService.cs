using Product_listing_Page.Data;
using Product_listing_Page.Entity;
using Product_listing_Page.Models;
using Product_listing_Page.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_listing_Page.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductEntity> GetList(ProductEntity prodata)
        {
            return _productRepository.GetList(prodata);

        }

     /*   public List<ProductEntity> sortBy(ProductEntity prodata)
        {
            return _productRepository.sortBy(prodata);

        }*/

        public List<IndexEntity> GetIndex(IndexEntity prodata)
        {
            return _productRepository.GetIndex(prodata);
        }

        public List<FilterEntity> GetFilter(FilterEntity prodata)
        {
            return _productRepository.GetFilter(prodata);
        }


        public void Getdetail(RegistrationEntity user)
        {
            _productRepository.Getdetail(user);
      
        }
 

        public ProductModel ProductDetail(int id)
        {
           var rep = _productRepository.ProductDetail(id);
            return rep;
        }
    }
}  



