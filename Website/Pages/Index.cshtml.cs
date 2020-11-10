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
    /// <summary>
    /// Class meant to act as the Model to the Index.cshtml page
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        /// <summary>
        /// for testing purposes
        /// </summary>
        /// <param name = "logger" ></ param >
        //public IndexModel()
        //{
        //}

        /// <summary>
        /// Constructor for the IndexModel Class, sets the _logger property
        /// </summary>
        /// <param name = "logger" ></ param >
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The filtered Categories, Entree, Side, Drink
        /// </summary>
        public string[] Categories { get; set; }
        /// <summary>
        /// The searched items
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }
        /// <summary>
        /// Terms that the user enters to search
        /// </summary>
        public string SearchTerms { get; set; }
        /// <summary>
        /// Minimum Price that the user enters
        /// </summary>
        public double? PriceMin { get; set; }
        /// <summary>
        /// Maximum Price that the user enters
        /// </summary>
        public double? PriceMax { get; set; }
        /// <summary>
        /// Minimum Calories that the user enters
        /// </summary>
        public int? CaloriesMin { get; set; }
        /// <summary>
        /// Maximum Calories that the user enters
        /// </summary>
        public int? CaloriesMax { get; set; }
        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(string SearchTerms, string[] Categories, double? PriceMin, double? PriceMax, int? CaloriesMin, int? CaloriesMax)
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
