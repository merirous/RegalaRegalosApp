using RegalaRegalosApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RegalaRegalosApp.ViewModels
{
    public class DeliveryViewModel
    {
        public ObservableCollection<Categories> categories { get; set; }
        public ObservableCollection<Product> product { get; set; }
        public DeliveryViewModel()
        {
            categories = new ObservableCollection<Categories>
            {
                new Categories
                {
                    Image="oso",
                    Title="oso"
                }
            };

            product = new ObservableCollection<Product>
            {
                new Product
                {
                    Image = "MenuOption",
                    Title = "Chicken Royal",
                    Type = "Hamgurguesa",
                    Price = "$15"
                }
            };
        }
    }
}
