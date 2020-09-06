/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
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
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}