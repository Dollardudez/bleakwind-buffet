/*
* Author: Robert Clancy
* Class name: OrderList.xaml.cs.cs
* Purpose: Class used to operate the logic for the OrderList.Xaml UserControl
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
using BleakwindBuffet.Data.Order;
using Order = BleakwindBuffet.Data.Order;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ItemOptions.Entrees;
using PointOfSale.ItemOptions.Sides;
using PointOfSale.ItemOptions.Drinks;
using BleakwindBuffet.Data.Interface;


namespace PointOfSale.OrderSideBar
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        FullMenu ancestor;
        /// <summary>
        /// Initializes the OrderList component to the screen
        /// </summary>
        public Order(FullMenu ancestor)
        {
            InitializeComponent();
        }
        /// <summary>
        /// Confirms or cancels the order, OR removes an item from the order
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "Confirm")
            {
                OrderSideBar.Order order = new OrderSideBar.Order(this.ancestor);
                Border openSpace = (Border)this.Parent;
                openSpace.Child = order;
                openSpace.DataContext = new OrderList();

            }
            if (button.Name == "Cancel")
            {
                OrderSideBar.Order order = new OrderSideBar.Order(this.ancestor);
                Border openSpace = (Border)this.Parent;
                openSpace.Child = order;
                openSpace.DataContext = new OrderList();
            }
            if (button.Name == "Remove")
            {
                Button b = (Button)sender;
                IOrderItem i = (IOrderItem)b.DataContext;
                OrderList o = (OrderList)DataContext;
                o.Remove(i);
                Border openSpace = (Border)this.Parent;
                OrderSideBar.Order order = new OrderSideBar.Order(this.ancestor);
                openSpace.Child = order;
            }
        }
        /// <summary>
        /// Item selection handler
        /// </summary>
        /// <param name="sender">listbox</param>
        /// <param name="e">event</param>
        private void ItemSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Border openSpace = (Border)this.Parent;
            //NavigationLogic nl = new NavigationLogic((Border)Parent);

            if (sender is ListBox listBoxOrder && listBoxOrder.SelectedIndex != -1)
            {
                IOrderItem item = (IOrderItem)((ListBox)sender).SelectedItem;
                //entrees
                if (item is BriarheartBurger)
                {
                    BBOptions obk = new BBOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
            
                if (item is DoubleDraugr)
                {
                    DDOptions obk = new DDOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is ThalmorTriple)
                {
                    TTOptions obk = new TTOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is GardenOrcOmelette)
                {
                    GORCOptions obk = new GORCOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is SmokehouseSkeleton)
                {
                    SSOptions obk = new SSOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is PhillyPoacher)
                {
                    PPOptions obk = new PPOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is ThugsTBone)
                {
                    TTBOptions obk = new TTBOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                //drinks
                if (item is WarriorWater)
                {
                    openSpace.Child = new WWOptions((WarriorWater)lb.SelectedItem, this.ancestor);
                }

                if (item is AretinoAppleJuice)
                {
                    var ancestor = (FullMenu)((Grid)((Border)this.Parent).Parent).Parent;
                    openSpace.Child = new AAJOptions((AretinoAppleJuice)lb.SelectedItem, this.ancestor);
                }
                if (item is CandlehearthCoffee)
                {
                    openSpace.Child = new CCOptions((CandlehearthCoffee)lb.SelectedItem, this.ancestor);
                }
                if (item is MarkarthMilk)
                {
                    openSpace.Child = new MMOptions((MarkarthMilk)lb.SelectedItem, this.ancestor);
                }
                if (item is SailorSoda)
                {
                    openSpace.Child = new SSODAOptions((SailorSoda)lb.SelectedItem, this.ancestor);
                }
                //sides
                if (item is DragonbornWaffleFries)
                {
                    DWFOptions obk = new DWFOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }

                if (item is FriedMiraak)
                {
                    FMOptions obk = new FMOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is MadOtarGrits)
                {
                    MOGOptions obk = new MOGOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is VokunSalad)
                {
                    VSOptions obk = new VSOptions(this.ancestor);
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
            }
        }
        void onSwitchScreen()
        {
            ancestor.SwitchScreen(Screen.Order);
        }
    }
}
