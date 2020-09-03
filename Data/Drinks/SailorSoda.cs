/*
* Author: Robert Clancy
* Class name: SailorSoda.cs
* Purpose: Class used to represent an a glass of soda
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents a glass of soda
    /// </summary>
    public class SailorSoda
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
        /// flavor of the soda, default = cherry
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// property that gets and sets ets the flavor of the drink, default = cherry
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set => flavor = value;
        }

        /// <summary>
        /// property that gets and sets ets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.42;
                }
                if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else return 2.07;
            }
        }

        /// <summary>
        /// property that gets and sets ets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                if (Size == Size.Medium)
                {
                    return 153;
                }
                else return 205;
            }
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
        /// list that holds the instructions for the item ie.("Hold ketchup, Add ice, etc")
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns>string representing the size and name of the drink</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
        
    }
}
