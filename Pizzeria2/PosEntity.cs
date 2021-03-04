using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria2
{
    class PosEntity
    {
        public int id { get; }
        public string dishes { get; }
        public float price { get; }
        public string adnotations { get; }
        public int order_id { get; }

        public PosEntity(int id, string dishes, float price, string adnotations, int order_id)
        {
            this.id = id;
            this.dishes = dishes;
            this.price = price;
            this.adnotations = adnotations;
            this.order_id = order_id;
        }

    }
}
