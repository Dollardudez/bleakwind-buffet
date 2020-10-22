/*
* Author: Robert Clancy
* Class name: PPOptions.xaml.cs.cs
* Purpose: Class used to operate the logic for the PPOptions.xaml UserControl
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
using PointOfSale.OrderSideBar;


namespace PointOfSale.ItemOptions.Entrees
{
    /// <summary>
    /// Interaction logic for PPOptions
    /// .xaml
    /// </summary>
    public partial class PPOptions : UserControl
    {
        /// <summary>
        /// a combobox property
        /// </summary>
        ComboBox comboOps;
        /// <summary>
        /// whether the item is a part of a combo or not
        /// </summary>
        bool isCombo;
        FullMenu ancestor;
        /// <summary>
        /// class field to serve as a placeholder for Entree options
        /// </summary>
        public PhillyPoacher placeholder = new PhillyPoacher();
        /// <summary>
        /// Initialize the DDOptions UserControl
        /// </summary>
        public PPOptions(FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = placeholder;
            this.ancestor = ancestor;
        }
        /// <summary>
        /// override
        /// </summary>
        /// <param name="ancestor"></param>
        public PPOptions(PhillyPoacher pl, FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = pl;
            this.ancestor = ancestor;
            this.Back.Height = 0;
            this.Add.Height = 0;
            Add.Content = "Done";
        }
        /// <summary>
        /// override
        /// </summary>
        /// <param name="ancestor"></param>
        public PPOptions(PhillyPoacher pl, FullMenu ancestor, bool isCombo, ComboBox comboOps)
        {
            InitializeComponent();
            this.DataContext = pl;
            this.ancestor = ancestor;
            Add.Content = "Done";
            this.isCombo = isCombo;
            this.comboOps = comboOps;
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
            PhillyPoacher item = (PhillyPoacher)this.DataContext;
            Button button = (Button)sender;

            if (button.Name == "Add")
            {
                if (this.ancestor.openSpace.DataContext is OrderList list)
                {
                    if (list.Contains(item))
                    {
                        Add.Content = "Done";
                        if (isCombo)
                        {
                            this.ancestor.SwitchScreen(Screen.Combo);
                            this.ancestor.openSpace2.Child = new Order(this.ancestor);
                        }
                        else
                        {
                            this.ancestor.SwitchScreen(Screen.Empty);
                            this.ancestor.openSpace2.Child = new Order(this.ancestor);
                        }

                    }
                    else if (!isCombo)
                    {
                        list.Add(placeholder);
                        this.ancestor.SwitchScreen(Screen.Empty);
                        this.ancestor.openSpace2.Child = new Order(this.ancestor);
                    }
                    else if (isCombo)
                    {
                        this.ancestor.SwitchScreen(Screen.Combo);
                        this.comboOps.SelectedItem = item;
                        this.ancestor.openSpace2.Child = new Order(this.ancestor);
                    }
                }
            }
            else if (button.Name == "Back" && !isCombo)
            {
                this.ancestor.SwitchScreen(Screen.Empty);
                this.ancestor.openSpace2.Child = new Order(this.ancestor);
            }
            else if (button.Name == "Back" && isCombo)
            {
                this.ancestor.SwitchScreen(Screen.Combo);
                this.ancestor.openSpace2.Child = new Order(this.ancestor);
            }
        }
    }
}
