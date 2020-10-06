/*
* Author: Robert Clancy
* Class name: VSOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the VSOptions.xaml UserControl
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale.ItemOptions.Sides
{
    /// <summary>
    /// Interaction logic for VSOptions.xaml
    /// </summary>
    public partial class VSOptions : UserControl
    {
        /// <summary>
        /// class field to serve as a placeholder for Side options
        /// </summary>
        VokunSalad placeholder = new VokunSalad();
        /// <summary>
        /// Initialize the VSOptions UserControl
        /// </summary>
        public VSOptions()
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
                this.DataContext = new VokunSalad();
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
