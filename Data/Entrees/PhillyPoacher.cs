using System;
using System.Collections.Generic;
using System.Text;

namespace BleakWindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }
        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }

        private bool sirloin = true;
        public bool Sirloin
        {
            get => sirloin;
            set => sirloin = value;
        }

        private bool onion = true;
        public bool Onion
        {
            get => onion;
            set => onion = value;
        }

        private bool roll = true;
        public bool Roll
        {
            get => roll;
            set => roll = value;
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
