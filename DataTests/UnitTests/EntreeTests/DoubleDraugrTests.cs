/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}