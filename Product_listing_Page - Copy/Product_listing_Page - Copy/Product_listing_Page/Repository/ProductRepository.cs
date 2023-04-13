using AutoMapper;
using Product_listing_Page.Data;
using Product_listing_Page.Entity;
using Product_listing_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_listing_Page.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProData _proData;
        private ProduDataContext _duDataContext;


        public ProductRepository(IProData proData)
        {
            _proData = proData;
            _duDataContext = proData.MasterDataContext();
        }

        public List<ProductEntity> GetList(ProductEntity proData)
        {
            var dbResp = _duDataContext.Imag_20220907().ToList();
            var resp = (from o in dbResp
                        select new ProductEntity
                        {
                            ImgName = o.ImgName,
                            imgpath=o.imgpath,
                            id=o.id,
                            Catogries=o.Catogries,
                            price = (decimal)o.Price
                        }).ToList();
            return resp;
        }

        public List<IndexEntity> GetIndex(IndexEntity proData)
        {
            var dbResp = _duDataContext.Index_20229().ToList();
            var resp = (from o in dbResp
                        select new IndexEntity
                        {
                         
                            ImageName = o.ImageName,
                            price = (decimal)o.Price,
                            Catogries=o.Categroies,
                            id=o.id,
                            ImagePath1 = o.ImagePath1,
                            ImagePath2 = o.ImagePath2

                        }).ToList();
            return resp;
        }


        public void Getdetail(RegistrationEntity user)
        {
            _duDataContext.Register20220909(user.Name, user.Email, user.Password, user.Gender, user.Department, user.Hobbies);
        }



        public ProductModel ProductDetail(int id)
        {
            var probj = _duDataContext.ProductID_2022(id).FirstOrDefault();
            var pro = Mapper.Map<ProductID_2022Result, ProductModel>(probj);
            return pro; 
        }

        public List<FilterEntity> GetFilter(FilterEntity user)
        {
            var db = _duDataContext.Filter2022().ToList();
            var resp = (from a in db
                        select new FilterEntity
                        {
                            Title = a.Title,
                            detail1 = a.Detail1,
                            detail2 = a.Detail2,
                            Id = a.Id

                        }).ToList();
            return resp;
        }
    }

}
