/*
 * Author: Robert Clancy
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Combo;
using BleakwindBuffet.Data.Enums;
using System;
using BleakwindBuffet.DataTests.UnitTests.EntreeTests;

namespace BleakwindBuffet.DataTests.UnitTests.ComboTests
{
    public class ComboTests
    {

        [Theory]
        [InlineData(typeof(BriarheartBurger), "Entree")]
        [InlineData(typeof(BriarheartBurger), "Calories")]
        [InlineData(typeof(BriarheartBurger), "Price")]
        [InlineData(typeof(BriarheartBurger), "SpecialInstructions")]
        public void AddingEntreeShouldNotifyPropertyChanges(Type type, string property)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, property, () =>
            {
                combo.Entree = entree;
            });
        }
        [Theory]
        [InlineData(typeof(AretinoAppleJuice), "Drink")]
        [InlineData(typeof(AretinoAppleJuice), "Calories")]
        [InlineData(typeof(AretinoAppleJuice), "Price")]
        [InlineData(typeof(AretinoAppleJuice), "SpecialInstructions")]
        public void AddingDrinkShouldNotifyPropertyChanges(Type type, string property)
        {
            Drink drink = (Drink)Activator.CreateInstance(type);
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, property, () =>
            {
                combo.Drink = drink;
            });
        }
        [Theory]
        [InlineData(typeof(DragonbornWaffleFries), "Side")]
        [InlineData(typeof(DragonbornWaffleFries), "Calories")]
        [InlineData(typeof(DragonbornWaffleFries), "Price")]
        [InlineData(typeof(DragonbornWaffleFries), "SpecialInstructions")]
        public void AddingSideShouldNotifyPropertyChanges(Type type, string property)
        {
            Side side = (Side)Activator.CreateInstance(type);
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, property, () =>
            {
                combo.Side = side;
            });
        }
        [Theory]
        [InlineData(typeof(VokunSalad), typeof(PhillyPoacher), typeof(SailorSoda), "Side", "Entree", "Drink")]
        public void AddingThreeItemsShouldNotifyPropertyChanges(Type type1, Type type2, Type type3, string property, string property2, string property3)
        {
            Side side = (Side)Activator.CreateInstance(type1);
            Entree entree = (Entree)Activator.CreateInstance(type2);
            Drink drink = (Drink)Activator.CreateInstance(type3);
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, property, () =>
            {
                combo.Side = side;
            }); Assert.PropertyChanged(combo, property2, () =>
            {
                combo.Entree = entree;
            });
            Assert.PropertyChanged(combo, property3, () =>
            {
                combo.Drink = drink;
            });
        }
        [Theory]
        [InlineData(typeof(Entree), "SpecialInstructions")]
        public void ChangingItemPriceShouldNotifyPropertyChanges(Type type, string property)
        {
            BriarheartBurger test = new BriarheartBurger();
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, property, () =>
            {
                combo.Entree = test;
            });
            test.Ketchup = false;
            Assert.PropertyChanged(combo, property, () =>
            {
                combo.Entree = test;
            });


        }
    }
}