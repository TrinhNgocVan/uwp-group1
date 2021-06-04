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
        public Layout()
        {
            this.InitializeComponent();
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            MN.Items.Add(new MenuItem { Name = "Home", MenuPage = "Home" });
            MN.Items.Add(new MenuItem { Name = "Category", MenuPage = "Category" });
            MN.Items.Add(new MenuItem { Name = "Collection", MenuPage = "Collection" });
            MN.Items.Add(new MenuItem { Name = "Delivery", MenuPage = "Delivery" });
            MN.Items.Add(new MenuItem { Name = "TakeAway", MenuPage = "TakeAway" });
            MN.Items.Add(new MenuItem { Name = "DriverPayment", MenuPage = "DriverPayment" });
            MN.Items.Add(new MenuItem { Name = "Customers", MenuPage = "Customers" });
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem item = MN.SelectedItem as MenuItem;
            switch (item.MenuPage)
            {
                case "Home": MainFrame.Navigate(typeof(Pages.Home), "Day la trang chu "); break;
                case "Category": MainFrame.Navigate(typeof(Pages.EatIn)); break;
                case "Collection": MainFrame.Navigate(typeof(Pages.Collection),"1"); break;
                case "Delivery": MainFrame.Navigate(typeof(Pages.Delivery), "Day la Delivery "); break;
                case "TakeAway": MainFrame.Navigate(typeof(Pages.TakeAway), "Day la TakeAway "); break;
                case "DriverPayment": MainFrame.Navigate(typeof(Pages.DriverPayment), "Day la DriverPayment "); break;
                case "Customers": MainFrame.Navigate(typeof(Pages.Customers), "Day la Customers "); break;
                
            }
        }
    
}
}
