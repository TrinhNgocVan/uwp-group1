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
using TrinhNgocVan.Dao.Impl;
using TrinhNgocVan.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TrinhNgocVan.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Item itemCheck = new Item();
           
            ItemDaoImpl itemDao = new ItemDaoImpl();
            List<Item> lsItem = itemDao.GetListItem();
            Encrypt encrypt = new Encrypt();
            string username = contactName.Text;
            string password = phoneNumber.Password;
            bool flag = false;
            foreach(Item item in lsItem)
            {
                if(item.name == username)
                {
                    itemCheck = item;
                   flag = true; 
                }
            }
            if(flag == false)
            {
                Message.Text = "Username not found";
            }
            else
            {
                if (encrypt.EncryptString(password).Equals(itemCheck.phoneNumber))
                {
                    Message.Text = "Login success";
                }
                else
                {
                    Message.Text = "Login Failed . Passsword incorrect !.";
                }
            }

        }
    }
}
