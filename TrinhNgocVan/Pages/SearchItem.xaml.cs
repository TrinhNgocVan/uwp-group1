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
using TrinhNgocVan.Services;
using TrinhNgocVan.Models;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TrinhNgocVan.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchItem : Page
    {
        public SearchItem()
        {
            this.InitializeComponent();

            Read_File();

        }
        private async void Read_File()
        {
            FileHandleService obj = new FileHandleService();
            obj.WriteFile("exam.txt");
            string txt = await obj.ReadFile("exam.txt");
            result.Text = "Json String is :"+ txt;
            

         }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            Read_File();
            
        }
    }
}
