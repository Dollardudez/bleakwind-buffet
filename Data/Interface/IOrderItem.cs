using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Interface
{
    /// <summary>
    /// An interface indicating a menu item's price, calories, and special instructions
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// a property that defines an item's price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// a property that defines an item's calories
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// a property that defines an item's list of special instructions, if it has any
        /// </summary>
        List<string> SpecialInstructions { get;  }
    }
}
