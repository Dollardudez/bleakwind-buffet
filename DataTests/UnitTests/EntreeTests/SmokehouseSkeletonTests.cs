/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ItemDescriptionShouldBeCorrect()
        {
            SmokehouseSkeleton placeholder = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", placeholder.Description);
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            var test = new SmokehouseSkeleton();

            Assert.PropertyChanged(test, "SausageLink", () =>
            {
                test.SausageLink = false;
            });

            Assert.PropertyChanged(test, "SausageLink", () =>
            {
                test.SausageLink = true;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var test = new SmokehouseSkeleton();

            Assert.PropertyChanged(test, "Pancake", () =>
            {
                test.Pancake = false;
            });

            Assert.PropertyChanged(test, "Pancake", () =>
            {
                test.Pancake = true;
            });
        }

        [Fact]
        public void ChangingHashbrownsNotifiesHashbrownsProperty()
        {
            var test = new SmokehouseSkeleton();

            Assert.PropertyChanged(test, "Hashbrowns", () =>
            {
                test.Hashbrowns = false;
            });

            Assert.PropertyChanged(test, "Hashbrowns", () =>
            {
                test.Hashbrowns = true;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var test = new SmokehouseSkeleton();

            Assert.PropertyChanged(test, "Egg", () =>
            {
                test.Egg = false;
            });

            Assert.PropertyChanged(test, "Egg", () =>
            {
                test.Egg = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Hashbrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Hashbrowns = false;
            Assert.False(ss.Hashbrowns);
            ss.Hashbrowns = true;
            Assert.True(ss.Hashbrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            uint cal = 602;
            Assert.Equal(cal, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            else Assert.DoesNotContain("Hold sausage", ss.SpecialInstructions);
            ss.Egg = includeEgg;
            if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            else Assert.DoesNotContain("Hold eggs", ss.SpecialInstructions);
            ss.Hashbrowns = includeHashbrowns;
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            else Assert.DoesNotContain("Hold hash browns", ss.SpecialInstructions);
            ss.Pancake = includePancake;
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            else Assert.DoesNotContain("Hold pancakes", ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
    }
}