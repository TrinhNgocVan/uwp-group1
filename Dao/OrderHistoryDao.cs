using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom1.Models;
namespace Nhom1.Dao
{
    interface OrderHistoryDao
    {
        List<OrderHistory>  getOrderHistory();
        bool AddToOrderHistory(OrderHistory item);
      
    }
}
