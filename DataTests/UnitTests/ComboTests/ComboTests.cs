/*
 * Author: Robert Clancy
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;


namespace BleakwindBuffet.DataTests.UnitTests.ComboTests
{
    public class ComboTests
    {
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var test = new BriarheartBurger();

            Assert.PropertyChanged(test, "Ketchup", () =>
            {
                test.Ketchup = false;
            });

            Assert.PropertyChanged(test, "Ketchup", () =>
            {
                test.Ketchup = true;
            });
        }
    }
}