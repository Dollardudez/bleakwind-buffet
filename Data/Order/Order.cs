using BleakwindBuffet.Data.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Order
{
    class Order : ObservableCollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {

    }
}
