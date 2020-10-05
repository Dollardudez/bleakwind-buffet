/*
* Author: Robert Clancy
* Class name: Entree.cs
* Purpose: Class used to represent a base class for all Sides
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides

{
    public abstract class Side: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The size of the side
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public Size Size
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
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare with the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        
    }
}
