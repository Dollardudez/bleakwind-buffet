/*
 * Author:  Robert Clancy
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ItemDescriptionShouldBeCorrect()
        {
            WarriorWater placeholder = new WarriorWater();
            Assert.Equal("It’s water. Just water.", placeholder.Description);
        }
        [Fact]
        public void ChanginSizeNotifiesSizeProperty()
        {
            var test = new WarriorWater();

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
            var test = new SailorSoda();

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
        public void ChangingIceNotifiesIceProperty()
        {
            var test = new WarriorWater();

            Assert.PropertyChanged(test, "Ice", () =>
            {
                test.Ice = false;
            });

            Assert.PropertyChanged(test, "Ice", () =>
            {
                test.Ice = true;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var test = new WarriorWater();

            Assert.PropertyChanged(test, "Lemon", () =>
            {
                test.Lemon = true;
            });

            Assert.PropertyChanged(test, "Lemon", () =>
            {
                test.Lemon = false;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            if (includeIce) Assert.DoesNotContain("Hold ice", ww.SpecialInstructions);
            else Assert.Contains("Hold ice", ww.SpecialInstructions);
            ww.Lemon = includeLemon;
            if (includeLemon == true) Assert.Contains("Add lemon", ww.SpecialInstructions);
            else Assert.DoesNotContain("Add lemon", ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }
    }
}
