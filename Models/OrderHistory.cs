using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1.Models
{
    class OrderHistory
    {   
        public OrderHistory(int id , String orderId , String time)
        {
            this.id = id;
            this.orderId = orderId;
            this.time = time;
        }
        public int id { get; set; }
        public String orderId { get; set; }
        public String time { get; set; }
    }
}
