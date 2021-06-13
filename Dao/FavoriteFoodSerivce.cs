using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom1.Models;
namespace Nhom1.Dao
{
    interface FavoriteFoodSerivce
    {
        List<CartItem> GetFavoriteList();
        bool AddToFavoriteList(CartItem item);
        bool RemoveFavoriteList(CartItem item);
        bool UpdateFavoriteList(CartItem item, int qty);
        bool ClearFavoriteList();
    }
}
