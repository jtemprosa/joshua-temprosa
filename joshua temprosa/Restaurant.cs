using System.Collections.Generic;

namespace FoodDeliveryApp
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> Menu { get; set; }

        public Restaurant(string name, string address, List<string> menu)
        {
            Name = name;
            Address = address;
            Menu = menu;
        }
    }
}