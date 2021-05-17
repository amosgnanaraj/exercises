using ecommerce.API.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.API.Service.Search.Interface
{
    public interface ISearchService
    {
        KeywordModel[] SearchKeywords(string input);
        bool ValidateInput(string input);
    }
}
