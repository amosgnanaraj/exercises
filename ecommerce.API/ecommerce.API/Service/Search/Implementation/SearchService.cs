using ecommerce.API.Models.Search;
using ecommerce.API.Repository.Search.Interface;
using ecommerce.API.Service.Search.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.API.Service.Search.Implementation
{
    public class SearchService : ISearchService
    {
        private readonly ISearchRepository _searchRepository;
        public SearchService(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }
        public KeywordModel[] SearchKeywords(string input)
        {
            KeywordModel[] keywords = null;

            if (!string.IsNullOrEmpty(input))
            {
                keywords = _searchRepository.SearchKeywords(input);
            }

            return keywords;
        }

        public bool ValidateInput(string input)
        {
            throw new NotImplementedException();
        }
    }
}
