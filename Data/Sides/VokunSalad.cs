﻿/*
* Author: Robert Clancy
* Class name: VokunSalad.cs
* Purpose: Class used to represent a fruit salad
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
/// class that represents a fruit salad
/// </summary>
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// A description of the item, to be displayed on the website
        /// </summary>
        private string description = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
        public string Description
        {
            get => description;
        }
        /// <summary>
        /// property that gets and sets ets the price of the side
        /// </summary>
        public override double Price
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
        public override uint Calories
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
            return $"{Size} Vokun Salad";
        }
        /// <summary>
        /// property that returns the name of the item, used for the Point of Sale portion of the project.
        /// </summary>
        public override string ToStringProperty
        {
            get => ToString();
        }
    }
}