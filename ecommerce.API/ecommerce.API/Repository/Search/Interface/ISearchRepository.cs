using ecommerce.API.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.API.Repository.Search.Interface
{
    public interface ISearchRepository
    {
        KeywordModel[] SearchKeywords(string input);
    }
}
