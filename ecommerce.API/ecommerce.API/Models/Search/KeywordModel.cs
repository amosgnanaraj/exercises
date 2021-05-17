using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.API.Models.Search
{
    public class KeywordModel
    {
        public int KeywordID { get; set; }
        public string Keyword { get; set; }
        public int ListingOrder { get; set; }
    }
}
