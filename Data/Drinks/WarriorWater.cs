/*
* Author: Robert Clancy
* Class name: WarriorWater.cs
* Purpose: Class used to represent a glass of water
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakWindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// The size of the beverage
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// property that gets and sets ets the size of the drink, default = small
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// property that gets and sets ets the price of the drink
        /// </summary>
        public double Price
        {
            get => 0.00;          
        }

        /// <summary>
        /// property that gets and sets ets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get => 0;
        }
        /// <summary>
        /// true if ice is in the drink, false otherwise
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// property that gets and sets if the drink has ice or not, default = false
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }
        /// <summary>
        /// true if lemon is in the drink, false otherwise
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// property that gets and sets if the drink has lemons or not, default = false
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set => lemon = value;
        }
        /// <summary>
        /// list that holds the instructions for the item ie.("Hold ketchup, Add ice, etc")
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns>string representing the size and name of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}

