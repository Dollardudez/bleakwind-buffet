/*
* Author: Robert Clancy
* Class name: DragonBornWaffleFries.cs
* Purpose: Class used to represent Cajun fries
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class that represents an order of fries
    /// </summary>
    class DragonBornWaffleFries
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
                    return 0.42;
                }
                if (Size == Size.Medium)
                {
                    return 0.76;
                }
                else return 0.96;
            }
        }

        /// <summary>
        /// property that gets and sets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 77;
                }
                if (Size == Size.Medium)
                {
                    return 89;
                }
                else return 100;
            }
        }
        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns>string representing the size and name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
