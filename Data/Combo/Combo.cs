/*
* Author: Robert Clancy
* Class name: Combo.cs
* Purpose: Class used to represent aa combo meal
*/


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Combo
{
    /// <summary>
    /// class used to represent a combo
    /// </summary>
    class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variable
        /// </summary>
        private Entree entree;
        /// <summary>
        /// Property to represent an entree
        /// </summary>
        public Entree Entree
        {
            get => entree;
            set
            {
                if (entree != value)
                {
                    entree = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// private Drink backing variable.
        /// </summary>
        private Side side;
        /// <summary>
        /// Property to represent a Drink
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                if (side != value)
                {
                    side = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// private Drink backing variable
        /// </summary>
        private Drink drink;
        /// <summary>
        /// Property to represent a Drink
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                if (drink != value)
                {
                    drink = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        /// <summary>
        /// private Price backing variable
        /// </summary>
        private double price;
        /// <summary>
        /// Variable to represent the Price of the combo
        /// </summary>
        public double Price
        {
            get => price;
            set
            {
                if (price != Drink.Price + Entree.Price + Side.Price)
                {
                    price = Drink.Price + Entree.Price + Side.Price - 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        /// <summary>
        /// private calories backing variable
        /// </summary>
        private uint calories;
        /// <summary>
        /// Property to represent the calories of the combo
        /// </summary>
        public uint Calories
        {
            get => calories;
            set
            {
                if (calories != Drink.Calories + Entree.Calories + Side.Calories)
                {
                    calories = Drink.Calories + Entree.Calories + Side.Calories;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(Entree.ToString());
                foreach(string item in Entree.SpecialInstructions)
                {
                    instructions.Add(item);
                }
                instructions.Add(Drink.ToString());
                foreach (string item in Drink.SpecialInstructions)
                {
                    instructions.Add(item);
                }
                instructions.Add(Side.ToString());
                foreach (string item in Side.SpecialInstructions)
                {
                    instructions.Add(item);
                }
                return instructions;
            }
        }
    }
}
