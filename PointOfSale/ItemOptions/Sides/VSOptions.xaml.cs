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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale.ItemOptions.Sides
{
    /// <summary>
    /// Interaction logic for VSOptions.xaml
    /// </summary>
    public partial class VSOptions : UserControl
    {
        VokunSalad placeholder = new VokunSalad();
        public VSOptions()
        {
            InitializeComponent();
            this.DataContext = placeholder;
        }

        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "Add")
            {
                OrderSideBar.Order order = new OrderSideBar.Order();
                Border openSpace = (Border)this.Parent;
                this.DataContext = new VokunSalad();
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
