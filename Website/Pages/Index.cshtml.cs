using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Interface;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The filtered MPAA Ratings
        /// </summary>
        public string[] Categories { get; set; }
        public IEnumerable<IOrderItem> Items { get; set; }
        public string SearchTerms { get; set; }
        public double? PriceMin { get; set; }
        public double? PriceMax { get; set; }
        public double? CaloriesMin { get; set; }
        public double? CaloriesMax { get; set; }
        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(string SearchTerms, string[] Categories, double? PriceMin, double? PriceMax, double? CaloriesMin, double? CaloriesMax)
        {
            this.SearchTerms = SearchTerms;
            this.Categories = Categories;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
        }
    }
}
