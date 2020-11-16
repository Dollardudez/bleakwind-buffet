/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ItemDescriptionShouldBeCorrect()
        {
            VokunSalad placeholder = new VokunSalad();
            Assert.Equal("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.", placeholder.Description);
        }

        [Fact]
        public void ChanginSizeNotifiesSizeProperty()
        {
            var test = new VokunSalad();

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
            var test = new VokunSalad();

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
            var test = new VokunSalad();

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
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }

        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vk = new VokunSalad();
            Assert.Equal(Size.Small, vk.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vk = new VokunSalad();
            vk.Size = Size.Large;
            Assert.Equal(Size.Large, vk.Size);
            vk.Size = Size.Medium;
            Assert.Equal(Size.Medium, vk.Size);
            vk.Size = Size.Small;
            Assert.Equal(Size.Small, vk.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vk = new VokunSalad();
            Assert.Empty(vk.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vk = new VokunSalad();
            vk.Size = size;
            Assert.Equal(price, vk.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vk = new VokunSalad();
            vk.Size = size;
            Assert.Equal(calories, vk.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vk = new VokunSalad();
            vk.Size = size;
            Assert.Equal(name, vk.ToString());
        }
    }
}