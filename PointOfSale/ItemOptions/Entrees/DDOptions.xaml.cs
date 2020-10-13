/*
* Author: Robert Clancy
* Class name: DDOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the DDOptions.xaml UserControl
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
    /// Interaction logic for DDOptions.xaml
    /// </summary>
    public partial class DDOptions : UserControl
    {
        FullMenu ancestor;
        /// <summary>
        /// class field to serve as a placeholder for Entree options
        /// </summary>
        public DoubleDraugr placeholder = new DoubleDraugr();
        /// <summary>
        /// Initialize the DDOptions UserControl
        /// </summary>
        public DDOptions(FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = placeholder;
            this.ancestor = ancestor;
        }
        /// <summary>
        /// override
        /// </summary>
        /// <param name="ancestor"></param>
        public DDOptions(DoubleDraugr pl, FullMenu ancestor)
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
            DoubleDraugr item = (DoubleDraugr)this.DataContext;
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
