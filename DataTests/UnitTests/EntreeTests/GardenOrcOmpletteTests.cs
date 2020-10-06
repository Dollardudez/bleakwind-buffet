/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ChangingBroccolipNotifiesBroccoliProperty()
        {
            var test = new GardenOrcOmelette();

            Assert.PropertyChanged(test, "Broccoli", () =>
            {
                test.Broccoli = false;
            });

            Assert.PropertyChanged(test, "Broccoli", () =>
            {
                test.Broccoli = true;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var test = new GardenOrcOmelette();

            Assert.PropertyChanged(test, "Mushrooms", () =>
            {
                test.Mushrooms = false;
            });

            Assert.PropertyChanged(test, "Mushrooms", () =>
            {
                test.Mushrooms = true;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var test = new GardenOrcOmelette();

            Assert.PropertyChanged(test, "Tomato", () =>
            {
                test.Tomato = false;
            });

            Assert.PropertyChanged(test, "Tomato", () =>
            {
                test.Tomato = true;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var test = new GardenOrcOmelette();

            Assert.PropertyChanged(test, "Cheddar", () =>
            {
                test.Cheddar = false;
            });

            Assert.PropertyChanged(test, "Cheddar", () =>
            {
                test.Cheddar = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(gorc);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(gorc);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Broccoli = false;
            Assert.False(gorc.Broccoli);
            gorc.Broccoli = true;
            Assert.True(gorc.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Mushrooms = false;
            Assert.False(gorc.Mushrooms);
            gorc.Mushrooms = true;
            Assert.True(gorc.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Tomato = false;
            Assert.False(gorc.Tomato);
            gorc.Tomato = true;
            Assert.True(gorc.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Cheddar = false;
            Assert.False(gorc.Cheddar);
            gorc.Cheddar = true;
            Assert.True(gorc.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.Equal(4.57, gorc.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            uint cal = 404;
            Assert.Equal(cal, gorc.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Broccoli = includeBroccoli;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", gorc.SpecialInstructions);
            else Assert.DoesNotContain("Hold broccoli", gorc.SpecialInstructions);
            gorc.Mushrooms = includeMushrooms;
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", gorc.SpecialInstructions);
            else Assert.DoesNotContain("Hold mushrooms", gorc.SpecialInstructions);
            gorc.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", gorc.SpecialInstructions);
            else Assert.DoesNotContain("Hold tomato", gorc.SpecialInstructions);
            gorc.Cheddar = includeCheddar;
            if (!includeCheddar) Assert.Contains("Hold cheddar", gorc.SpecialInstructions);
            else Assert.DoesNotContain("Hold cheddar", gorc.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", gorc.ToString());
        }
    }
}