using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Nhom1.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nhom1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public static Frame staticFrame;
        public Layout()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Home));
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            MN.Items.Add(new MenuItem { Name = "Home", MenuPage = "Home" ,icon = "Home" });
            MN.Items.Add(new MenuItem { Name = "Category", MenuPage = "Category", icon = "DockBottom" });
            MN.Items.Add(new MenuItem { Name = "Collection", MenuPage = "Collection", icon = "GlobalNavigationButton" });
            MN.Items.Add(new MenuItem { Name = "Cart", MenuPage = "Cart", icon = "DockBottom" });
            MN.Items.Add(new MenuItem { Name = "Order History", MenuPage = "Order History", icon = "HangUp" });
            MN.Items.Add(new MenuItem { Name = "DriverPayment", MenuPage = "DriverPayment", icon = "Send" });
            MN.Items.Add(new MenuItem { Name = "Customers", MenuPage = "Customers", icon = "People" });
            MN.Items.Add(new MenuItem { Name = "Close" , icon = "Bookmarks" ,MenuPage = "Close" }) ;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            staticFrame = MainFrame ;
            MenuItem item = MN.SelectedItem as MenuItem;
            switch (item.MenuPage)
            {
                case "Home": MainFrame.Navigate(typeof(Pages.Home), "Day la trang chu "); break;
                case "Category": MainFrame.Navigate(typeof(Pages.EatIn)); break;
                case "Collection": MainFrame.Navigate(typeof(Pages.Collection),"1"); break;
                case "Cart": MainFrame.Navigate(typeof(Pages.Delivery),"Null" ); break;
                case "Order History": MainFrame.Navigate(typeof(Pages.TakeAway), "Day la TakeAway "); break;
                case "DriverPayment": MainFrame.Navigate(typeof(Pages.DriverPayment), "Day la DriverPayment "); break;
                case "Customers": MainFrame.Navigate(typeof(Pages.Customers), "Day la Customers "); break;
                case "Close" :  splitview.IsPaneOpen = !splitview.IsPaneOpen  ; break;
                   
            }
        }

        private void icon_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
