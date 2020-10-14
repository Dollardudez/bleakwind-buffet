/*
 * Author: Robert Clancy
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Order;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Reflection.Metadata;
using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.OrderTests
{
    public class OrderListTests
    {

        [Fact]
        public void IsAssignableCollectionChanged()
        {
            OrderList test = new OrderList();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(test);
        }

        [Fact]
        public void IsAssignablePropertyChanged()
        {
            OrderList test = new OrderList();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }

        [Fact]
        public void ShouldHaveCorrectSubtotal()
        {
            OrderList test = new OrderList();
            test.Add(new BriarheartBurger());
            Assert.Equal<double>(6.32, test.Subtotal);
        }

        [Fact]
        public void TaxRateSettable()
        {
            OrderList test = new OrderList();
            Assert.Equal(.12, test.SalesTaxRate);
            test.SalesTaxRate = .5;
            Assert.Equal(.5, test.SalesTaxRate);
        }

        [Fact]
        public void ShouldHaveCorrectPriceSum()
        {
            OrderList test = new OrderList();
            test.Add(new BriarheartBurger());
            test.Add(new DoubleDraugr());
            test.Add(new MarkarthMilk() { Size = Size.Large });
            double sum = 6.32 + 7.32 + 1.22;
            sum = (Math.Round(sum, 2));
            Assert.Equal<double>(sum, test.Subtotal);
        }

        [Fact]
        public void StartingPriceShouldBeZero()
        {
            OrderList test = new OrderList();
            Assert.Equal<double>(0, test.Subtotal);
            OrderList order2 = new OrderList();
            order2.Add(new WarriorWater());
            Assert.Equal<double>(0, order2.Subtotal);
        }

        [Theory]
        [InlineData("Items")]
        [InlineData("Total")]
        [InlineData("Tax")]
        [InlineData("Subtotal")]
        public void OrderRemovingItemsShouldNotifyPropertyChange(string propertyName)
        {
            OrderList test = new OrderList();
            BriarheartBurger item = new BriarheartBurger();
            test.Add(item);
            Assert.PropertyChanged(test, propertyName, () =>
            {
                test.Remove(item);
            });
        }

        [Theory]
        [InlineData("Items")]
        [InlineData("Total")]
        [InlineData("Tax")]
        [InlineData("Subtotal")]
        public void OrderAddingItemsShouldNotifyPropertyChange(string propertyName)
        {
            OrderList test = new OrderList();
            BriarheartBurger item = new BriarheartBurger();
            test.Add(item);
            Assert.PropertyChanged(test, propertyName, () =>
            {
                test.Add(item);
            });
        }

        [Fact]
        public void NewOrderIncrementsOrderNumber()
        {
            OrderList test = new OrderList();
            int initialNumber = test.Number;
            test = new OrderList();
            Assert.Equal(initialNumber + 1, test.Number);
            test = new OrderList();
            Assert.Equal(initialNumber + 2, test.Number);
        }
    }
}