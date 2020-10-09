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
    class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private IOrderItem entree;
        public IOrderItem Entree
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


        private IOrderItem side;
        public IOrderItem Side
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


        private IOrderItem drink;
        public IOrderItem Drink
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
        private double price;
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

        private uint calories;
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
