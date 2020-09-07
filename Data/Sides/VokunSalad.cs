/*
* Author: Robert Clancy
* Class name: VokunSalad.cs
* Purpose: Class used to represent a fruit salad
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class that represents a fruit salad
    /// </summary>
    public class VokunSalad
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
        /// property that gets and sets ets the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.93;
                }
                if (Size == Size.Medium)
                {
                    return 1.28;
                }
                else return 1.82;
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
                    return 41;
                }
                if (Size == Size.Medium)
                {
                    return 52;
                }
                else return 73;
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
            return $"{Size} Vokun Salad";
        }
    }
}
