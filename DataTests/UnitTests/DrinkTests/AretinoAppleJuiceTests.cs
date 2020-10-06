/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {


        [Fact]
        public void ChanginSizeNotifiesSizeProperty()
        {
            var test = new AretinoAppleJuice();

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
            var test = new AretinoAppleJuice();

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
            var test = new AretinoAppleJuice();

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
        public void ChangingIceNotifiesIceProperty()
        {
            var test = new AretinoAppleJuice();

            Assert.PropertyChanged(test, "Ice", () =>
            {
                test.Ice = true;
            });

            Assert.PropertyChanged(test, "Ice", () =>
            {
                test.Ice = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}