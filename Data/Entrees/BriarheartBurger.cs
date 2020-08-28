using System;
using System.Collections.Generic;
using System.Text;

namespace BleakWindBuffet.Data.Entrees
{
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

        private bool ketchup = true;

        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;
        }

        private bool bun = true;
        public bool Bun {
            get => bun;
            set => bun = value;
        }

        private bool mustard = true;
        public bool Mustard { 
            get => mustard;
            set => mustard = value;
        }

        private bool pickle = true;
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }

        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }

        private List<string> specialInstructions = new List<string>();
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

        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
