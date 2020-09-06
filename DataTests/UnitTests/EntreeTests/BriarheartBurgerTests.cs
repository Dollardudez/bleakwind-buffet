/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
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
        public void ShouldReturnCorrectPrice()
        {
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}