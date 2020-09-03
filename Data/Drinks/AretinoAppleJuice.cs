/*
* Author: Robert Clancy
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent an apple juice drink 
*/


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents apple juice
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// The size of the beverage
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// property that gets and sets the size of the drink, default = small
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// Property that gets and sets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.62;
                }
                else if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else return 1.01;
            }
        }

        /// <summary>
        /// Property that gets and sets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 44;
                }
                else if (Size == Size.Medium)
                {
                    return 88;
                }
                else return 132;
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
        /// list that holds the instructions for the item ie.("Hold ketchup, Add ice, etc")
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// property that gets the list of special instructions, no setter
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns>string representing the size and name of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
