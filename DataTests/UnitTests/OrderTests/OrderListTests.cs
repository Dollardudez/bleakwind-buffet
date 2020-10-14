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

namespace BleakwindBuffet.DataTests.UnitTests.OrderTests
{
    public class OrderListTests
    {
        [Fact]
        public void ShouldHaveCorrectSubtotal()
        {
            OrderList order = new OrderList();
            order.Add(new BriarheartBurger());
            Assert.Equal<double>(6.32, order.Subtotal);
        }

        [Fact]
        public void ShouldHaveCorrectPriceSum()
        {
            OrderList order = new OrderList();
            order.Add(new BriarheartBurger());
            order.Add(new DoubleDraugr());
            order.Add(new MarkarthMilk() { Size = Size.Large });
            double sum = 6.32 + 7.32 + 1.22;
            sum = (Math.Round(sum, 2));
            Assert.Equal<double>(sum, order.Subtotal);
        }

        [Fact]
        public void PriceShouldBeZero()
        {
            OrderList order = new OrderList();
            Assert.Equal<double>(0, order.Subtotal);
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
            OrderList order = new OrderList();
            BriarheartBurger item = new BriarheartBurger();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }
    }
}