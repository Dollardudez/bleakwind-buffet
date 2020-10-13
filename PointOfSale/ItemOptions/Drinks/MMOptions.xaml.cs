/*
* Author: Robert Clancy
* Class name: MMOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the MMOptions.xaml UserControl
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
    /// Interaction logic for MMOptions.xaml
    /// </summary>
    public partial class MMOptions : UserControl
    {
        /// <summary>
        /// class field to serve as a placeholder for Drink options
        /// </summary>
        MarkarthMilk placeholder = new MarkarthMilk();
        /// <summary>
        /// Initialize the MMOOptions UserControl
        /// </summary>
        public MMOptions()
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
            MarkarthMilk item = (MarkarthMilk)this.DataContext;
            Button button = (Button)sender;

            if (button.Name == "Add")
            {
                if (openSpace.DataContext is OrderList list)
                {
                    if (list.Contains(item))
                    {
                        Border openSpace2 = (Border)Parent;
                        openSpace2.Child = new OrderSideBar.Order();
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
                Border openSpace2 = (Border)Parent;
                openSpace2.Child = new OrderSideBar.Order();
            }
        }

        //private void checkmarkSpace_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    Border border = (Border)sender;
        //    if (IsMouseDirectlyOver == true)
        //    {
        //        SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        //        border.Background = brush;
        //    }
        //    else
        //    {
        //        SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(182, 238, 245));
        //        border.Background = brush;
        //    }
        //}
    }
}
