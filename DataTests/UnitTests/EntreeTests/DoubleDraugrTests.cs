/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ItemDescriptionShouldBeCorrect()
        {
            DoubleDraugr placeholder = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", placeholder.Description);
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var test = new DoubleDraugr();

            Assert.PropertyChanged(test, "Ketchup", () =>
            {
                test.Ketchup = false;
            });

            Assert.PropertyChanged(test, "Ketchup", () =>
            {
                test.Ketchup = true;
            });
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var test = new DoubleDraugr();

            Assert.PropertyChanged(test, "Bun", () =>
            {
                test.Bun = false;
            });

            Assert.PropertyChanged(test, "Bun", () =>
            {
                test.Bun = true;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var test = new DoubleDraugr();

            Assert.PropertyChanged(test, "Mustard", () =>
            {
                test.Mustard = false;
            });

            Assert.PropertyChanged(test, "Mustard", () =>
            {
                test.Mustard = true;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var test = new DoubleDraugr();

            Assert.PropertyChanged(test, "Pickle", () =>
            {
                test.Pickle = false;
            });

            Assert.PropertyChanged(test, "Pickle", () =>
            {
                test.Pickle = true;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var test = new DoubleDraugr();

            Assert.PropertyChanged(test, "Cheese", () =>
            {
                test.Cheese = false;
            });

            Assert.PropertyChanged(test, "Cheese", () =>
            {
                test.Cheese = true;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var test = new DoubleDraugr();

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
        public void ChangingPLettuceNotifiesLettuceProperty()
        {
            var test = new DoubleDraugr();

            Assert.PropertyChanged(test, "Lettuce", () =>
            {
                test.Lettuce = false;
            });

            Assert.PropertyChanged(test, "Lettuce", () =>
            {
                test.Lettuce = true;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var test = new DoubleDraugr();

            Assert.PropertyChanged(test, "Mayo", () =>
            {
                test.Mayo = false;
            });

            Assert.PropertyChanged(test, "Mayo", () =>
            {
                test.Mayo = true;
            });
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            uint cal = 843;
            Assert.Equal(cal, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold bun", dd.SpecialInstructions);
            dd.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold ketchup", dd.SpecialInstructions);
            dd.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold mustard", dd.SpecialInstructions);
            dd.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold pickle", dd.SpecialInstructions);
            dd.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold cheese", dd.SpecialInstructions);
            dd.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold tomato", dd.SpecialInstructions);
            dd.Lettuce = includeLettuce;
            if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold lettuce", dd.SpecialInstructions);
            dd.Mayo = includeMayo;
            if (!includeMayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold mayo", dd.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }
    }
}