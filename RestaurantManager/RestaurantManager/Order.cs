using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Order
    {
        private String _OrderName;

        public string OrderName { get => _OrderName; set => _OrderName = value; }
        
        public Order(String Name)
        {
            this._OrderName = Name;
        }
    }
}
