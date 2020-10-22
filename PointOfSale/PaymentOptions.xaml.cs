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
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        FullMenu ancestor;

        public PaymentOptions(FullMenu ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "Cash")
            {
                this.ancestor.openSpace2.Child = new OrderSideBar.Order(this.ancestor);
                this.ancestor.screens.Remove(Screen.CashPayment);
                this.ancestor.screens.Add(Screen.CashPayment, new CashPayment(this.ancestor));
                this.ancestor.SwitchScreen(Screen.CashPayment);
            }
            if (button.Name == "CreditDebit")
            {
                OrderList o = (OrderList)this.ancestor.openSpace.DataContext;
                CardTransactionResult result = CardReader.RunCard(o.Total);
                MessageBox.Show(result.ToString());
                if(result == CardTransactionResult.Approved)
                {
                    MessageBox.Show("Receipt Printed");
                    PrintReceipt pn = new PrintReceipt(o);
                    pn.PrintReceiptCard();


                    this.ancestor.openSpace2.Child = new OrderSideBar.Order(this.ancestor);
                    this.ancestor.openSpace.DataContext = new OrderList();
                    this.ancestor.openSpace2.DataContext = this.ancestor.openSpace.DataContext;
                    this.ancestor.SwitchScreen(Screen.Empty);
                }
            }
        }
    }
}
