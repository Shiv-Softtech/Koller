using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_listing_Page.Data
{
    public interface IProData
    {
        ProduDataContext MasterDataContext();
    }
}
