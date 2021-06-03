﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nhom1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed   partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            GetMenu();
        }
        public async void GetMenu() // bao hieu rang se su dung cu phap xu ly bat dong bo hoa
        {
            // lay data tu api va nap vao MNItems
            //HttpClient httpClient = new HttpClient();// day la shipper lay hang 
            //var response = await httpClient.GetAsync(""); // file_get_content(); // CURL 
            /*  if(response.StatusCode  == HttpStatusCode.OK)
              {
                  var stringContent = await response.Content.ReadAsStringAsync(); // day chinh la string json // read content response
                  // convert cai string tren thanh 1 object Menu -- php json_decode  js: JSON_parser
                  Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                  MNItems.ItemsSource = menu.data;
              }
  */
            // dung MenuService
            HomeService service = new HomeService();
            HomePageRoot home = await service.GetHomePage();
            if (home != null)
            {
                MNItems.ItemsSource = home.data;
            }
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
            // Title.Text = msg;
        }
        private void ResName_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
