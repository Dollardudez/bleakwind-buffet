/*
* Author: Robert Clancy
* Class name: CandleheartCoffee.cs
* Purpose: Class used to represent a coffee drink
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
    /// class that represents coffee
    /// </summary>
    public class CandlehearthCoffee: Drink,IOrderItem, INotifyPropertyChanged
    {
        private string description = "Fair trade, fresh ground dark roast coffee.";
        public string Description
        {
            get => description;
        }
        /// <summary>
        /// A public event property that is invoked when any property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// private backing variable for the Size Property, default = Size.Small
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Size Propert. get returns the value of the size backing variable, and
        /// set changes the size and invokes a PropertyChangedEvent on the PropertyChanged Property
        /// </summary>
        public override Size Size
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToStringProperty"));
                }
            }
        }
        /// <summary>
        /// Property that gets and sets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else return 1.75;
            }
        }

        /// <summary>
        /// Property that gets and sets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else return 20;
            }
        }
        /// <summary>
        /// true if ice is in the drink, false otherwise
        /// </summary>
        private bool ice = false;
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        /// <summary>
        /// true if cream is in the drink, false otherwise
        /// </summary>
        private bool cream = false;
        /// <summary>
        /// property that gets and sets if the drink has cream or not, default = false
        /// </summary>
        public bool RoomForCream
        {
            get => cream;
            set
            {
                if (cream != value)
                {
                    cream = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
        /// <summary>
        /// true if the coffee is decaf, false otherwise
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// property that gets and sets if the drink is decaf or not, default = false
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToStringProperty"));
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
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method. If the coffee is decaf, the method returns "{Size} Decaf Candlehearth Coffee"
        /// </summary>
        /// <returns>string representing the size and name of the drink</returns>
        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Candlehearth Coffee";
            return $"{Size} Candlehearth Coffee";
        }
        private string tosringproperty;
        /// <summary>
        /// property that returns the name of the item, used for the Point of Sale portion of the project.
        /// </summary>
        public override string ToStringProperty
        {
            get => ToString();
            set => value = tosringproperty;
        }
    }
}
