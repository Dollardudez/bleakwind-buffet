/*
* Author: Robert Clancy
* Class name: MadOtarGrits.cs
* Purpose: Class used to represent hash browns
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class that represents an order of grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// property that gets and sets ets the price of the side
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        /// list that holds the instructions for the item (Empty list for sides)
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
                return instructions;
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
