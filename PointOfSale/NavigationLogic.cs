using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;


namespace PointOfSale
{
    public class NavigationLogic
    {
        public Border OpenSpace { get; set; }
        public NavigationLogic(Border b)
        {
            OpenSpace = b;
        }
    }
}
