/*
* Author: Robert Clancy
* Class name: ThugsTBone.cs
* Purpose: Class used to represent a Juicy T-Bone
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a steak
    /// </summary>
    public class ThugsTBone: Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the steak
        /// </summary>
        public override double Price
        {
            get { return 6.44; }
        }
        /// <summary>
        /// Gets the calories of the steak
        /// </summary>
        public override uint Calories
        {
            get { return 982; }
        }
        /// <summary>
        /// list that holds the instructions for the item
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
        /// overrides the ToString() method and displays the name of the entree
        /// </summary>
        /// <returns>string representing the name of the entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
