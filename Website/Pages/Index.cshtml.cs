using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace Website.Pages
{
    /// <summary>
    /// Class meant to act as the Model to the Index.cshtml page
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        //FOR TESTING PURPOSES, PLEASE UNCOMMENT THIS CONSTRUCTOR TO RUN TESTS
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
        public IEnumerable<IOrderItem> TempItems { get; set; }
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
            Items = Menu.AllItems();
            List<IOrderItem> test = new List<IOrderItem>();
            // Search item titles for the SearchTerms
            if (SearchTerms != null)
            {
                string[] SearchTermsArray = SearchTerms.Split(" ");
                for(int i = 0; i < SearchTermsArray.Length; i++)
                {
                    Items = Items.Where(item => item.ToString() != null 
                        && (item.ToString().Contains(SearchTermsArray[i], StringComparison.InvariantCultureIgnoreCase)
                        || item.Description.Contains(SearchTermsArray[i], StringComparison.InvariantCultureIgnoreCase)));
                    foreach(IOrderItem item in Items)
                    {
                        test.Add(item);
                    }
                }
                Items = test;
            }
            if (Categories != null && Categories.Length != 0)
            {
                if (Categories.Contains("Entree"))
                {
                    Items = Items.Where(items => items is Entree);
                }
                if (Categories.Contains("Side"))
                {
                    Items = Items.Where(items => items is Side);
                }
                if (Categories.Contains("Drink"))
                {
                    Items = Items.Where(items => items is Drink);
                }
            }


            if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(item =>
                    item.Price != null &&
                    item.Price <= PriceMax
                    );
            }
            // only a minimum specified
            if (PriceMax == null && PriceMin != null)
            {
                Items = Items.Where(item =>
                    item.Price != null &&
                    item.Price >= PriceMin
                    );
            }
            // Both minimum and maximum specified
            if (PriceMax != null && PriceMin != null)
            {
                Items = Items.Where(item =>
                    item.Price != null &&
                    item.Price >= PriceMin &&
                     item.Price <= PriceMax
                    );
            }
            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(item =>
                    item.Calories != null &&
                    item.Calories <= CaloriesMax
                    );
            }

            // only a minimum specified
            if (CaloriesMax == null && CaloriesMin != null)
            {
                Items = Items.Where(item =>
                    item.Calories != null &&
                    item.Calories >= CaloriesMin
                    );
            }
            // Both minimum and maximum specified
            if (CaloriesMax != null && CaloriesMin != null)
            {
                Items = Items.Where(item =>
                    item.Calories != null &&
                    item.Calories >= CaloriesMin &&
                     item.Calories <= CaloriesMax
                    );
            }
        }
    }
}
