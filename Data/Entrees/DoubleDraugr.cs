using System;
using System.Collections.Generic;
using System.Text;

namespace BleakWindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price
        {
            get { return 7.32; }
        }
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories
        {
            get { return 843; }
        }

        private bool ketchup = true;

        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;
        }

        private bool bun = true;
        public bool Bun
        {
            get => bun;
            set => bun = value;
        }

        private bool mustard = true;
        public bool Mustard
        {
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

        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }

        private bool lettuce = true;
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value;
        }

        private bool mayo = true;
        public bool Mayo
        {
            get => mayo;
            set => mayo = value;
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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
