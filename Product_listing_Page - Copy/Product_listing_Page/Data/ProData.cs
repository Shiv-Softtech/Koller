using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace Product_listing_Page.Data
{
    public class ProData : IProData
    {
       
         static MappingSource _sharedMappingSource = new AttributeMappingSource();
        string _connectionString;
        public ProduDataContext MasterDataContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["productdbConnectionString"].ConnectionString;
            return new ProduDataContext(_connectionString, _sharedMappingSource);
        }
    }
}