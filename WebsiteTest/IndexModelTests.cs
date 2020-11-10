/*
 * Author: Robert Clancy
 * Class: IndexModelTests.cs
 * Purpose: Test the IndexModel.cshtml.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Menu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing.IndexedProperties;

namespace WebsiteTest
{
    public class IndexModelTests
    {
        [Fact]
        public void CaloriesFormShouldBeNullByDefault()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            Assert.Null(indexModel.CaloriesMin);
            Assert.Null(indexModel.CaloriesMax);
        }
        [Fact]
        public void PriceFormShouldBeNullByDefault()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            Assert.Null(indexModel.PriceMin);
            Assert.Null(indexModel.PriceMax);
        }
        [Fact]
        public void CategoriesFormShouldBeNullByDefault()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            Assert.Null(indexModel.Categories);
        }
        [Fact]
        public void ItemsShouldBeNullByDefault()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            Assert.Null(indexModel.Items);
        }
        [Fact]
        public void ItemsShouldHoldEntreesWhenCategoryIsEntree()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[] { "Entree"};
            indexModel.OnGet("", categories, 0, 2000, 0, 2000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item));
        }
        [Fact]
        public void ItemsShouldHoldSidesWhenCategoryIsSide()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[] { "Side" };
            indexModel.OnGet("", categories, 0, 2000, 0, 2000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item));
        }
        [Fact]
        public void ItemsShouldHoldDrinksWhenCategoryIsDrinks()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[] { "Drink" };
            indexModel.OnGet("", categories, 0, 2000, 0, 2000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item));
        }
        [Fact]
        public void ItemsShouldHoldAllItemsWhenCategoryIsAllItems()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[] { "Entree", "Side","Drink" };
            indexModel.OnGet("", categories, 0, 2000, 0, 2000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,

                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item));
        }
        [Fact]
        public void ItemsShouldHoldAllItemsWhenNoCategoryIsSelected()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[0];
            indexModel.OnGet("", categories, 0, 2000, 0, 2000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,

                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item));
        }
        [Fact]
        public void ItemsShouldHoldCorrectEntreesWhenMinMaxCaloriesIsSet()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[0];
            indexModel.OnGet("", categories, 0, 1000, 200, 500);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<SailorSoda>(item));
        }
        [Fact]
        public void ItemsShouldHoldCorrectEntreesWhenOnlyMaxCaloriesIsSet()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[0];
            indexModel.OnGet("", categories, 0, 1000, null, 200);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item));
        }
        [Fact]
        public void ItemsShouldHoldCorrectEntreesWhenOnlyMinCaloriesIsSet()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[0];
            indexModel.OnGet("", categories, 0, 1000, 300, null);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),

                item => Assert.IsType<FriedMiraak>(item));
        }
        [Fact]
        public void ItemsShouldHoldCorrectEntreesWhenMinMaxPriceIsSet()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[0];
            double min = 2;
            double max = 7;
            indexModel.OnGet("", categories, min, max, 0, 1000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThugsTBone>(item),

                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<FriedMiraak>(item),

                item => Assert.IsType<SailorSoda>(item));
        }
        [Fact]
        public void ItemsShouldHoldCorrectEntreesWhenOnlyMaxPriceIsSet()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            string[] categories = new string[0];
            double max = 4;
            indexModel.OnGet("", categories, null, max, 0, 1000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item));
        }
        [Fact]
        public void ItemsShouldHoldCorrectEntreesWhenOnlyMinPriceIsSet()
        {
            Website.Pages.IndexModel indexModel = new Website.Pages.IndexModel();
            double min = 4;
            string[] categories = new string[0];
            indexModel.OnGet("", categories, min, null, 0, 1000);
            indexModel.Items = Menu.FilterByCategory(indexModel.Items, indexModel.Categories);
            Assert.Collection<IOrderItem>(indexModel.Items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item));
        }
    }
}
