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
using BleakwindBuffet.Data.Combo;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Order;
using BleakwindBuffet.Data.Sides;
using PointOfSale;
using PointOfSale.ItemOptions.Entrees;
using PointOfSale.ItemOptions.Drinks;
using PointOfSale.ItemOptions.Sides;
using PointOfSale.OrderSideBar;

namespace PointOfSale.ItemOptions
{
    /// <summary>
    /// Interaction logic for ComboOptions.xaml
    /// </summary>
    public partial class ComboOptions : UserControl
    {
        FullMenu ancestor;
        Combo placeholder = new Combo();

        public ComboOptions(FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = placeholder;
            this.ancestor = ancestor;
            ComboboxEntree.Items.Add(new BriarheartBurger());
            ComboboxEntree.Items.Add(new DoubleDraugr());
            ComboboxEntree.Items.Add(new ThalmorTriple());
            ComboboxEntree.Items.Add(new SmokehouseSkeleton());
            ComboboxEntree.Items.Add(new GardenOrcOmelette());
            ComboboxEntree.Items.Add(new PhillyPoacher());
            ComboboxEntree.Items.Add(new ThugsTBone());

            ComboboxSide.Items.Add(new VokunSalad());
            ComboboxSide.Items.Add(new DragonbornWaffleFries());
            ComboboxSide.Items.Add(new MadOtarGrits());
            ComboboxSide.Items.Add(new FriedMiraak());

            ComboboxDrink.Items.Add(new CandlehearthCoffee());
            ComboboxDrink.Items.Add(new MarkarthMilk());
            ComboboxDrink.Items.Add(new SailorSoda());
            ComboboxDrink.Items.Add(new AretinoAppleJuice());
            ComboboxDrink.Items.Add(new WarriorWater());
        }

        public ComboOptions(Combo pl, FullMenu ancestor)
        {
            InitializeComponent();
            this.DataContext = pl;
            this.ancestor = ancestor;
            this.Back.Height = 0;
            this.Add.Height = 0;
            Add.Content = "Done";
            ComboboxEntree.Items.Add(new BriarheartBurger());
            ComboboxEntree.Items.Add(new DoubleDraugr());
            ComboboxEntree.Items.Add(new ThalmorTriple());
            ComboboxEntree.Items.Add(new SmokehouseSkeleton());
            ComboboxEntree.Items.Add(new GardenOrcOmelette());
            ComboboxEntree.Items.Add(new PhillyPoacher());
            ComboboxEntree.Items.Add(new ThugsTBone());

            ComboboxSide.Items.Add(new VokunSalad());
            ComboboxSide.Items.Add(new DragonbornWaffleFries());
            ComboboxSide.Items.Add(new MadOtarGrits());
            ComboboxSide.Items.Add(new FriedMiraak());

            ComboboxDrink.Items.Add(new CandlehearthCoffee());
            ComboboxDrink.Items.Add(new MarkarthMilk());
            ComboboxDrink.Items.Add(new SailorSoda());
            ComboboxDrink.Items.Add(new AretinoAppleJuice());
            ComboboxDrink.Items.Add(new WarriorWater());
        }

        /// <summary>
        /// Handler for ADD/Back button press.
        /// On ADD click: displays the OrderList.xaml in the correct loaction on the screen
        /// and sets Data.Context to a new item Object.
        /// On BACK click: displays the OrderList.xaml in the correct loaction on the screen
        /// but does not set Data.Context to a new item Object.
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">left mouse down</param>
        public void uxButton_Click(object sender, RoutedEventArgs e)
        {
            Combo item = (Combo)this.DataContext;
            Button button = (Button)sender;

            if (button.Name == "Add")
            {
                if (item.Drink == null || item.Entree == null || item.Side == null) MessageBox.Show("Make sure Entree, Drink, and Side are not null before adding combo to order");
                else if (this.ancestor.openSpace.DataContext is OrderList list)
                {
                    if (list.Contains(item))
                    {
                        Add.Content = "Done";
                        this.ancestor.SwitchScreen(Screen.Empty);
                        this.ancestor.openSpace2.Child = new Order(this.ancestor);
                    }
                    else
                    {
                        list.Add(placeholder);
                        this.ancestor.SwitchScreen(Screen.Empty);
                        this.ancestor.openSpace2.Child = new Order(this.ancestor);
                    }
                }
            }
            else if (button.Name == "Back")
            {
                this.ancestor.SwitchScreen(Screen.Empty);
                this.ancestor.openSpace2.Child = new Order(this.ancestor);
            }
        }

