/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
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
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}