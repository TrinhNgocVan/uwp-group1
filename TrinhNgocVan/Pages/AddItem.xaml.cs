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
    public sealed partial class AddItem : Page
    {
        public AddItem()
        {
            this.InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            string username = contactName.Text;
            string password = encrypt.EncryptString(phoneNumber.Password);
            System.Diagnostics.Debug.WriteLine(password);
            ItemDaoImpl itemDao = new ItemDaoImpl();
            List<Item> lsItem = itemDao.GetListItem();
            // check username exist 
            bool flag = true;
            foreach(Item item in lsItem)
            {
                System.Diagnostics.Debug.WriteLine(item.name +"---"+item.phoneNumber);
                if (username.Equals(item.name)){
                    flag = false;
                }
            }
            if(flag == false)
            {
                Message.Text = "Username has already existed . Please choose another username";
            }
            if(flag == true)
            {
                itemDao.AddToListItem(new Item(lsItem[lsItem.Count - 1].id + 1, username, password));
                Message.Text = "Create account success ";
                
            }


       }
       

    }
}
