using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public class DataManager
    {
        public DataManager()
        {
            this.OrderItems = new ObservableCollection<Order>();
              

              this.MenuItems = new ObservableCollection<string>
              {
                "Steak",
                "Chicken",
                "Peas",
                "Rice",
                "Hummus",
                "Pita"
              };

              this.CurrentlySelectedMenuItems = new ObservableCollection<string>
              {
                "Rice",
                "Pita"
              };

        }

        public ObservableCollection<Order> OrderItems { get; set; }
        public ObservableCollection<string> MenuItems { get; set; }
        public ObservableCollection<string> CurrentlySelectedMenuItems { get; set; }

        
    }
}
