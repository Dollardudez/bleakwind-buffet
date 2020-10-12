﻿/*
* Author: Robert Clancy
* Class name: OrderList.xaml.cs.cs
* Purpose: Class used to operate the logic for the FullMenu.xaml UserControl
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
using PointOfSale.ItemOptions.Entrees;
using PointOfSale.ItemOptions.Sides;
using PointOfSale.ItemOptions.Drinks;
using PointOfSale.OrderSideBar;
using BleakwindBuffet.Data.Order;



namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FullMenu.xaml
    /// </summary>
    public partial class FullMenu : UserControl
    {
        OrderList orderList = new OrderList();
        Order order = new Order();
        /// <summary>
        /// Initializes the FullMenu UserControl and displays the OrderList.xaml in the correct position on the creen
        /// </summary>
        public FullMenu()
        {
            InitializeComponent();
            if(openSpace.Child != order)
            {
                openSpace.Child = order;
            }
            openSpace.DataContext = orderList;
            openSpace.Child = order;
        }

        /// <summary>
        /// A single handler to operate the logic for when any Menu Item Button is clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">mouse event</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string name = button.Name;
            switch (name) 
            {
                //entrees
                case "uxBB":
                    BBOptions bbOptions = new BBOptions();
                    openSpace.Child = bbOptions;
                    break;
                case "uxDD":
                    DDOptions ddOptions = new DDOptions();
                    openSpace.Child = ddOptions;
                    break;
                case "uxTT":
                    TTOptions ttOptions = new TTOptions();
                    openSpace.Child = ttOptions;
                    break;
                case "uxTTB":
                    TTBOptions ttbOptions = new TTBOptions();
                    openSpace.Child = ttbOptions;
                    break;
                case "uxPP":
                    PPOptions ppOptions = new PPOptions();
                    openSpace.Child = ppOptions;
                    break;
                case "uxSS":
                    SSOptions ssOptions = new SSOptions();
                    openSpace.Child = ssOptions;
                    break;
                case "uxGORC":
                    GORCOptions gorcOptions = new GORCOptions();
                    openSpace.Child = gorcOptions;
                    break;

                //sides
                case "uxDWF":
                    DWFOptions dwf = new DWFOptions();
                    openSpace.Child = dwf;
                    break;
                case "uxFM":
                    FMOptions fm = new FMOptions();
                    openSpace.Child = fm;
                    break;
                case "uxMOG":
                    MOGOptions mog = new MOGOptions();
                    openSpace.Child = mog;
                    break;
                case "uxVS":
                    VSOptions vs = new VSOptions();
                    openSpace.Child = vs;
                    break;

                //drinks
                case "uxWW":
                    WWOptions wwOptions = new WWOptions();
                    openSpace.Child = wwOptions;
                    break;
                case "uxAAJ":
                    AAJOptions aajOptions = new AAJOptions();
                    openSpace.Child = aajOptions;
                    break;
                case "uxCC":
                    CCOptions ccOptions = new CCOptions();
                    openSpace.Child = ccOptions;
                    break;
                case "uxMM":
                    MMOptions mmOptions = new MMOptions();
                    openSpace.Child = mmOptions;
                    break;
                case "uxSSODA":
                    SSODAOptions ssodaOptions = new SSODAOptions();
                    openSpace.Child = ssodaOptions;
                    break;


                default:
                    break;

            }
        }
    }
}
