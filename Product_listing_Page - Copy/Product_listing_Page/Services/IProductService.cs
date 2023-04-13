using Product_listing_Page.Entity;
using Product_listing_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_listing_Page.Service
{
    public interface IProductService
    {
    

        List<ProductEntity> GetList(ProductEntity proData);



        List<IndexEntity> GetIndex(IndexEntity proData);


        List<FilterEntity> Getfilter(FilterEntity proData);



        void Getdetail(RegistrationEntity user);





        ProductModel ProductDetail(int id);




        /*List<FilterEntity> GetFilter(FilterEntity user);*/





    }
}
