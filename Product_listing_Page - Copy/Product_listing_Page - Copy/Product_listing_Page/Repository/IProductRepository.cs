using Product_listing_Page.Data;
using Product_listing_Page.Entity;
using Product_listing_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_listing_Page.Repository
{
    public interface IProductRepository
    {
       
        List<ProductEntity> GetList(ProductEntity user);

     /*   List<ProductEntity> sortBy(ProductEntity user);*/


        List<IndexEntity> GetIndex(IndexEntity user);


        List<FilterEntity> GetFilter(FilterEntity user);


        void Getdetail(RegistrationEntity user);


        ProductModel ProductDetail(int id);



    }
}
