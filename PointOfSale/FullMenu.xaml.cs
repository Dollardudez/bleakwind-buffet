/*
* Author: Robert Clancy
* Class name: OrderList.xaml.cs.cs
* Purpose: Class used to operate the logic for the FullMenu.xaml UserControl
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
using PointOfSale.ItemOptions.Entrees;
using PointOfSale.ItemOptions.Sides;
using PointOfSale.ItemOptions.Drinks;
using PointOfSale.OrderSideBar;
using BleakwindBuffet.Data.Order;
using System.Threading.Tasks;
using PointOfSale.ItemOptions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FullMenu.xaml
    /// </summary>
    public partial class FullMenu : UserControl
    {
        /// <summary>
        /// dictionary holds all enums for switching screens
        /// </summary>
        public Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();

        OrderList orderList = new OrderList();
        /// <summary>
        /// Initializes the FullMenu UserControl and displays the OrderList.xaml in the correct position on the creen
        /// </summary>
        public FullMenu()
        {
            InitializeComponent();
            openSpace.DataContext = orderList;
            openSpace2.DataContext = openSpace.DataContext;
            openSpace2.Child = new Order(this);

            screens.Add(Screen.Empty, new Empty());
            screens.Add(Screen.Combo, new ComboOptions(this));
            screens.Add(Screen.Order, new Order(this));
            screens.Add(Screen.PaymentOptions, new PaymentOptions(this));
            screens.Add(Screen.CashPayment, new CashPayment(this));

            screens.Add(Screen.BBOptions, new BBOptions(this));
            screens.Add(Screen.DDOptions, new DDOptions(this));
            screens.Add(Screen.TTOptions, new TTOptions(this));
            screens.Add(Screen.GORCOptions, new GORCOptions(this));
            screens.Add(Screen.SSOptions, new SSOptions(this));
            screens.Add(Screen.PPOptions, new PPOptions(this));
            screens.Add(Screen.TTBOptions, new TTBOptions(this));

            screens.Add(Screen.DWFOptions, new DWFOptions(this));
            screens.Add(Screen.FMOptions, new FMOptions(this));
            screens.Add(Screen.MOGOptions, new MOGOptions(this));
            screens.Add(Screen.VSOptions, new VSOptions(this));

            screens.Add(Screen.AAJOptions, new AAJOptions(this));
            screens.Add(Screen.WWOptions, new WWOptions(this));
            screens.Add(Screen.MMOptions, new MMOptions(this));
            screens.Add(Screen.SSODAOptions, new SSODAOptions(this));
            screens.Add(Screen.CCOptions, new CCOptions(this));
        }
        /// <summary>
        /// A single handler to operate the logic for when any Menu Item Button is clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">mouse event</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string name = button.Name;
            switch (name) 
            {
                case "uxCombo":
                    screens.Remove(Screen.Combo);
                    ComboOptions cmbo = new ComboOptions(this);
                    screens.Add(Screen.Combo, cmbo);
                    SwitchScreen(Screen.Combo);
                    break;
                //entrees
                case "uxBB":
                    screens.Remove(Screen.BBOptions);
                    BBOptions bbop = new BBOptions(this);
                    screens.Add(Screen.BBOptions, bbop);
                    SwitchScreen(Screen.BBOptions);
                    break;
                case "uxDD":
                    screens.Remove(Screen.DDOptions);
                    screens.Add(Screen.DDOptions, new DDOptions(this));
                    SwitchScreen(Screen.DDOptions);
                    break;
                case "uxTT":
                    screens.Remove(Screen.TTOptions);
                    screens.Add(Screen.TTOptions, new TTBOptions(this));
                    SwitchScreen(Screen.TTOptions);
                    break;
                case "uxTTB":
                    screens.Remove(Screen.TTBOptions);
                    screens.Add(Screen.TTBOptions, new TTBOptions(this));
                    SwitchScreen(Screen.TTBOptions);
                    break;
                case "uxPP":
                    screens.Remove(Screen.PPOptions);
                    screens.Add(Screen.PPOptions, new PPOptions(this));
                    SwitchScreen(Screen.PPOptions);
                    break;
                case "uxSS":
                    screens.Remove(Screen.SSOptions);
                    screens.Add(Screen.SSOptions, new SSOptions(this));
                    SwitchScreen(Screen.SSOptions);
                    break;
                case "uxGORC":
                    screens.Remove(Screen.GORCOptions);
                    screens.Add(Screen.GORCOptions, new GORCOptions(this));
                    SwitchScreen(Screen.GORCOptions);
                    break;

                //sides
                case "uxDWF":
                    screens.Remove(Screen.DWFOptions);
                    screens.Add(Screen.DWFOptions, new DWFOptions(this));
                    SwitchScreen(Screen.DWFOptions);
                    break;
                case "uxFM":
                    screens.Remove(Screen.FMOptions);
                    screens.Add(Screen.FMOptions, new FMOptions(this));
                    SwitchScreen(Screen.FMOptions);
                    break;
                case "uxMOG":
                    screens.Remove(Screen.MOGOptions);
                    screens.Add(Screen.MOGOptions, new MOGOptions(this));
                    SwitchScreen(Screen.MOGOptions);
                    break;
                case "uxVS":
                    screens.Remove(Screen.VSOptions);
                    screens.Add(Screen.VSOptions, new VSOptions(this));
                    SwitchScreen(Screen.VSOptions);
                    break;

                //drinks
                case "uxWW":
                    screens.Remove(Screen.WWOptions);
                    screens.Add(Screen.WWOptions, new WWOptions(this));
                    SwitchScreen(Screen.WWOptions);
                    break;
                case "uxAAJ":
                    screens.Remove(Screen.AAJOptions);
                    screens.Add(Screen.AAJOptions, new AAJOptions(this));
                    SwitchScreen(Screen.AAJOptions);
                    break;
                case "uxCC":
                    screens.Remove(Screen.CCOptions);
                    screens.Add(Screen.CCOptions, new CCOptions(this));
                    SwitchScreen(Screen.CCOptions);
                    break;
                case "uxMM":
                    screens.Remove(Screen.MMOptions);
                    screens.Add(Screen.MMOptions, new MMOptions(this));
                    SwitchScreen(Screen.MMOptions);
                    break;
                case "uxSSODA":
                    screens.Remove(Screen.SSODAOptions);
                    screens.Add(Screen.SSODAOptions, new SSODAOptions(this));
                    SwitchScreen(Screen.SSODAOptions);
                    break;
                default:
                    break;
            }            
        }
        /// <summary>
        /// to be used eventually
        /// </summary>
        /// <param name="screen"></param>
        public void SwitchScreen(Screen screen)
        {
            openSpace.Child = screens[screen];
        }
        /// <summary>
        /// to be used eventually
        /// </summary>
        /// <param name="screen"></param>
        public void SwitchSecondScreen(Screen screen)
        {
            openSpace2.Child = screens[screen];
        }
    }
}
