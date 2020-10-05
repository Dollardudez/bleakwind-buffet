/*
* Author: Robert Clancy
* Class name: PhillyPoacher.cs
* Purpose: Class used to represent a cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a cheesesteak
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public override double Price
        {
            get { return 7.23; }
        }
        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public override uint Calories
        {
            get { return 784; }
        }
        /// <summary>
        /// true if entree has sirloin, false otherwise
        /// </summary>
        private bool sirloin = true;
        /// <summary>
        /// property that gets and sets if the entree has sirloin or not, default = false
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                if (sirloin != value)
                {
                    sirloin = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                }
            }
        }
        /// <summary>
        /// true if entree has onion, false otherwise
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// property that gets and sets if the entree has onion or not, default = false
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                if (onion != value)
                {
                    onion = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                }
            }
        }
        /// <summary>
        /// true if entree has a roll, false otherwise
        /// </summary>
        private bool roll = true;
        /// <summary>
        /// property that gets and sets if the entree has roll or not, default = false
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                if (roll != value)
                {
                    roll = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
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
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                if (instructions != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method and displays the name of the entree
        /// </summary>
        /// <returns>string representing the name of the entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
