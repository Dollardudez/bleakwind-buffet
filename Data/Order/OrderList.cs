using BleakwindBuffet.Data.Interface;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Order
{
    public class OrderList : ObservableCollection<IOrderItem>, INotifyCollectionChanged
    {
        private static int nextOrderNumber = 1;

        public int Number
        {
            get => nextOrderNumber;
        }

        private double salestaxrate = 0.12;

        public double SalesTaxRate
        {
            get => salestaxrate;
            set => salestaxrate = value;
        }
        private double subtotal;
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
            private set => subtotal = value;
        }
        private double tax;
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
        private double total;

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
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            //OnCollectionChanged(new NotifyCollectionChangedEventArgs(e.Action));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(e.Action));
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    //if(e.NewItems == null)
                    //{
                    //    Total = 0;
                    //    Tax = 0;
                    //    Subtotal = 0;
                    //    return;
                    //}
                    foreach (IOrderItem item in e.OldItems)
                    {
                        //IOrderItem obk = (IOrderItem)e.OldItems;
                        //Subtotal -= obk.Price;
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(e.Action));
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        public OrderList()
        {
            CollectionChanged += CollectionChangedListener;
            nextOrderNumber++;
        }

        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
        }
    }
}
