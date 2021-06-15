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
using TrinhNgocVan.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TrinhNgocVan.Pages
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
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            MN.Items.Add(new MenuItem { Name = "Home", MenuPage = "Home", icon = "Home" });
            MN.Items.Add(new MenuItem { Name = "Register", MenuPage = "AddItem", icon = "DockBottom" });
            MN.Items.Add(new MenuItem { Name = "Json read", MenuPage = "Json read", icon = "GlobalNavigationButton" });
            MN.Items.Add(new MenuItem { Name = "Close", icon = "Bookmarks", MenuPage = "Close" });
        }
        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            staticFrame = MainFrame;
            MenuItem item = MN.SelectedItem as MenuItem;
            switch (item.MenuPage)
            {
                case "Home": MainFrame.Navigate(typeof(Pages.Home), "Day la trang chu "); break;
                case "AddItem": MainFrame.Navigate(typeof(Pages.AddItem)); break;
                case "Json read": MainFrame.Navigate(typeof(Pages.SearchItem)); break;
                case "Close": splitview.IsPaneOpen = !splitview.IsPaneOpen; break;

            }
        }

    }
}
