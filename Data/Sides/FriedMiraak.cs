/*
* Author: Robert Clancy
* Class name: FriedMirak.cs
* Purpose: Class used to represent cheesy grits
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// /// <summary>
    /// class that represents an order of cheesy grits
    /// </summary>
    /// </summary>
    public class FriedMiraak
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// property that gets and sets ets the size of the side, default = small
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// property that gets and sets the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.78;
                }
                if (Size == Size.Medium)
                {
                    return 2.01;
                }
                else return 2.88;
            }
        }

        /// <summary>
        /// property that gets and sets ets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 151;
                }
                if (Size == Size.Medium)
                {
                    return 236;
                }
                else return 306;
            }
        }
        /// <summary>
        /// list that holds the instructions for the item (Empty list for sides)
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
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns>string representing the size and name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
