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
        /// <summary>
        /// dictionary holds all enums for switching screens
        /// </summary>
        Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();

        OrderList orderList = new OrderList();
        /// <summary>
        /// Initializes the FullMenu UserControl and displays the OrderList.xaml in the correct position on the creen
        /// </summary>
        public FullMenu()
        {
            InitializeComponent();
            openSpace.DataContext = orderList;
            openSpace.Child = new Order(this);

            screens.Add(Screen.Order, new Order(this));

            screens.Add(Screen.BBOptions, new BBOptions(this));
            screens.Add(Screen.DDOptions, new DDOptions(this));
            screens.Add(Screen.TTOptions, new TTOptions(this));
            screens.Add(Screen.GORCOptions, new GORCOptions(this));
            screens.Add(Screen.SSOptions, new SSOptions(this));
            screens.Add(Screen.PPOptions, new PPOptions(this));
            screens.Add(Screen.TTBOptions, new TTBOptions(this));

            screens.Add(Screen.DWFOptions, new DWFOptions(this));
            screens.Add(Screen.FMOptions, new FMOptions(this));
            screens.Add(Screen.MOGOptions, new MOGOptions(this));
            screens.Add(Screen.VSOptions, new VSOptions(this));

            screens.Add(Screen.AAJOptions, new AAJOptions(this));
            screens.Add(Screen.WWOptions, new WWOptions(this));
            screens.Add(Screen.MMOptions, new MMOptions(this));
            screens.Add(Screen.SSODAOptions, new SSODAOptions(this));
            screens.Add(Screen.CCOptions, new CCOptions(this));
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
                    BBOptions bbOptions = new BBOptions(this);
                    openSpace.Child = bbOptions;
                    break;
                case "uxDD":
                    DDOptions ddOptions = new DDOptions(this);
                    openSpace.Child = ddOptions;
                    break;
                case "uxTT":
                    TTOptions ttOptions = new TTOptions(this);
                    openSpace.Child = ttOptions;
                    break;
                case "uxTTB":
                    TTBOptions ttbOptions = new TTBOptions(this);
                    openSpace.Child = ttbOptions;
                    break;
                case "uxPP":
                    PPOptions ppOptions = new PPOptions(this);
                    openSpace.Child = ppOptions;
                    break;
                case "uxSS":
                    SSOptions ssOptions = new SSOptions(this);
                    openSpace.Child = ssOptions;
                    break;
                case "uxGORC":
                    GORCOptions gorcOptions = new GORCOptions(this);
                    openSpace.Child = gorcOptions;
                    break;

                //sides
                case "uxDWF":
                    DWFOptions dwf = new DWFOptions(this);
                    openSpace.Child = dwf;
                    break;
                case "uxFM":
                    FMOptions fm = new FMOptions(this);
                    openSpace.Child = fm;
                    break;
                case "uxMOG":
                    MOGOptions mog = new MOGOptions(this);
                    openSpace.Child = mog;
                    break;
                case "uxVS":
                    VSOptions vs = new VSOptions(this);
                    openSpace.Child = vs;
                    break;

                //drinks
                case "uxWW":
                    WWOptions wwOptions = new WWOptions(this);
                    openSpace.Child = wwOptions;
                    break;
                case "uxAAJ":
                    AAJOptions aajOptions = new AAJOptions(this);
                    openSpace.Child = aajOptions;
                    //SwitchScreen(Screen.AAJOptions)
                    break;
                case "uxCC":
                    CCOptions ccOptions = new CCOptions(this);
                    openSpace.Child = ccOptions;
                    break;
                case "uxMM":
                    MMOptions mmOptions = new MMOptions(this);
                    openSpace.Child = mmOptions;
                    break;
                case "uxSSODA":
                    SSODAOptions ssodaOptions = new SSODAOptions(this);
                    openSpace.Child = ssodaOptions;
                    break;
                default:
                    break;
            }            
        }
        /// <summary>
        /// to be used eventually
        /// </summary>
        /// <param name="screen"></param>
        public void SwitchScreen(Screen screen)
        {
            openSpace.Child = screens[screen];
        }
    }
}
