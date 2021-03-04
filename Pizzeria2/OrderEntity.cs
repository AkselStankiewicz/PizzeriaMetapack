using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria2
{
    class OrderEntity
    {
        public int id {get;}
        public string name { get; }
        public string ingrediences { get; }
        public int price { get; }

        public OrderEntity(int id, string name, string ingrediences, int price)
        {
            this.id = id;
            this.name = name;
            this.ingrediences = ingrediences;
            this.price = price;
        }
    }
}
