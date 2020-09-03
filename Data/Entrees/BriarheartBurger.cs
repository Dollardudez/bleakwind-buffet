/*
* Author: Robert Clancy
* Class name: BriarheartBurger.cs
* Purpose: Class used to represent a single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakWindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price { 
            get { return 6.32; } 
        }
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories
        {
            get { return 743; }
        }
        /// <summary>
        /// true if entree has ketchup, false otherwise
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// property that gets and sets if the entree has ketchup or not, default = true
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;
        }
        /// <summary>
        /// true if entree has a bun, false otherwise
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// property that gets and sets if the entree has a bun or not, default = false
        /// </summary>
        public bool Bun {
            get => bun;
            set => bun = value;
        }
        /// <summary>
        /// true if entree has mustard, false otherwise
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// property that gets and sets if the entree mustard or not, default = false
        /// </summary>
        public bool Mustard { 
            get => mustard;
            set => mustard = value;
        }
        /// <summary>
        /// true if entree has pickles, false otherwise
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// property that gets and sets if the entree has pickle or not, default = false
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }
        /// <summary>
        /// true if entree has cheese, false otherwise
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// property that gets and sets if the entree has cheese or not, default = false
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }
        /// <summary>
        /// list that holds the instructions for the item ie.("Hold ketchup, Add ice, etc")
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// property that gets the list of special instructions, no setter
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold kethup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method and displays the name of the entree
        /// </summary>
        /// <returns>string representing the name of the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
