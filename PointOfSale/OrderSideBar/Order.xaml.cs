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
using BleakwindBuffet.Data.Combo;
using PointOfSale.ItemOptions.Entrees;
using PointOfSale.ItemOptions.Sides;
using PointOfSale.ItemOptions.Drinks;
using BleakwindBuffet.Data.Interface;
using PointOfSale.ItemOptions;

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
            this.ancestor = ancestor;
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
                //this.ancestor.openSpace2.Child = new OrderSideBar.Order(this.ancestor);
                // this.ancestor.openSpace.DataContext = new OrderList();
                //this.ancestor.openSpace2.DataContext = this.ancestor.openSpace.DataContext;
                OrderList currOrder = (OrderList)this.ancestor.openSpace.DataContext;
                if (currOrder.Count != 0) this.ancestor.SwitchScreen(Screen.PaymentOptions);
                else
                {
                    this.ancestor.openSpace.Child = new Empty();
                    MessageBox.Show("Must add an item to the order.");
                }
            }
            if (button.Name == "Cancel")
            {
                this.ancestor.openSpace2.Child = new OrderSideBar.Order(this.ancestor);
                this.ancestor.openSpace.DataContext = new OrderList();
                this.ancestor.openSpace2.DataContext = this.ancestor.openSpace.DataContext;
                this.ancestor.SwitchScreen(Screen.Empty);
            }
            if (button.Name == "Remove")
            {
                Button b = (Button)sender;
                IOrderItem i = (IOrderItem)b.DataContext;
                OrderList o = (OrderList)DataContext;
                o.Remove(i);
                this.ancestor.openSpace2.Child = new OrderSideBar.Order(this.ancestor);
                this.ancestor.openSpace2.DataContext = this.ancestor.openSpace.DataContext;
                this.ancestor.SwitchScreen(Screen.Empty);
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
            if (sender is ListBox listBoxOrder && listBoxOrder.SelectedIndex != -1)
            {
                IOrderItem item = (IOrderItem)((ListBox)sender).SelectedItem;
                if (item is Combo)
                {
                    this.ancestor.screens.Remove(Screen.Combo);
                    this.ancestor.screens.Add(Screen.Combo, new ComboOptions((Combo)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.Combo);
                }
                //entrees
                if (item is BriarheartBurger)
                {
                    this.ancestor.screens.Remove(Screen.BBOptions);
                    this.ancestor.screens.Add(Screen.BBOptions, new BBOptions((BriarheartBurger)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.BBOptions);
                }
            
                if (item is DoubleDraugr)
                {
                    this.ancestor.screens.Remove(Screen.DDOptions);
                    this.ancestor.screens.Add(Screen.DDOptions, new DDOptions((DoubleDraugr)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.DDOptions);
                }
                if (item is ThalmorTriple)
                {
                    this.ancestor.screens.Remove(Screen.TTOptions);
                    this.ancestor.screens.Add(Screen.TTOptions, new TTOptions((ThalmorTriple)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.TTOptions);
                }
                if (item is GardenOrcOmelette)
                {
                    this.ancestor.screens.Remove(Screen.GORCOptions);
                    this.ancestor.screens.Add(Screen.GORCOptions, new GORCOptions((GardenOrcOmelette)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.GORCOptions);
                }
                if (item is SmokehouseSkeleton)
                {
                    this.ancestor.screens.Remove(Screen.SSOptions);
                    this.ancestor.screens.Add(Screen.SSOptions, new SSOptions((SmokehouseSkeleton)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.SSOptions);
                }
                if (item is PhillyPoacher)
                {
                    this.ancestor.screens.Remove(Screen.PPOptions);
                    this.ancestor.screens.Add(Screen.PPOptions, new PPOptions((PhillyPoacher)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.PPOptions);
                }
                if (item is ThugsTBone)
                {
                    this.ancestor.screens.Remove(Screen.TTBOptions);
                    this.ancestor.screens.Add(Screen.TTBOptions, new TTBOptions((ThugsTBone)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.TTBOptions);
                }
                //drinks
                if (item is WarriorWater)
                {
                    this.ancestor.screens.Remove(Screen.WWOptions);
                    this.ancestor.screens.Add(Screen.WWOptions, new WWOptions((WarriorWater)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.WWOptions);
                }

                if (item is AretinoAppleJuice)
                {
                    this.ancestor.screens.Remove(Screen.AAJOptions);
                    this.ancestor.screens.Add(Screen.AAJOptions, new AAJOptions((AretinoAppleJuice)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.AAJOptions);
                }
                if (item is CandlehearthCoffee)
                {
                    this.ancestor.screens.Remove(Screen.CCOptions);
                    this.ancestor.screens.Add(Screen.CCOptions, new CCOptions((CandlehearthCoffee)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.CCOptions);
                }
                if (item is MarkarthMilk)
                {
                    this.ancestor.screens.Remove(Screen.MMOptions);
                    this.ancestor.screens.Add(Screen.MMOptions, new MMOptions((MarkarthMilk)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.MMOptions);
                }
                if (item is SailorSoda)
                {
                    this.ancestor.screens.Remove(Screen.SSODAOptions);
                    this.ancestor.screens.Add(Screen.SSODAOptions, new SSODAOptions((SailorSoda)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.SSODAOptions);
                }
                //sides
                if (item is DragonbornWaffleFries)
                {
                    this.ancestor.screens.Remove(Screen.DWFOptions);
                    this.ancestor.screens.Add(Screen.DWFOptions, new DWFOptions((DragonbornWaffleFries)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.DWFOptions);
                }

                if (item is FriedMiraak)
                {
                    this.ancestor.screens.Remove(Screen.FMOptions);
                    this.ancestor.screens.Add(Screen.FMOptions, new FMOptions((FriedMiraak)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.FMOptions);
                }
                if (item is MadOtarGrits)
                {
                    this.ancestor.screens.Remove(Screen.MOGOptions);
                    this.ancestor.screens.Add(Screen.MOGOptions, new MOGOptions((MadOtarGrits)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.MOGOptions);
                }
                if (item is VokunSalad)
                {
                    this.ancestor.screens.Remove(Screen.VSOptions);
                    this.ancestor.screens.Add(Screen.VSOptions, new VSOptions((VokunSalad)lb.SelectedItem, this.ancestor));
                    this.ancestor.SwitchScreen(Screen.VSOptions);
                }
            }
        }
        /// <summary>
        /// event handler to switch screen back to order
        /// </summary>
        void onSwitchScreen()
        {
            ancestor.SwitchScreen(Screen.Order);
        }
    }
}
