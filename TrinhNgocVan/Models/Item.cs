using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinhNgocVan.Models
{
    class Item
    {
        public Item()
        {
        }
        public Item(int id, string name, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
       
    }
}
