/*
* Author: Robert Clancy
* Class name: GardenOrcOmelette.cs
* Purpose: Class used to represent a vegetarian, two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a a veggie omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the price of the breakfast meal
        /// </summary>
        public override double Price
        {
            get { return 4.57; }
        }
        /// <summary>
        /// Gets the calories of the breakfast meal
        /// </summary>
        public override uint Calories
        {
            get { return 404; }
        }
        /// <summary>
        /// true if entree has broccoli, false otherwise
        /// </summary>
        private bool broccoli = true;
        /// <summary>
        /// property that gets and sets if the broccoli has cheese or not, default = false
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                if (broccoli != value)
                {
                    broccoli = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                }
            }
        }
        /// <summary>
        /// true if entree has mushrooms, false otherwise
        /// </summary>
        private bool mushrooms = true;
        /// <summary>
        /// property that gets and sets if the entree has mushrooms or not, default = false
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                }
            }
        }
        /// <summary>
        /// true if entree has tomato, false otherwise
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// property that gets and sets if the entree has tomato or not, default = false
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                }
            }
        }
        /// <summary>
        /// true if entree has cheddar, false otherwise
        /// </summary>
        private bool cheddar = true;
        /// <summary>
        /// property that gets and sets if the entree has cheddar or not, default = false
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
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
            return "Garden Orc Omelette";
        }
    }
}
