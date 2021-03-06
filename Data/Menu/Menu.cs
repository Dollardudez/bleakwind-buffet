﻿/*
 * Author: Robert Clancy
 * Class name: Menu.cs
 * Purpose: Class used to represent the Menuof the Bleakwind Buffet Restaurant
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System.Linq;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// A class that represents segments of the menu or the entire menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Method that adds all the entrees to a List<IOrderItem> and returns that list of entrees
        /// </summary>
        /// <returns>A List<IOrderItem> that holds an instance of all entrees</returns>
        public static List<IOrderItem> Entrees()
        {
            List<IOrderItem> listOfEntrees = new List<IOrderItem>();
            listOfEntrees.Add(new BriarheartBurger());
            listOfEntrees.Add(new DoubleDraugr());
            listOfEntrees.Add(new GardenOrcOmelette());
            listOfEntrees.Add(new PhillyPoacher());
            listOfEntrees.Add(new SmokehouseSkeleton());
            listOfEntrees.Add(new ThalmorTriple());
            listOfEntrees.Add(new ThugsTBone());
            return listOfEntrees;
        }
        /// <summary>
        /// Method that adds all the sides (small, medium, and large) to a List<IOrderItem> and returns that list of sides
        /// </summary>
        /// <returns>A List<IOrderItem> that holds an instance of all sides added to the list</returns>
        public static List<IOrderItem> Sides()
        {
            List<IOrderItem> listOfSides = new List<IOrderItem>();
            for(int i = 0; i < 3; i++)
            {
                if(i == 0)
                {
                    listOfSides.Add(new DragonbornWaffleFries());
                    listOfSides.Add(new FriedMiraak());
                    listOfSides.Add(new MadOtarGrits());
                    listOfSides.Add(new VokunSalad());                }
                else if(i == 1)
                {
                    listOfSides.Add(new DragonbornWaffleFries { Size = Size.Medium });
                    listOfSides.Add(new FriedMiraak() { Size = Size.Medium });
                    listOfSides.Add(new MadOtarGrits() { Size = Size.Medium });
                    listOfSides.Add(new VokunSalad() { Size = Size.Medium });
                }
                else
                {
                    listOfSides.Add(new DragonbornWaffleFries { Size = Size.Large });
                    listOfSides.Add(new FriedMiraak() { Size = Size.Large });
                    listOfSides.Add(new MadOtarGrits() { Size = Size.Large });
                    listOfSides.Add(new VokunSalad() { Size = Size.Large });
                }
            }
            return listOfSides;
        }
        /// <summary>
        /// Method that adds all the drinks (small, medium and large) to a List<IOrderItem>. It adds 3 instances of SailorSoda
        /// to the list, each with different soda flavors
        /// </summary>
        /// <returns>A List<IOrderItem> that holds an instance of all drinks added to the list</returns>
        public static List<IOrderItem> Drinks()
        {
            List<IOrderItem> listOfDrinks = new List<IOrderItem>();
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    listOfDrinks.Add(new AretinoAppleJuice());
                    listOfDrinks.Add(new CandlehearthCoffee());
                    listOfDrinks.Add(new MarkarthMilk());
                    listOfDrinks.Add(new WarriorWater());
                    listOfDrinks.Add(new SailorSoda());
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Blackberry });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Lemon });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Peach });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Watermelon });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Grapefruit });
                }
                else if (i == 1)
                {
                    listOfDrinks.Add(new AretinoAppleJuice { Size = Size.Medium});
                    listOfDrinks.Add(new CandlehearthCoffee { Size = Size.Medium });
                    listOfDrinks.Add(new MarkarthMilk { Size = Size.Medium });
                    listOfDrinks.Add(new WarriorWater { Size = Size.Medium });
                    listOfDrinks.Add(new SailorSoda { Size = Size.Medium });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Blackberry, Size = Size.Medium });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Lemon, Size = Size.Medium });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Peach, Size = Size.Medium });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Watermelon, Size = Size.Medium });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Grapefruit, Size = Size.Medium });
                }
                else
                {

                    listOfDrinks.Add(new AretinoAppleJuice { Size = Size.Large });
                    listOfDrinks.Add(new CandlehearthCoffee { Size = Size.Large });
                    listOfDrinks.Add(new MarkarthMilk { Size = Size.Large });
                    listOfDrinks.Add(new WarriorWater { Size = Size.Large });
                    listOfDrinks.Add(new SailorSoda { Size = Size.Large });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Blackberry, Size = Size.Large });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Lemon, Size = Size.Large });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Peach, Size = Size.Large });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Watermelon, Size = Size.Large });
                    listOfDrinks.Add(new SailorSoda { Flavor = SodaFlavor.Grapefruit, Size = Size.Large });
                }
            }
            return listOfDrinks;
        }
        /// <summary>
        /// Method that adds all the items on the menu to a List<IOrderItem></IOrderItem>. Sides and Drinks
        /// have instances of small, medium and large. The method adds 3 instances of SailorSoda PER size, each instance has
        /// a particular flavor (Cherry, Blackberry, and Lemon)
        /// </summary>
        /// <returns>A List<IOrderItem> that holds an instance of all drinks added to the list</returns>
        public static List<IOrderItem> FullMenu()
        {

            List<IOrderItem> listFullMenu = new List<IOrderItem>();

            listFullMenu.Add(new BriarheartBurger());
            listFullMenu.Add(new DoubleDraugr());
            listFullMenu.Add(new GardenOrcOmelette());
            listFullMenu.Add(new PhillyPoacher());
            listFullMenu.Add(new SmokehouseSkeleton());
            listFullMenu.Add(new ThalmorTriple());
            listFullMenu.Add(new ThugsTBone());

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    listFullMenu.Add(new DragonbornWaffleFries());
                    listFullMenu.Add(new FriedMiraak());
                    listFullMenu.Add(new MadOtarGrits());
                    listFullMenu.Add(new VokunSalad());

                    listFullMenu.Add(new AretinoAppleJuice());
                    listFullMenu.Add(new CandlehearthCoffee());
                    listFullMenu.Add(new MarkarthMilk());
                    listFullMenu.Add(new WarriorWater());
                    listFullMenu.Add(new SailorSoda());
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Blackberry });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Lemon });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Peach });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Watermelon });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Grapefruit });
                }
                else if (i == 1)
                {
                    listFullMenu.Add(new DragonbornWaffleFries { Size = Size.Medium });
                    listFullMenu.Add(new FriedMiraak() { Size = Size.Medium });
                    listFullMenu.Add(new MadOtarGrits() { Size = Size.Medium });
                    listFullMenu.Add(new VokunSalad() { Size = Size.Medium });

                    listFullMenu.Add(new AretinoAppleJuice { Size = Size.Medium });
                    listFullMenu.Add(new CandlehearthCoffee { Size = Size.Medium });
                    listFullMenu.Add(new MarkarthMilk { Size = Size.Medium });
                    listFullMenu.Add(new WarriorWater { Size = Size.Medium });
                    listFullMenu.Add(new SailorSoda { Size = Size.Medium });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Blackberry, Size = Size.Medium });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Lemon, Size = Size.Medium });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Peach, Size = Size.Medium });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Watermelon, Size = Size.Medium });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Grapefruit, Size = Size.Medium });
                }
                else
                {
                    listFullMenu.Add(new DragonbornWaffleFries { Size = Size.Large });
                    listFullMenu.Add(new FriedMiraak() { Size = Size.Large });
                    listFullMenu.Add(new MadOtarGrits() { Size = Size.Large });
                    listFullMenu.Add(new VokunSalad() { Size = Size.Large });

                    listFullMenu.Add(new AretinoAppleJuice { Size = Size.Large });
                    listFullMenu.Add(new CandlehearthCoffee { Size = Size.Large });
                    listFullMenu.Add(new MarkarthMilk { Size = Size.Large });
                    listFullMenu.Add(new WarriorWater { Size = Size.Large });
                    listFullMenu.Add(new SailorSoda { Size = Size.Large });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Blackberry, Size = Size.Large });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Lemon, Size = Size.Large });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Peach, Size = Size.Large });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Watermelon, Size = Size.Large });
                    listFullMenu.Add(new SailorSoda { Flavor = SodaFlavor.Grapefruit, Size = Size.Large });
                }
            }
            return listFullMenu;
        }
        /// <summary>
        /// Method that adds all the items on the menu to a List<IOrderItem></IOrderItem>. Sides and Drinks
        /// have instances of small, medium and large. The method adds 3 instances of SailorSoda PER size, each instance has
        /// a particular flavor (Cherry, Blackberry, and Lemon)
        /// </summary>
        /// <returns>A List<IOrderItem> that holds an instance of all drinks added to the list</returns>
        public static List<IOrderItem> AllItems()
        {

            List<IOrderItem> listFullMenu = new List<IOrderItem>();

            listFullMenu.Add(new BriarheartBurger());
            listFullMenu.Add(new DoubleDraugr());
            listFullMenu.Add(new GardenOrcOmelette());
            listFullMenu.Add(new PhillyPoacher());
            listFullMenu.Add(new SmokehouseSkeleton());
            listFullMenu.Add(new ThalmorTriple());
            listFullMenu.Add(new ThugsTBone());

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    listFullMenu.Add(new DragonbornWaffleFries());
                    listFullMenu.Add(new FriedMiraak());
                    listFullMenu.Add(new MadOtarGrits());
                    listFullMenu.Add(new VokunSalad());

                    listFullMenu.Add(new AretinoAppleJuice());
                    listFullMenu.Add(new CandlehearthCoffee());
                    listFullMenu.Add(new MarkarthMilk());
                    listFullMenu.Add(new WarriorWater());
                    listFullMenu.Add(new SailorSoda() { ToStringProperty = "Small Sailor Soda" });
                }
                else if (i == 1)
                {
                    listFullMenu.Add(new DragonbornWaffleFries { Size = Size.Medium });
                    listFullMenu.Add(new FriedMiraak() { Size = Size.Medium });
                    listFullMenu.Add(new MadOtarGrits() { Size = Size.Medium });
                    listFullMenu.Add(new VokunSalad() { Size = Size.Medium });

                    listFullMenu.Add(new AretinoAppleJuice { Size = Size.Medium });
                    listFullMenu.Add(new CandlehearthCoffee { Size = Size.Medium });
                    listFullMenu.Add(new MarkarthMilk { Size = Size.Medium });
                    listFullMenu.Add(new WarriorWater { Size = Size.Medium });
                    listFullMenu.Add(new SailorSoda { ToStringProperty = "Medium Sailor Soda", Size = Size.Medium });
                }
                else
                {
                    listFullMenu.Add(new DragonbornWaffleFries { Size = Size.Large });
                    listFullMenu.Add(new FriedMiraak() { Size = Size.Large });
                    listFullMenu.Add(new MadOtarGrits() { Size = Size.Large });
                    listFullMenu.Add(new VokunSalad() { Size = Size.Large });

                    listFullMenu.Add(new AretinoAppleJuice { Size = Size.Large });
                    listFullMenu.Add(new CandlehearthCoffee { Size = Size.Large });
                    listFullMenu.Add(new MarkarthMilk { Size = Size.Large });
                    listFullMenu.Add(new WarriorWater { Size = Size.Large });
                    listFullMenu.Add(new SailorSoda { ToStringProperty = "Large Sailor Soda", Size = Size.Large });
                }
            }
            return listFullMenu;
        }
        /// <summary>
        /// private field of a collection of items
        /// </summary>
        private static List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Gets all the items in the database with the correct terms
        /// </summary>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return AllItems();

            foreach (IOrderItem item in AllItems())
            {
                if (item.ToString() != null && item.ToString().ToUpper().Contains(terms.ToUpper()))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Gets the possible Categories
        /// </summary>
        public static string[] Category
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",
            };
        }
        /// <summary>
        /// Filters the search results by Category
        /// </summary>
        /// <param name="items"></param>
        /// <param name="categories"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return items;
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if (categories.Contains("Entree") && item is Entree)
                {
                    results.Add(item);
                }
                if (categories.Contains("Side") && item is Side)
                {
                    results.Add(item);
                }
                if (categories.Contains("Drink") && item is Drink)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collection of items
        /// to those with a Price that falls within the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collection of items
        /// to those within the specified Caloric range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}

