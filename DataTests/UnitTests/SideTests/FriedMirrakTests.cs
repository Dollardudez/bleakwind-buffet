/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {

        [Fact]
        public void ChanginSizeNotifiesSizeProperty()
        {
            var test = new FriedMiraak();

            Assert.PropertyChanged(test, "Size", () =>
            {
                test.Size = Size.Large;
            });

            Assert.PropertyChanged(test, "Size", () =>
            {
                test.Size = Size.Medium;
            });

            Assert.PropertyChanged(test, "Size", () =>
            {
                test.Size = Size.Small;
            });

        }

        [Fact]
        public void ChanginSizeNotifiesPriceProperty()
        {
            var test = new FriedMiraak();

            Assert.PropertyChanged(test, "Price", () =>
            {
                test.Size = Size.Large;
            });

            Assert.PropertyChanged(test, "Price", () =>
            {
                test.Size = Size.Medium;
            });

            Assert.PropertyChanged(test, "Price", () =>
            {
                test.Size = Size.Small;
            });

        }

        [Fact]
        public void ChanginSizeNotifiesCaloriesProperty()
        {
            var test = new FriedMiraak();

            Assert.PropertyChanged(test, "Calories", () =>
            {
                test.Size = Size.Large;
            });

            Assert.PropertyChanged(test, "Calories", () =>
            {
                test.Size = Size.Medium;
            });

            Assert.PropertyChanged(test, "Calories", () =>
            {
                test.Size = Size.Small;
            });

        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
        }

        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }
    }
}