/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
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
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}