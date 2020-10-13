/*
* Author: Robert Clancy
* Class name: OrderList.cs
* Purpose: Class used to represent an order
*/


using BleakwindBuffet.Data.Interface;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Order
{
    /// <summary>
    /// class that represents an order
    /// </summary>
    public class OrderList : ObservableCollection<IOrderItem>, INotifyCollectionChanged
    {
        /// <summary>
        /// private order number backing variable
        /// </summary>
        private static int nextOrderNumber = 0;
        /// <summary>
        /// Property to represent an order number.
        /// </summary>
        public int Number
        {
            get => nextOrderNumber;
        }
        /// <summary>
        /// private sales tax rate backing variable
        /// </summary>
        private double salestaxrate = 0.12;
        /// <summary>
        /// Property to represent a Sales Tax Rate
        /// </summary>
        public double SalesTaxRate
        {
            get => salestaxrate;
            set => salestaxrate = value;
        }
        /// <summary>
        /// Property to represent a Order Subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                double sum = 0;
                foreach (IOrderItem item in this)
                {
                    sum += item.Price;
                    sum = (Math.Round(sum, 2));
                }
                return sum;
            }
        }
        /// <summary>
        /// private backing Tax variable
        /// </summary>
        private double tax;
        /// <summary>
        /// Property to represent the amount taxed on an order
        /// </summary>
        public double Tax
        {
            get
            {
                double product;
                product = Subtotal * SalesTaxRate;
                product = (Math.Round(product, 2));
                return product;
            }
            private set => tax = value;
        }
        /// <summary>
        /// private backing total cost variable
        /// </summary>
        private double total;
        /// <summary>
        /// Property to Represent the total cost of an order
        /// </summary>
        public double Total
        {
            get
            {
                double sum;
                sum = Subtotal + Tax;
                sum = (Math.Round(sum, 2));
                return sum;
            }
            private set => total = value;
        }
        /// <summary>
        /// Collection Changed Listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }
        /// <summary>
        /// OrderList Constructor, increments the order number
        /// </summary>
        public OrderList()
        {
            CollectionChanged += CollectionChangedListener;
            nextOrderNumber++;
        }
        /// <summary>
        /// Item changed listener, activates when a property changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
        }
    }
}
