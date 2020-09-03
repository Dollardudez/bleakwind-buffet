/*
* Author: Robert Clancy
* Class name: MadOtarGrits.cs
* Purpose: Class used to represent hash browns
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class that represents an order of grits
    /// </summary>
    class MadOtarGrits
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
                    return 1.22;
                }
                if (Size == Size.Medium)
                {
                    return 1.58;
                }
                else return 1.93;
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
                    return 105;
                }
                if (Size == Size.Medium)
                {
                    return 142;
                }
                else return 179;
            }
        }
        /// <summary>
        /// overrides the ToString() method and displays the size and name of the side
        /// </summary>
        /// <returns>string representing the size and name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
