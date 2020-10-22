/*
* Author: Robert Clancy
* Class name: PaymentViewModel.xaml.cs.cs
* Purpose: Class used to operate the logic for the PaymentViewModel.xaml UserControl
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
using RoundRegister;
using System.ComponentModel;

namespace PointOfSale
{
    public class PaymentViewModel: INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for the PaymentViewModel.
        /// </summary>
        /// <param name="Total"></param>
        public PaymentViewModel(double Total)
        {
            OrderTotal = Total;
        }

        /// <summary>
        /// event that is called when something cool happens
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// current change due private backing variable
        /// </summary>
        private double currentdue = 0;
        /// <summary>
        /// current amount due private backing variable
        /// </summary>
        private double amountDue = 0;
        /// <summary>
        /// change due private backing variable
        /// </summary>
        private double changeDue = 0;




        /// <summary>
        /// The number of this item in the drawer.
        /// </summary>
        public int RegisterPennies
        {
            get => CashDrawer.Pennies;
            set => CashDrawer.Pennies = value;
        }
        /// <summary>
        /// The number of this item in the drawer.
        /// </summary>
        public int RegisterNickels
        {
            get => CashDrawer.Nickels;
            set => CashDrawer.Nickels = value;
        }
        /// <summary>
        ///The number of this item in the drawer.
        /// </summary>
        public int RegisterDimes
        {
            get => CashDrawer.Dimes;
            set => CashDrawer.Dimes = value;
        }
        /// <summary>
        /// The number of this item in the drawer
        /// </summary>
        public int RegisterQuarters
        {
            get => CashDrawer.Quarters;
            set => CashDrawer.Quarters = value;
        }
        /// <summary>
        ///The number of this item in the drawer
        /// </summary>
        public int RegisterOnes
        {
            get => CashDrawer.Ones;
            set => CashDrawer.Ones = value;
        }
        /// <summary>
        /// The number of this item in the drawer.
        /// </summary>
        public int RegisterFives
        {
            get => CashDrawer.Fives;
            set => CashDrawer.Fives = value;
        }
        /// <summary>
        /// The number of this item in the drawer.
        /// </summary>
        public int RegisterTens
        {
            get => CashDrawer.Tens;
            set => CashDrawer.Tens = value;
        }
        /// <summary>
        /// The number of this item in the drawer
        /// </summary>
        public int RegisterTwenties
        {
            get => CashDrawer.Twenties;
            set => CashDrawer.Twenties = value;
        }
        /// <summary>
        /// The number of this item in the drawer
        /// </summary>
        public int RegisterFifties
        {
            get => CashDrawer.Fifties;
            set => CashDrawer.Fifties = value;
        }
        /// <summary>
        ///The number of this item in the drawer.
        /// </summary>
        public int RegisterHundreds
        {
            get => CashDrawer.Hundreds;
            set => CashDrawer.Hundreds = value;
        }




        /// <summary>
        /// private backing variable for Paid Pennies
        /// </summary>
        private int p1c = 0;
        /// <summary>
        /// number of this item paid by the customer.
        /// </summary>
        public int Paid1C
        {
            get => p1c;
            set
            {
                p1c = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid1C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for Paid Nickels
        /// </summary>
        private int p5c = 0;
        /// <summary>
        /// number of this item paid by the customer.
        /// </summary>
        public int Paid5C
        {
            get => p5c;
            set
            {
                p5c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid5C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for Paid RegisterDimes
        /// </summary>
        private int p10c = 0;
        /// <summary>
        ///  number of this item paid by the customer.
        /// </summary>
        public int Paid10C
        {
            get => p10c;
            set
            {
                p10c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid10C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for Paid RegisterQuarters
        /// </summary>
        private int p25c = 0;
        /// <summary>
        ///  number of this item paid by the customer.
        /// </summary>
        public int Paid25C
        {
            get => p25c;
            set
            {
                p25c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid25C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for Paid 1 dollars.
        /// </summary>
        private int p1d = 0;
        /// <summary>
        /// number of this item paid by the customer.
        /// </summary>
        public int PaidOnes
        {
            get => p1d;
            set
            {
                p1d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for payed fives
        /// </summary>
        private int p5d = 0;
        /// <summary>
        ///  number of this item paid by the customer.
        /// </summary>
        public int PaidFives
        {
            get => p5d;
            set
            {
                p5d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for payed tens
        /// </summary>
        private int p10d = 0;
        /// <summary>
        ///  number of this item paid by the customer.
        /// </summary>
        public int PaidTens
        {
            get => p10d;
            set
            {
                p10d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for payed twenties
        /// </summary>
        private int p20d = 0;
        /// <summary>
        /// number of this item paid by the customer.
        /// </summary>
        public int PaidTwenties
        {
            get => p20d;
            set
            {
                p20d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for payed fifties
        /// </summary>
        private int p50d = 0;
        /// <summary>
        ///  number of this item paid by the customer.
        /// </summary>
        public int PaidFifties
        {
            get => p50d;
            set
            {
                p50d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }
        /// <summary>
        /// private backing variable for payed hundreds
        /// </summary>
        private int p100d = 0;
        /// <summary>
        ///  number of this item paid by the customer.
        /// </summary>
        public int PaidHundreds
        {
            get => p100d;
            set
            {
                p100d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment")); 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPaidEnough"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                ChangeNeeded();
            }
        }



        /// <summary>
        /// private backing variable for change pennies
        /// </summary>
        private int c1c = 0;
        /// <summary>
        /// the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangePennies
        {
            get => c1c;
            set
            {
                c1c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change nickels
        /// </summary>
        private int c5c = 0;
        /// <summary>
        ///  the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeNickels
        {
            get => c5c;
            set
            {
                c5c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change dimes
        /// </summary>
        private int c10c = 0;
        /// <summary>
        ///  the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeDimes
        {
            get => c10c;
            set
            {
                c10c = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change quarters
        /// </summary>
        private int c25c = 0;
        /// <summary>
        ///  the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeQuarters
        {
            get => c25c;
            set
            {
                c25c = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change dollars
        /// </summary>
        private int c1d = 0;
        /// <summary>
        ///  the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeOnes
        {
            get => c1d;
            set
            {
                c1d = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change fives
        /// </summary>
        private int c5d = 0;
        /// <summary>
        /// the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeFives
        {
            get => c5d;
            set
            {
                c5d = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change tens
        /// </summary>
        private int c10d = 0;
        /// <summary>
        ///  the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeTens
        {
            get => c10d;
            set
            {
                c10d = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change twenties
        /// </summary>
        private int c20d = 0;
        /// <summary>
        ///  the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeTwenties
        {
            get => c20d;
            set
            {
                c20d = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for fifties pennies
        /// </summary>
        private int c50d = 0;
        /// <summary>
        /// the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeFifties
        {
            get => c50d;
            set
            {
                c50d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// private backing variable for change hundreds
        /// </summary>
        private int c100d = 0;
        /// <summary>
        ///  the amount of this item the customer needs back as change.
        /// </summary>
        public int ChangeHundreds
        {
            get => c100d;
            set
            {
                c100d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        /// Total cost of the order
        /// </summary>
        public double OrderTotal { get; private set; }
        /// <summary>
        /// The total amount of money in the drawer
        /// </summary>
        public double CashDrawerTotal => CashDrawer.Total;
        /// <summary>
        /// open the cash register
        /// </summary>
        public void OpenCashRegister()
        {
            CashDrawer.OpenDrawer();
        }
        /// <summary>
        /// Resets the amount of money in the cash register.
        /// </summary>
        public void ResetCashRegister()
        {
            CashDrawer.ResetDrawer();
        }
        /// <summary>
        /// Calculates the number of cash in the register after a transaction has concluded.
        /// </summary>
        public void FinishSale()
        {
            RegisterPennies = RegisterPennies - ChangePennies + Paid1C;
            RegisterNickels = RegisterNickels - ChangeNickels + Paid5C;
            RegisterDimes = RegisterDimes - ChangeDimes + Paid10C;
            RegisterQuarters = RegisterQuarters - ChangeQuarters + Paid25C;
            RegisterOnes = RegisterOnes - ChangeOnes + PaidOnes;
            RegisterFives = RegisterFives - ChangeFives + PaidFives;
            RegisterTens = RegisterTens - ChangeTens + PaidTens;
            RegisterTwenties = RegisterTwenties - ChangeTwenties + PaidTwenties;
            RegisterFifties = RegisterFifties - ChangeFifties + PaidFifties;
            RegisterHundreds = RegisterHundreds - ChangeHundreds + PaidHundreds;
        }
        /// <summary>
        /// private backing variable, has the customer paid enough?
        /// </summary>
        private bool paidenough = false;
        /// <summary>
        /// Has the customer paid enough for the meal.
        /// </summary>
        public bool IsPaidEnough
        {
            get
            {
                if (CurrentlyPayedAmount >= OrderTotal) paidenough = true;
                else paidenough = false;
                return paidenough;
            }
        }
        /// <summary>
        /// Helper for CurrentChangeDue that gets the current change due amount.
        /// </summary>
        public double CurrentDue
        {
            get
            {
                currentdue = ((ChangePennies*.01) + (ChangeNickels*.05) + (ChangeDimes*.10) + (ChangeQuarters*.25) + (ChangeOnes*1) + (ChangeFives*5) + (ChangeTens*10) + (ChangeTwenties*20) + (ChangeFifties*50) + (ChangeHundreds*100));
                return currentdue;
            }
        }
        /// <summary>
        /// The current change due back to the customer.
        /// </summary>
        public double CurrentChangeDue
        {
            get
            {
                if (CurrentDue <= 0)
                {
                    return 0;
                }
                else
                {
                    return  Math.Round(CurrentDue, 2);
                }
            }
        }
        /// <summary>
        /// The current payment amount 
        /// </summary>
        public double CurrentlyPayedAmount
        {
            get
            {
                currentdue = ( (p1c*.01) + (p5c*.05) + (p10c*.10) + (p25c*.25) + (PaidOnes*1) + (PaidFives*5) + (PaidTens*10) + (PaidTwenties*20) + (PaidFifties*50) + (PaidHundreds*100) );
                return currentdue;
            }
        }
        /// <summary>
        /// Amount the customer needs to pay
        /// </summary>
        public double AmountDue
        {
            get
            {
                if (CurrentlyPayedAmount <= 0)
                {
                    amountDue = OrderTotal;
                }
                else
                {
                    amountDue = OrderTotal - CurrentlyPayedAmount;
                    amountDue = Math.Round(amountDue, 2);
                }
                return amountDue;
            }
        }
        /// <summary>
        /// Change needed to be payed back to the customer
        /// </summary>
        public void ChangeNeeded()
        {
            if (IsPaidEnough && CurrentlyPayedAmount > OrderTotal)
            {
                changeDue = Math.Round(CurrentlyPayedAmount - OrderTotal, 2);

                int BillsNeeded = (int)changeDue;
                double ChangeNeeded = Math.Round(changeDue - BillsNeeded, 2);

                ChangeHundreds = BillsNeeded / 100;
                BillsNeeded %= 100;

                ChangeFifties = BillsNeeded / 50;
                BillsNeeded %= 50;
                ChangeTwenties = BillsNeeded / 20;
                BillsNeeded %= 20;
                ChangeTens = BillsNeeded / 10;
                BillsNeeded %= 10;
                ChangeFives = BillsNeeded / 5;
                BillsNeeded %= 5;
                ChangeOnes = BillsNeeded;
                ChangeQuarters = (int)(ChangeNeeded / 0.25);
                ChangeNeeded %= 0.25;
                ChangeNeeded = Math.Round(ChangeNeeded, 2);

                ChangeDimes = (int)(ChangeNeeded / 0.10);
                ChangeNeeded %= 0.10;
                ChangeNeeded = Math.Round(ChangeNeeded, 2);
                ChangeNickels = (int)(ChangeNeeded / 0.05);
                ChangeNeeded %= 0.05;
                ChangeNeeded = Math.Round(ChangeNeeded, 2);
                ChangePennies = (int)(ChangeNeeded / 0.01);
                ChangeNeeded = Math.Round(ChangeNeeded, 2);
            }
        }
    }
}
