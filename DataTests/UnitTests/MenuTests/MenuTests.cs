/*
 * Author: Robert Clancy
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
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

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void StaticMethodShouldReturnIOrderListWithAllEntrees()
        {
            List<IOrderItem> listEntrees = Menu.Entrees();
            Assert.Collection<IOrderItem>(listEntrees,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item));
        }

        [Fact]
        public void StaticMethodShouldReturnIOrderListWithAllSides()
        {
            List<IOrderItem> listSides = Menu.Sides();
            Assert.Collection<IOrderItem>(listSides,
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item));
        }

        [Fact]
        public void StaticMethodShouldReturnIOrderListWithAllDrinks()
        {
            List<IOrderItem> listDrinks = Menu.Drinks();
            Assert.Collection<IOrderItem>(listDrinks,
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),


                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item));
        }

        [Fact]
        public void StaticMethodShouldReturnIOrderListWithAllItems()
        {
            List<IOrderItem> listMenu = Menu.FullMenu();
            Assert.Collection<IOrderItem>(listMenu,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item));
        }
    }
}
