/*
 * Author: Robert Clancy
 * Class: PaymentViewOptions.cs
 * Purpose: Test the PaymentViewOptions.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Menu;
using System.Collections.Generic;
using System.ComponentModel;
using PointOfSale;

namespace BleakwindBuffet.DataTests.UnitTests.PointOfSaleTests
{
    public class PaymentViewOptionsTests
    {
        /// <summary>
        /// mock instance of a PaymentViewModel, where the order is worth $200
        /// </summary>
        PaymentViewModel pvm = new PaymentViewModel(100);

        [Fact]
        public void PaymentViewModelShouldBeAssignableFromINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pvm);
        }

        [Fact]
        public void AmuntDueShouldBeZeroByDefault()
        {
            pvm.ResetCashRegister();
            Assert.Equal(pvm.CurrentDue, 0);
        }

        [Fact]
        public void AllRegisterBillsShouldBeCorrectAmountByDefault()
        {
            pvm.ResetCashRegister();
            Assert.Equal(200, pvm.RegisterPennies);
            Assert.Equal(80, pvm.RegisterNickels);
            Assert.Equal(100, pvm.RegisterDimes);
            Assert.Equal(80, pvm.RegisterQuarters);
            Assert.Equal(20, pvm.RegisterOnes);
            Assert.Equal(4, pvm.RegisterFives);
            Assert.Equal(10, pvm.RegisterTens);
            Assert.Equal(5, pvm.RegisterTwenties);
            Assert.Equal(0, pvm.RegisterFifties);
            Assert.Equal(0, pvm.RegisterHundreds);
        }
        [Fact]
        public void AddingAnyCurrencyShouldNotifyMultipleProperties()
        {
            Assert.PropertyChanged(pvm, "Paid1C", () =>
            {
                pvm.Paid1C += 1;
            });
        }

        [Theory]
        [InlineData("Paid5C")]
        [InlineData("CurrentPayment")]
        [InlineData("IsPaidEnough")]
        [InlineData("AmountDue")]
        [InlineData("CurrentDue")]
        [InlineData("CurrentChangedDue")]
        public void AddingEntreeShouldNotifyPropertyChanges(string property)
        {
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.Paid1C = 200;
                pvm.Paid5C += 1;
                pvm.Paid10C += 1;
                pvm.Paid25C += 1;
                pvm.PaidOnes += 1;
                pvm.PaidFives += 1;
                pvm.PaidTens += 1;
                pvm.PaidTwenties++;
                pvm.PaidFifties++;
                pvm.PaidHundreds++;
            });
        }
    }
}
