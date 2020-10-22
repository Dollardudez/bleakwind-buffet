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
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.ComboTests
{
    public class ComboTests
    {
        [Fact]
        public void AssignableFromIOrderItem()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

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
        public void ChangingItemInstrucionsShouldNotifyPropertyChanges(Type type, string property)
        {
            BriarheartBurger test = new BriarheartBurger();
            Combo combo = new Combo();
            combo.Entree = test;
            Assert.PropertyChanged(combo, property, () =>
            {
                test.Ketchup = false;
            });
        }

        [Fact]
        public void EntreePropertySettable()
        {
            Combo combo = new Combo();
            Entree test = new BriarheartBurger();
            combo.Entree = test;
            Assert.Equal(test, combo.Entree);
        }

        [Fact]
        public void DrinkPropertySettable()
        {
            Combo combo = new Combo();
            Drink test = new AretinoAppleJuice();
            combo.Drink = test;
            Assert.Equal(test, combo.Drink);
        }

        [Fact]
        public void SidePropertySettable()
        {
            Combo combo = new Combo();
            Side test = new VokunSalad();
            combo.Side = test;
            Assert.Equal(test, combo.Side);
        }
        [Fact]
        public void CorrectSpecialInstructionsProperty()
        {
            Combo combo = new Combo();
            BriarheartBurger entreeTest = new BriarheartBurger();
            VokunSalad sideTest = new VokunSalad();
            AretinoAppleJuice drinkTest = new AretinoAppleJuice();
            drinkTest.Size = Size.Large;
            drinkTest.Ice = true;
            sideTest.Size = Size.Large;
            combo.Entree = entreeTest;
            combo.Side = sideTest;
            combo.Drink = drinkTest;
            drinkTest.Ice = false;
            List<string> instructions = combo.SpecialInstructions;
            Assert.Collection(instructions,
                item => { Assert.Equal("Briarheart Burger", item); },
                item => { Assert.Equal("Large Aretino Apple Juice", item); },
                //item => { Assert.Equal("Add ice", item); },
                item => { Assert.Equal("Large Vokun Salad", item); }
            );
        }
    }
}