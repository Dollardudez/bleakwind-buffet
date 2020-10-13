﻿/*
* Author: Robert Clancy
* Class name: GORCOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the GORCOptions.xaml UserControl
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
    /// Interaction logic for GORCOptions.xaml
    /// </summary>
    public partial class GORCOptions : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        FullMenu ancestor;
        /// <summary>
        /// class field to serve as a placeholder for Entree options
        /// </summary>
        public GardenOrcOmelette placeholder = new GardenOrcOmelette();
        /// <summary>
        /// Initialize the GORCOptions UserControl
        /// </summary>
        public GORCOptions(FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = placeholder;
            this.ancestor = ancestor;
        }
        /// <summary>
        /// Handle
        /// /// <summary>
        /// override
        /// </summary>
        /// <param name="ancestor"></param>
        public GORCOptions(GardenOrcOmelette pl, FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = pl;
            this.ancestor = ancestor;
        }
        /// for ADD/Back button press.
        /// On ADD click: displays the OrderList.xaml in the correct loaction on the screen
        /// and sets Data.Context to a new item Object.
        /// On BACK click: displays the OrderList.xaml in the correct loaction on the screen
        /// but does not set Data.Context to a new item Object.
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette item = (GardenOrcOmelette)this.DataContext;
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
