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


namespace PointOfSale.ItemOptions.Drinks
{
    /// <summary>
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SSODAOptions : UserControl
    {
        /// <summary>
        /// class field to serve as a placeholder for Drink options
        /// </summary>
        SailorSoda placeholder = new SailorSoda();
        public SSODAOptions()
        {
            InitializeComponent();
            this.DataContext = placeholder;
        }
        /// <summary>
        /// Handler for ADD/Back button press
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "Add")
            {
                OrderSideBar.Order order = new OrderSideBar.Order();
                Border openSpace = (Border)this.Parent;
                this.DataContext = new SailorSoda();
                openSpace.Child = order;

            }
            if (button.Name == "Back")
            {
                OrderSideBar.Order order = new OrderSideBar.Order();
                Border openSpace = (Border)this.Parent;
                openSpace.Child = order;
            }
        }
    }
}
