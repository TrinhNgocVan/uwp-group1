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
using Nhom1.Dao.Impl;
using Nhom1.Services;
using Nhom1.Adapters;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nhom1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Delivery : Page
    {
        private static List<CartItem> lsCartItems;
        public Delivery()
        {
            this.InitializeComponent();
            Cart cart = new Cart();
            lsCartItems = cart.GetCart();
            MNItems.ItemsSource = lsCartItems;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            

            OrderService orderService = new OrderService();
            Cart cart = new Cart();
            CreateOrder co = await orderService.CreateOrder(cart.GetCart());
            if(co.data != null)
            {
                OrderHistoryImpl obj = new OrderHistoryImpl();
                OrderHistory newOrderHistory = new OrderHistory(co.data.order_id, co.data.order_id.ToString(), DateTime.Now.ToString("HH:mm:ss tt"));
                obj.AddToOrderHistory(newOrderHistory);
                foreach(OrderHistory item in obj.getOrderHistory())
                {
                    System.Diagnostics.Debug.WriteLine(item.id + "---" + item.time);
                }
                int total = 0;
                foreach(CartItem item in lsCartItems)
                {
                    FavorteList favorList = new FavorteList();
                    total += item.price * item.qty;
                    if (!favorList.checkItemExist(item))
                    {
                        favorList.AddToFavoriteList(item);
                    }
                    
                }
                cart.ClearCart();
                Layout.staticFrame.Navigate(typeof(Pages.Delivery),"Order success");
                result.Text = "Order Success . Your total price is " +total+" $";

            }
            
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
           

            Cart cart = new Cart();
            lsCartItems = cart.GetCart();
            if(lsCartItems.Count == 0)
            {
                result.Text = "You have no order yet ! Let add food to order now ";
                orderButton.Visibility = Visibility.Collapsed;
            }
            if(lsCartItems.Count >= 1 && !msg.Equals("Null"))
            {
                result.Text = msg;
               
            }
            if(lsCartItems.Count > 0)
            {
                orderButton.Visibility = Visibility.Visible ;
            }
        }
    }
}
