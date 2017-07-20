using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public class Order
    {
        private List<String>  _Items;

        public List<String> Items { get => _Items; set => _Items = value; }
        
        public Order(List<String> MenuItems)
        {
            this._Items = MenuItems;
        }

        public override string ToString()
        {
            String Result = "";
            for(int i = 0; i < this.Items.Count; i++)
            {
                if (i > 0)
                {
                    Result += ", ";
                }
                Result += this.Items[i];
            }


            return Result;
        }
    }
}
