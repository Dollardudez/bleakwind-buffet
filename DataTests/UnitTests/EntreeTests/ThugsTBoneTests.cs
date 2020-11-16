/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ItemDescriptionShouldBeCorrect()
        {
            ThugsTBone placeholder = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", placeholder.Description);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tb);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(6.44, ttb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone ttb = new ThugsTBone();
            uint cal = 982;
            Assert.Equal(cal, ttb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Empty(ttb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", ttb.ToString());
        }
    }
}