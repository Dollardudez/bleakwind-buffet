/*
* Author: Robert Clancy
* Class name: WarriorWater.cs
* Purpose: Class used to represent a glass of water
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
    /// class that represents a glass of water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
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
                }
            }
        }

        /// <summary>
        /// property that gets and sets ets the price of the drink
        /// </summary>
        public override double Price
        {
            get => 0.00;          
        }

        /// <summary>
        /// property that gets and sets ets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get => 0;
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
        /// true if lemon is in the drink, false otherwise
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// property that gets and sets if the drink has lemons or not, default = false
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                if (lemon != value)
                {
                    lemon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                }
            }
        }
        /// <summary>
        /// list that holds the instructions for the item ie.("Hold ketchup, Add ice, etc")
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Lemon) instructions.Add("Add lemon");
                if (!Ice) instructions.Add("Hold ice");
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
            return $"{Size} Warrior Water";
        }
    }
}

