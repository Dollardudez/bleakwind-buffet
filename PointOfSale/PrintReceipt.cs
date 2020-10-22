/*Author: Robert Clancy
* Class name: PrintReceipt.xaml.cs.cs
* Purpose: Class used to operate the logic for the PrintReceipt.Xaml UserControl
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
using BleakwindBuffet.Data.Combo;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Combo;
using PointOfSale.ItemOptions.Entrees;
using PointOfSale.ItemOptions.Sides;
using PointOfSale.ItemOptions.Drinks;
using BleakwindBuffet.Data.Interface;
using PointOfSale.ItemOptions;
using RoundRegister;
using System.IO;

namespace PointOfSale
{
    public class PrintReceipt
    {
        OrderList order;
        public PrintReceipt(OrderList order)
        {
            this.order = order;
        }
        public void PrintReceiptCash(double ChangeDue)
        {
            //this.order = order;
            //StreamWriter file = new StreamWriter("../../../debug/receipts2.txt");
            RecieptPrinter.PrintLine("Order:  " + order.Number.ToString());
            DateTime localDate = DateTime.Now;
            RecieptPrinter.PrintLine(localDate.ToString());
            int ComboCount = 0;
            RecieptPrinter.PrintLine("");
            foreach (IOrderItem item in order)
            {
                if (item is Combo)
                {
                    RecieptPrinter.PrintLine("Combo Meal");
                    RecieptPrinter.PrintLine("_______________________________");
                    ComboCount = 1;
                }
                else RecieptPrinter.PrintLine(item.ToString());
                foreach (String instruction in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine("  - " + instruction);
                }
                if (ComboCount == 1)
                {
                    ComboCount = 0;
                    RecieptPrinter.PrintLine("_______________________________");

                }
            }
            RecieptPrinter.PrintLine("");
            RecieptPrinter.PrintLine("Subtotal:  " + order.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax:  " + order.Tax.ToString());
            RecieptPrinter.PrintLine("Total:  " + order.Total.ToString());
            RecieptPrinter.PrintLine("Payment Method:  Cash");
            RecieptPrinter.PrintLine("Change Due:  " + ChangeDue.ToString());
            RecieptPrinter.CutTape();
        }

        public void PrintReceiptCard()
        {
            RecieptPrinter.PrintLine("Order:" + order.Number.ToString());
            DateTime localDate = DateTime.Now;
            RecieptPrinter.PrintLine(localDate.ToString());
            RecieptPrinter.PrintLine("");
            int ComboCount = 0;
            foreach (IOrderItem item in order)
            {
                if (item is Combo)
                {
                    RecieptPrinter.PrintLine("Combo Meal");
                    RecieptPrinter.PrintLine("_______________________________");
                    ComboCount = 1;
                }
                else RecieptPrinter.PrintLine(item.ToString());
                foreach (String instruction in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine("  - " + instruction);
                }
                if(ComboCount == 1)
                {
                    ComboCount = 0;
                    RecieptPrinter.PrintLine("_______________________________");

                }
            }
            RecieptPrinter.PrintLine("");
            RecieptPrinter.PrintLine("Subtotal:  " + order.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax:  " + order.Tax.ToString());
            RecieptPrinter.PrintLine("Total:  " + order.Total.ToString());
            RecieptPrinter.PrintLine("Payment Method:  Cash");
            RecieptPrinter.PrintLine("Change Due:  0");
            RecieptPrinter.CutTape();
        }
    }
}
