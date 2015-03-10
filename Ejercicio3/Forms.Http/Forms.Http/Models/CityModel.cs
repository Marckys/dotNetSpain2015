using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Http.Models
{

    public class RestWrap
    {
        public IEnumerable<CityModel> d { get; set; } 
    }

    public class CityModel
    {
        public IEnumerable<GeoNames> geonames { get; set; }
   }

    public class GeoNames
    {
         public string fcodeName { get; set; }
        public string countrycode { get; set; }

    }
}
