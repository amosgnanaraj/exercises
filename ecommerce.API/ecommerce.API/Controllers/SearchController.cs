using ecommerce.API.Service.Search.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.API.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [Route("Search/GetKeywords")]
        public IActionResult GetKeywords(string input)
        {
            var result = _searchService.SearchKeywords(input);
            return Ok(result);
        }
    }
}
