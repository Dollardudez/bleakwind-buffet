/*
* Author: Robert Clancy
* Class name: IOrderItem.cs
* Purpose: Class used to represent an interface for all items on the menu
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Interface
{
    /// <summary>
    /// An interface indicating a menu item's price, calories, and special instructions
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
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
        string Description { get;}
    }
}
