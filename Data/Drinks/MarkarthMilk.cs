using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakWindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// The size of the beverage
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// property that gets and sets the size of the drink, default = small
        /// </summary>
        public Size Size
        {
            get => size;
            set => size = value;
        }

        /// <summary>
        /// Property that gets and sets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else return 1.22;
            }
        }

        /// <summary>
        /// Property that gets and sets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;
                }
                if (Size == Size.Medium)
                {
                    return 72;
                }
                else return 93;
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
            set => ice = value;
        }
        /// <summary>
        /// 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if(Ice) instructions.Add("Add ice");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method
        /// </summary>
        /// <returns>string representing the size and name of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
