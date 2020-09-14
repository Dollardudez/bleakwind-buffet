/*
* Author: Robert Clancy
* Class name: CandleheartCoffee.cs
* Purpose: Class used to represent a coffee drink
*/


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents coffee
    /// </summary>
    public class CandlehearthCoffee: Drink, IOrderItem
    {
            
        /// <summary>
        /// The size of the beverage
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Property that gets and sets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else return 1.75;
            }
        }

        /// <summary>
        /// Property that gets and sets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else return 20;
            }
        }
        /// <summary>
        /// true if ice is in the drink, false otherwise
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// property that gets and sets if the drink has ice or not, default = false
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }
        /// <summary>
        /// true if cream is in the drink, false otherwise
        /// </summary>
        private bool cream = false;
        /// <summary>
        /// property that gets and sets if the drink has cream or not, default = false
        /// </summary>
        public bool RoomForCream
        {
            get => cream;
            set => cream = value;
        }
        /// <summary>
        /// true if the coffee is decaf, false otherwise
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// property that gets and sets if the drink is decaf or not, default = false
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set => decaf = value;
        }
        /// <summary>
        /// list that holds the instructions for the item ie.("Hold ketchup, Add ice, etc")
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// property that gets the list of special instructions, no setter
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method. If the coffee is decaf, the method returns "{Size} Decaf Candlehearth Coffee"
        /// </summary>
        /// <returns>string representing the size and name of the drink</returns>
        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Candlehearth Coffee";
            return $"{Size} Candlehearth Coffee";
        }
    }
}
