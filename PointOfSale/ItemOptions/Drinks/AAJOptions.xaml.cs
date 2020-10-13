/*
* Author: Robert Clancy
* Class name: AAJOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the AAJOptions.xaml UserControl
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
using PointOfSale.OrderSideBar;


namespace PointOfSale.ItemOptions.Drinks
{
    /// <summary>
    /// Interaction logic for AAJOptions.xaml
    /// </summary>
    public partial class AAJOptions : UserControl
    {
        FullMenu ancestor;
        //Border openSpace2 = (Border)this.Parent;
        /// <summary>
        /// class field to serve as a placeholder for Drink options
        /// </summary>
        AretinoAppleJuice pl = new AretinoAppleJuice();
        /// <summary>
        /// Initialize the AAJOptions UserControl
        /// </summary>
        public AAJOptions(AretinoAppleJuice placeholder, FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = placeholder;
            this.ancestor = ancestor;
        }
        public AAJOptions(FullMenu ancestor)
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
            AretinoAppleJuice item = (AretinoAppleJuice)this.DataContext;
            Button button = (Button)sender;
            if (button.Name == "Add")
            {
                if (this.ancestor.openSpace.DataContext is OrderList list)
                {
                    if (list.Contains(item))  this.ancestor.openSpace.Child = new Order(this.ancestor);
                    else
                    {
                        list.Add(item);
                        this.ancestor.openSpace.Child = new Order(this.ancestor);
                        System.Diagnostics.Debug.WriteLine(this.ancestor.openSpace.ToString());
                    }
                }
            }
            if (button.Name == "Back") this.ancestor.openSpace.Child = new Order(this.ancestor);
        }

        void OnSwitchScreen()
        {
            this.ancestor.SwitchScreen(Screen.Order);
        }

    }
}
