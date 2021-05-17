using ecommerce.API.Models.Search;
using ecommerce.API.Repository.Search.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.API.Repository.Search.Implementation
{
    public class SearchRepository : ISearchRepository
    {
        public KeywordModel[] SearchKeywords(string input)
        {
            KeywordModel[] keywords = new KeywordModel[]
            {
                new KeywordModel()
                {
                    Keyword = "Pair of Socks",
                    KeywordID = 1,
                    ListingOrder = 7
                },
                new KeywordModel()
                {
                    Keyword = "Pair of boots",
                     KeywordID = 2,
                     ListingOrder = 5
                },
                new KeywordModel()
                {
                    Keyword = "Papers",
                     KeywordID = 3,
                     ListingOrder = 6
                },
                new KeywordModel()
                {
                    Keyword = "Paris",
                    KeywordID = 4,
                     ListingOrder = 3
                },
                new KeywordModel()
                {
                    KeywordID = 5,
                     Keyword = "Pure",
                     ListingOrder = 1
                }
            };

            var filteredKeys = keywords.Where(x => x.Keyword.ToLower().Contains(input.ToLower())).OrderBy(x => x.ListingOrder).ThenBy(x => x.KeywordID).ToArray();

            return filteredKeys;
        }
    }
}
