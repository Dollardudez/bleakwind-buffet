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
        [InlineData("CurrentPayment")]
        [InlineData("IsPaidEnough")]
        [InlineData("AmountDue")]
        [InlineData("CurrentDue")]
        public void ChangingAnyCurrencyShouldNotifyPropertyChanged(string property)
        {
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.Paid1C += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.Paid5C += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.Paid10C += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.Paid25C += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.PaidOnes += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.PaidFives += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.PaidTens += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.PaidTwenties += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.PaidFifties += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.PaidHundreds += 1;
            });
        }
        [Theory]
        [InlineData("CurrentChangeDue")]
        public void ChangingAnyChangeCurrencyShouldNotifyPropertyChanged(string property)
        {
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangePennies += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeNickels += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeDimes += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeQuarters += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeOnes += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeFives += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeTens += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeTwenties += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeFifties += 1;
            });
            Assert.PropertyChanged(pvm, property, () =>
            {
                pvm.ChangeHundreds += 1;
            });
        }
        [Fact]
        public void ChangingPaidOrChangeCurrencyShouldChangeRegisterCurrency()
        {
            pvm.ResetCashRegister();
            pvm.ChangePennies++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterPennies, 199);
            pvm.ResetCashRegister();
            pvm.Paid1C++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterPennies, 200);
            pvm.ResetCashRegister();
            pvm.ChangeNickels++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterNickels, 79);
            pvm.ResetCashRegister();
            pvm.Paid5C++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterNickels, 80);
            pvm.ResetCashRegister();
            pvm.ChangeDimes++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterDimes, 99);
            pvm.ResetCashRegister();
            pvm.Paid10C++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterDimes, 100);
            pvm.ResetCashRegister();
            pvm.ChangeQuarters++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterQuarters, 79);
            pvm.ResetCashRegister();
            pvm.Paid25C++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterQuarters, 80);
            pvm.ResetCashRegister();

            pvm.ChangeOnes++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterOnes, 19);
            pvm.ResetCashRegister();
            pvm.PaidOnes++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterOnes, 20);
            pvm.ResetCashRegister();
            pvm.ChangeFives++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterFives, 3);
            pvm.ResetCashRegister();
            pvm.PaidFives++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterFives, 4);
            pvm.ResetCashRegister();
            pvm.ChangeTens++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterTens, 9);
            pvm.ResetCashRegister();
            pvm.PaidTens++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterTens, 10);
            pvm.ResetCashRegister();
            pvm.ChangeTwenties++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterTwenties, 4);
            pvm.ResetCashRegister();
            pvm.PaidTwenties++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterTwenties, 5);
            pvm.ResetCashRegister();
            pvm.ChangeFifties++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterFifties, -1);
            pvm.ResetCashRegister();
            pvm.PaidFifties++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterFifties, 0);
            pvm.ResetCashRegister();
            pvm.ChangeHundreds++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterHundreds, -1);
            pvm.ResetCashRegister();
            pvm.PaidHundreds++;
            pvm.FinishSale();
            Assert.Equal(pvm.RegisterHundreds, 1);
        }
    }
}
