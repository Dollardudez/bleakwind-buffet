using System;
using System.Collections.Generic;
using System.Text;

namespace BleakWindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the breakfast meal
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }
        /// <summary>
        /// Gets the calories of the breakfast meal
        /// </summary>
        public uint Calories
        {
            get { return 404; }
        }

        private bool broccoli = true;
        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }

        private bool mushrooms = true;
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;
        }

        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }

        private bool cheddar = true;
        public bool Cheddar
        {
            get => cheddar;
            set => cheddar = value;
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
