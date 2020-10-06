/*
* Author: Robert Clancy
* Class name: WWOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the WWOptions.xaml UserControl
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


namespace PointOfSale.ItemOptions.Drinks
{
    /// <summary>
    /// Interaction logic for WWOptions.xaml
    /// </summary>
    public partial class WWOptions : UserControl
    {
        /// <summary>
        /// class field to serve as a placeholder for Drink options
        /// </summary>
        WarriorWater placeholder = new WarriorWater();
        /// <summary>
        /// Initialize the WWOptions UserControl
        /// </summary>
        public WWOptions()
        {
            InitializeComponent();
            this.DataContext = placeholder;
        }
        /// <summary>
        /// Handler for ADD/Back button press.
        /// On ADD click: displays the Order.xaml in the correct loaction on the screen
        /// and sets Data.Context to a new item Object.
        /// On BACK click: displays the Order.xaml in the correct loaction on the screen
        /// but does not set Data.Context to a new item Object.
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "Add")
            {
                OrderSideBar.Order order = new OrderSideBar.Order();
                Border openSpace = (Border)this.Parent;
                this.DataContext = new WarriorWater();
                openSpace.Child = order;

            }
            if (button.Name == "Back")
            {
                OrderSideBar.Order order = new OrderSideBar.Order();
                Border openSpace = (Border)this.Parent;
                openSpace.Child = order;
            }
        }
    }
}
