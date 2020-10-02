/*
* Author: Robert Clancy
* Class name: Entree.cs
* Purpose: Class used to represent a base class for all Sides
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides

{
    public abstract class Side
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }
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
