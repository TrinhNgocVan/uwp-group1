using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinhNgocVan.Models;
namespace TrinhNgocVan.Dao
{
    interface ItemDao
    {
        List<Item> GetListItem();
        bool AddToListItem(Item item);
        bool RemoveItem(Item item);
        bool UpdateItem(Item item);
        bool ClearAllItem();
        bool CheckItemExist(Item item);
        Item searchItemByName(Item item);
    }
}
