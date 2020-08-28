using System;
using System.Collections.Generic;
using System.Text;

namespace BleakWindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public double Price
        {
            get { return 5.62; }
        }
        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public uint Calories
        {
            get { return 602; }
        }

        private bool sausagelink = true;
        public bool SausageLink
        {
            get => sausagelink;
            set => sausagelink = value;
        }

        private bool egg = true;
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }

        private bool hashbrowns = true;
        public bool Hashbrowns
        {
            get => hashbrowns;
            set => hashbrowns = value;
        }

        private bool pancake = true;
        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!Hashbrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancake");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
