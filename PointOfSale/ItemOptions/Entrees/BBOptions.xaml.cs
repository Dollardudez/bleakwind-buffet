/*
* Author: Robert Clancy
* Class name: BBOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the BBOptions.xaml UserControl
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Order;

namespace PointOfSale.ItemOptions.Entrees
{
    /// <summary>
    /// Interaction logic for BBOptions.xaml
    /// </summary>
    public partial class BBOptions : UserControl
    {
        /// <summary>
        /// class field to serve as a placeholder for Entree options
        /// </summary>
        public BriarheartBurger placeholder = new BriarheartBurger();
        /// <summary>
        /// Initialize the BBOptions UserControl
        /// </summary>
        public BBOptions()
        {
            InitializeComponent();
            this.DataContext = placeholder;
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
            OrderSideBar.Order order = new OrderSideBar.Order();
            Border openSpace = (Border)this.Parent;
            BriarheartBurger item = (BriarheartBurger)this.DataContext;
            Button button = (Button)sender;

            if (button.Name == "Add")
            {
                if (openSpace.DataContext is OrderList list)
                {
                    if (list.Contains(item))
                    {
                        openSpace.Child = order;
                    }
                    else
                    {
                        list.Add(placeholder);
                        openSpace.Child = new OrderSideBar.Order();
                    }
                }
            }
            if (button.Name == "Back")
            {
                openSpace.Child = new OrderSideBar.Order();
            }
        }
    }
}
