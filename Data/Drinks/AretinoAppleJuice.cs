﻿/*
* Author: Robert Clancy
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent an apple juice drink 
*/


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;




namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents apple juice
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Size size = Size.Small;

        public override Size Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }
        /// <summary>
        /// Property that gets and sets the price of the drink
        /// </summary>
        public override double Price
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
        public override uint Calories
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
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }
            }
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
                if (instructions != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
