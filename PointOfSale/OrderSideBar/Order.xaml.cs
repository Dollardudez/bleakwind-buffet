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
        /// <summary>
        /// Initializes the OrderList component to the screen
        /// </summary>
        public Order()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Confirms or cancels the order
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "Confirm")
            {
                OrderSideBar.Order order = new OrderSideBar.Order();
                Border openSpace = (Border)this.Parent;
                openSpace.Child = order;
                openSpace.DataContext = new OrderList();

            }
            if (button.Name == "Cancel")
            {
                OrderSideBar.Order order = new OrderSideBar.Order();
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
            }
        }

        private void ItemSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Border openSpace = (Border)this.Parent;
            if (sender is ListBox listBoxOrder && listBoxOrder.SelectedIndex != -1)
            {
                IOrderItem item = (IOrderItem)((ListBox)sender).SelectedItem;
                if (item is BriarheartBurger)
                {
                    BBOptions obk = new BBOptions();
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
            
                if (item is DoubleDraugr)
                {
                    DDOptions obk = new DDOptions();
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is ThalmorTriple)
                {
                    TTOptions obk = new TTOptions();
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is GardenOrcOmelette)
                {
                    GORCOptions obk = new GORCOptions();
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is SmokehouseSkeleton)
                {
                    SSOptions obk = new SSOptions();
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is PhillyPoacher)
                {
                    PPOptions obk = new PPOptions();
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
                if (item is ThugsTBone)
                {
                    TTBOptions obk = new TTBOptions();
                    obk.DataContext = lb.SelectedItem;
                    openSpace.Child = obk;
                }
            }
            //openSpace.Child = new Order();

            //foreach(object o in e.AddedItems)
            //{
            //if(o is BriarheartBurger)
            //{
            //    BBOptions obk = new BBOptions();
            //    obk.DataContext = lb.SelectedItem;
            //    openSpace.Child = obk;
            //}
            //if (o is DoubleDraugr)
            //{
            //    DDOptions obk = new DDOptions();
            //    obk.DataContext = lb.SelectedItem;
            //    openSpace.Child = obk;
            //}
            //if (o is ThalmorTriple)
            //{
            //    TTOptions obk = new TTOptions();
            //    obk.DataContext = lb.SelectedItem;
            //    openSpace.Child = obk;
            //}
            //if (o is GardenOrcOmelette)
            //{
            //    GORCOptions obk = new GORCOptions();
            //    obk.DataContext = lb.SelectedItem;
            //    openSpace.Child = obk;
            //}
            //if (o is SmokehouseSkeleton)
            //{
            //    SSOptions obk = new SSOptions();
            //    obk.DataContext = lb.SelectedItem;
            //    openSpace.Child = obk;
            //}
            //if (o is PhillyPoacher)
            //{
            //    PPOptions obk = new PPOptions();
            //    obk.DataContext = lb.SelectedItem;
            //    openSpace.Child = obk;
            //}
            //if (o is ThugsTBone)
            //{
            //    TTBOptions obk = new TTBOptions();
            //    obk.DataContext = lb.SelectedItem;
            //    openSpace.Child = obk;
            //}

        }
    }
}
