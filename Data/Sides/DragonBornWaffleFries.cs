/*
* Author: Robert Clancy
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent Cajun fries
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
    /// class that represents an order of fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
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
        public override uint Calories
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
        /// overrides the ToString() method
        /// </summary>
        /// <returns>string representing the size and name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
