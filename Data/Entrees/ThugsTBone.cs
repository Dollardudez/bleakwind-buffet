using System;
using System.Collections.Generic;
using System.Text;

namespace BleakWindBuffet.Data.Entrees
{
    class ThugsT_Bone
    {
        /// <summary>
        /// Gets the price of the steak
        /// </summary>
        public double Price
        {
            get { return 6.44; }
        }
        /// <summary>
        /// Gets the calories of the steak
        /// </summary>
        public uint Calories
        {
            get { return 982; }
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
                return instructions;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
