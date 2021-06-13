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
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Nhom1.Services;
using Nhom1.Dao.Impl;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nhom1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            GetMenu();
            getFavorList();
        }
        public async void GetMenu() // bao hieu rang se su dung cu phap xu ly bat dong bo hoa
        {
            HomeService service = new HomeService();
            HomePageRoot home = await service.GetHomePage();
            if (home != null)
            {
                MNItems.ItemsSource = home.data;
            }
        }
        public  void getFavorList()
        {
            FavorteList favorDao = new FavorteList();
            if(favorDao.GetFavoriteList() == null)
            {  
            }
            else {
               
                FavoriteItems.ItemsSource = favorDao.GetFavoriteList();
            }
       

        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
            
        }
        private void ResName_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var foodId = (int)((GridViewItem)sender).Tag;
            System.Diagnostics.Debug.WriteLine("foodId :" + foodId);
            Layout.staticFrame.Navigate(typeof(Pages.Collection), foodId);
        }
    }
}
