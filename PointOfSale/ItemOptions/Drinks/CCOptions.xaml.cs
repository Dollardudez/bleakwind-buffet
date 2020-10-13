/*
* Author: Robert Clancy
* Class name: CCOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the CCOptions.xaml UserControl
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Order;

namespace PointOfSale.ItemOptions.Drinks
{
    /// <summary>
    /// Interaction logic for CCOptions.xaml
    /// </summary>
    public partial class CCOptions : UserControl
    {
        FullMenu ancestor;
        /// <summary>
        /// class field to serve as a placeholder for Drink options
        /// </summary>
        CandlehearthCoffee placeholder = new CandlehearthCoffee();
        /// <summary>
        /// Initialize the CCOptions UserControl
        /// </summary>
        public CCOptions(FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = placeholder;
            this.ancestor = ancestor;
        }
        public CCOptions(CandlehearthCoffee pl, FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = pl;
            this.ancestor = ancestor;
        }
        /// <summary>
        /// Handler for ADD/Back button press.
        /// On ADD click: displays the OrderList.xaml in the correct loaction on the screen
        /// and sets Data.Context to a new item Object.
        /// On BACK click: displays the OrderList.xaml in the correct loaction on the screen
        /// but does not set Data.Context to a new item Object.
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee item = (CandlehearthCoffee)this.DataContext;
            Button button = (Button)sender;

            if (button.Name == "Add")
            {
                if (this.ancestor.openSpace.DataContext is OrderList list)
                {
                    if (list.Contains(item)) OnSwitchScreen();
                    else
                    {
                        list.Add(placeholder);
                        OnSwitchScreen();
                    }
                }
            }
            if (button.Name == "Back") OnSwitchScreen();
        }
        /// <summary>
        /// Switch the view to the order
        /// </summary>
        void OnSwitchScreen()
        {
            this.ancestor.SwitchScreen(Screen.Order);
        }
    }
}
