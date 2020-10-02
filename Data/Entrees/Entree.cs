/*
* Author: Robert Clancy
* Class name: Entree.cs
* Purpose: Class used to represent a base class for all Entrees
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare with the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        
    }
}
