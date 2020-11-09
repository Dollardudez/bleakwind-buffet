/*
 * Author: Robert Clancy
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
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
    }
}
