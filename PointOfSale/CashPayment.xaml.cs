/*
* Author: Robert Clancy
* Class name: CashPayment.xaml.cs.cs
* Purpose: Class used to operate the logic for the CashPayment.xaml UserControl
*/

using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Order;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl
    {
        /// <summary>
        /// The ancestor user control
        /// </summary>
        FullMenu ancestor;
        /// <summary>
        /// constructor that initializes the cash payment screen.
        /// </summary>
        /// <param name="ancestor"></param>
        public CashPayment(FullMenu ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            OrderList o = (OrderList)this.ancestor.openSpace.DataContext;
            DataContext = new PaymentViewModel(o.Total);
        }
        /// <summary>
        /// Confirms or cancels the order, OR removes an item from the order
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "Finalize")
            {
                MessageBox.Show("Receipt Printed");
                PaymentViewModel pvm = (PaymentViewModel)this.DataContext;
                OrderList currOrder = (OrderList)this.ancestor.openSpace.DataContext;
                PrintReceipt pn = new PrintReceipt(currOrder);
                pn.PrintReceiptCash(pvm.CurrentChangeDue);
                pvm.FinishSale();
                this.ancestor.openSpace2.Child = new OrderSideBar.Order(this.ancestor);
                this.ancestor.openSpace.DataContext = new OrderList();
                this.ancestor.openSpace2.DataContext = this.ancestor.openSpace.DataContext;
                this.ancestor.SwitchScreen(Screen.Empty);
            }
            if (button.Name == "Cancel")
            {
                this.ancestor.openSpace2.Child = new OrderSideBar.Order(this.ancestor);
                this.ancestor.openSpace.DataContext = new OrderList();
                this.ancestor.openSpace2.DataContext = this.ancestor.openSpace.DataContext;
                this.ancestor.SwitchScreen(Screen.Empty);
            }
        }
        /// <summary>
        /// handles click events for the +/- buttons
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">mouse</param>
        private void uxMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            PaymentViewModel pvm = (PaymentViewModel)b.DataContext;
            switch (b.Name)
            {
                case "BillPlus_100":
                    pvm.PaidHundreds++;
                    break;
                case "BillPlus_50":
                    pvm.PaidFifties++;
                    break;
                case "BillPlus_20":
                    pvm.PaidTwenties++;
                    break;
                case "BillPlus_10":
                    pvm.PaidTens++;
                    break;
                case "BillPlus_5":
                    pvm.PaidFives++;
                    break;
                case "BillPlus_1":
                    pvm.PaidOnes++;
                    break;
                case "CoinPlus_25":
                    pvm.Paid25C++;
                    break;
                case "CoinPlus_10":
                    pvm.Paid10C++;
                    break;
                case "CoinPlus_5":
                    pvm.Paid5C++;
                    break;
                case "CoinPlus_1":
                    pvm.Paid1C++;
                    break;




                case "BillMinus_100":
                    pvm.PaidHundreds--;
                    break;
                case "BillMinus_50":
                    pvm.PaidFifties--;
                    break;
                case "BillMinus_20":
                    pvm.PaidTwenties--;
                    break;
                case "BillMinus_10":
                    pvm.PaidTens--;
                    break;
                case "BillMinus_5":
                    pvm.PaidFives--;
                    break;
                case "BillMinus_1":
                    pvm.PaidOnes--;
                    break;
                case "CoinMinus_25":
                    pvm.Paid25C--;
                    break;
                case "CoinMinus_10":
                    pvm.Paid10C--;
                    break;
                case "CoinMinus_5":
                    pvm.Paid5C--;
                    break;
                case "CoinMinus_1":
                    pvm.Paid1C--;
                    break;
            }
        }
    }
}
