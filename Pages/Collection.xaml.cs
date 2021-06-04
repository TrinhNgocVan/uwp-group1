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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nhom1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Collection : Page
    {
        public Collection()
        {
            this.InitializeComponent();
        

        }
        protected  override void OnNavigatedTo(NavigationEventArgs e)
        {
          
            String foodIdString = e.Parameter as String ;
            Console.WriteLine("foodId : " + foodIdString);
            if (foodIdString != null) {
                int foodId = int.Parse(foodIdString);
                 getFoodDetail(foodId);
            }
            


         }
        public async void getFoodDetail(int id)
        {
            List<Food> lsFoods = new List<Food>();
            DetailService service = new DetailService();
            FoodDetail food = await service.getFoodDetail(id);
            lsFoods.Add(food.data);
            MNItems.ItemsSource = lsFoods;
          
        }
    }
}
