using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        private List<Order> _Orders = new List<Order>();
        public List<Order> Orders { get => _Orders; set => _Orders = value; }

        public OrderPage()
        {
            this.InitializeComponent();
        }

        

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            object SelectedItem = MenuItemsList.SelectedItem;
            (this.DataContext as DataManager).CurrentlySelectedMenuItems.Add((String)SelectedItem);
        }

        private void SubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            //Submit the Order
            DataManager Item = (this.DataContext as DataManager);
            Item.OrderItems.Add(new Order(Item.CurrentlySelectedMenuItems.ToList<String>()));
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(MainPage));
        }        

        private void MenuItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void SelectedMenuItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