        public void uxEntree_Click(object sender, RoutedEventArgs e)
        {
            //if (sender is ComboBox ComboboxEntree && ComboBox.SelectedIndex)
            //{

            IOrderItem item = (IOrderItem)((ComboBox)ComboboxEntree).SelectedItem;
            //entrees
            if (item is BriarheartBurger)
            {
                this.ancestor.screens.Remove(Screen.BBOptions);
                this.ancestor.screens.Add(Screen.BBOptions, new BBOptions((BriarheartBurger)ComboboxEntree.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.BBOptions);
            }

            if (item is DoubleDraugr)
            {
                this.ancestor.screens.Remove(Screen.DDOptions);
                this.ancestor.screens.Add(Screen.DDOptions, new DDOptions((DoubleDraugr)ComboboxEntree.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.DDOptions);
            }
            if (item is ThalmorTriple)
            {
                this.ancestor.screens.Remove(Screen.TTOptions);
                this.ancestor.screens.Add(Screen.TTOptions, new TTOptions((ThalmorTriple)ComboboxEntree.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.TTOptions);
            }
            if (item is GardenOrcOmelette)
            {
                this.ancestor.screens.Remove(Screen.GORCOptions);
                this.ancestor.screens.Add(Screen.GORCOptions, new GORCOptions((GardenOrcOmelette)ComboboxEntree.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.GORCOptions);
            }
            if (item is SmokehouseSkeleton)
            {
                this.ancestor.screens.Remove(Screen.SSOptions);
                this.ancestor.screens.Add(Screen.SSOptions, new SSOptions((SmokehouseSkeleton)ComboboxEntree.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.SSOptions);
            }
            if (item is PhillyPoacher)
            {
                this.ancestor.screens.Remove(Screen.PPOptions);
                this.ancestor.screens.Add(Screen.PPOptions, new PPOptions((PhillyPoacher)ComboboxEntree.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.PPOptions);
            }
            if (item is ThugsTBone)
            {
                this.ancestor.screens.Remove(Screen.TTBOptions);
                this.ancestor.screens.Add(Screen.TTBOptions, new TTBOptions((ThugsTBone)ComboboxEntree.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.TTBOptions);
            }
        }

        public void uxDrink_Click(object sender, RoutedEventArgs e)
        {
            IOrderItem item = (IOrderItem)((ComboBox)ComboboxDrink).SelectedItem;
            //drinks
            if (item is WarriorWater)
            {
                this.ancestor.screens.Remove(Screen.WWOptions);
                this.ancestor.screens.Add(Screen.WWOptions, new WWOptions((WarriorWater)ComboboxDrink.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.WWOptions);
            }

            if (item is AretinoAppleJuice)
            {
                this.ancestor.screens.Remove(Screen.AAJOptions);
                this.ancestor.screens.Add(Screen.AAJOptions, new AAJOptions((AretinoAppleJuice)ComboboxDrink.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.AAJOptions);
            }
            if (item is CandlehearthCoffee)
            {
                this.ancestor.screens.Remove(Screen.CCOptions);
                this.ancestor.screens.Add(Screen.CCOptions, new CCOptions((CandlehearthCoffee)ComboboxDrink.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.CCOptions);
            }
            if (item is MarkarthMilk)
            {
                this.ancestor.screens.Remove(Screen.MMOptions);
                this.ancestor.screens.Add(Screen.MMOptions, new MMOptions((MarkarthMilk)ComboboxDrink.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.MMOptions);
            }
            if (item is SailorSoda)
            {
                this.ancestor.screens.Remove(Screen.SSODAOptions);
                this.ancestor.screens.Add(Screen.SSODAOptions, new SSODAOptions((SailorSoda)ComboboxDrink.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.SSODAOptions);
            }
        }
        public void uxSide_Click(object sender, RoutedEventArgs e)
        {
            IOrderItem item = (IOrderItem)((ComboBox)ComboboxSide).SelectedItem;
            //drinks
            //sides
            if (item is DragonbornWaffleFries)
            {
                this.ancestor.screens.Remove(Screen.DWFOptions);
                this.ancestor.screens.Add(Screen.DWFOptions, new DWFOptions((DragonbornWaffleFries)ComboboxSide.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.DWFOptions);
            }

            if (item is FriedMiraak)
            {
                this.ancestor.screens.Remove(Screen.FMOptions);
                this.ancestor.screens.Add(Screen.FMOptions, new FMOptions((FriedMiraak)ComboboxSide.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.FMOptions);
            }
            if (item is MadOtarGrits)
            {
                this.ancestor.screens.Remove(Screen.MOGOptions);
                this.ancestor.screens.Add(Screen.MOGOptions, new MOGOptions((MadOtarGrits)ComboboxSide.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.MOGOptions);
            }
            if (item is VokunSalad)
            {
                this.ancestor.screens.Remove(Screen.VSOptions);
                this.ancestor.screens.Add(Screen.VSOptions, new VSOptions((VokunSalad)ComboboxSide.SelectedItem, this.ancestor, true, ComboboxEntree));
                this.ancestor.SwitchScreen(Screen.VSOptions);
            }
        }
    }
}
