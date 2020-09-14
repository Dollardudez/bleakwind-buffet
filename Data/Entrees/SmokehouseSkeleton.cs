/*
* Author: Robert Clancy
* Class name: SmokehouseSkeleton.cs
* Purpose: Class used to represent a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a a breakfast combo
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public override double Price
        {
            get { return 5.62; }
        }
        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
        }
        /// <summary>
        /// true if entree has a sausage, false otherwise
        /// </summary>
        private bool sausagelink = true;
        /// <summary>
        /// property that gets and sets if the entree has sausages or not, default = false
        /// </summary>
        public bool SausageLink
        {
            get => sausagelink;
            set => sausagelink = value;
        }
        /// <summary>
        /// true if entree has a egg, false otherwise
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// property that gets and sets if the entree has egg or not, default = false
        /// </summary>
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }
        /// <summary>
        /// true if entree has hashbrowns, false otherwise
        /// </summary>
        private bool hashbrowns = true;
        /// <summary>
        /// property that gets and sets if the entree has hashbrowns or not, default = false
        /// </summary>
        public bool Hashbrowns
        {
            get => hashbrowns;
            set => hashbrowns = value;
        }
        //true if entree has a pancake, false otherwise
        private bool pancake = true;
        /// <summary>
        /// property that gets and sets if the entree has pancake or not, default = false
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
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
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!Hashbrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }
        /// <summary>
        /// overrides the ToString() method and displays the name of the entree
        /// </summary>
        /// <returns>string representing the name of the entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
