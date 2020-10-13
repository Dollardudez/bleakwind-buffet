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





namespace BleakwindBuffet.DataTests.UnitTests.OrderTests
{
    public class OrderListTests
    {
        [Theory]
        [InlineData("Calories")]
        [InlineData("Total")]
        [InlineData("Tax")]
        [InlineData("Subtotal")]
        public void OrderAddingItemsShouldNotifyPropertyChange(string property)
        {
            OrderList order = new OrderList();
            AretinoAppleJuice item = new AretinoAppleJuice();
            Assert.PropertyChanged(order, property, () =>
            {
                order.Add(item);
            });
        }
    }
}