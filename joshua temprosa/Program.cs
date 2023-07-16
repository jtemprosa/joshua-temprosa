using System;
using System.Collections.Generic;

namespace FoodDeliveryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of available restaurants
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants.Add(new Restaurant("Jollibee", "123 Main St.", new List<string> { "burger", "Spaghetti", "Coke float" }));
            restaurants.Add(new Restaurant("Mc Donald", "456 Elm St.", new List<string> { "fried chicken", "bff fries", "Mc float" }));
            restaurants.Add(new Restaurant("KFC", "789 Oak St.", new List<string> { "pancit canton", "fries", "milkshakes" }));

            // Display the list of restaurants
            Console.WriteLine("Available Restaurants:");
            for (int i = 0; i < restaurants.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + restaurants[i].Name + " - " + restaurants[i].Address);
            }

            // Get the user's selection
            Console.Write("Enter the number of the restaurant you'd like to order from: ");
            int selection = int.Parse(Console.ReadLine()) - 1;
            Restaurant chosenRestaurant = restaurants[selection];

            // Display the menu
            Console.WriteLine("Menu:");
            for (int i = 0; i < chosenRestaurant.Menu.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + chosenRestaurant.Menu[i]);
            }

            // Get the user's order
            Console.Write("Enter the number of the item you'd like to order: ");
            int orderSelection = int.Parse(Console.ReadLine()) - 1;
            string chosenItem = chosenRestaurant.Menu[orderSelection];

            // Get the user's location
            Console.Write("Enter your current location (e.g. 123 Main St.): ");
            string location = Console.ReadLine();

            // Get the delivery distance
            Console.Write("Enter the delivery distance in kilometers: ");
            double distance = double.Parse(Console.ReadLine());

            // Calculate the delivery fee based on distance
            double deliveryFee = 0;
            if (distance <= 3)
            {
                deliveryFee = 50;
            }
            else if (distance <= 6)
            {
                deliveryFee = 75;
            }
            else if (distance <= 10)
            {
                deliveryFee = 100;
            }
            else
            {
                deliveryFee = 150;
            }

            // Calculate the item price
            double itemPrice = 0;
            switch (chosenItem)
            {
                case "burger":
                    itemPrice = 50;
                    break;
                case "Spaghetti":
                    itemPrice = 70;
                    break;
                case "Coke float":
                    itemPrice = 40;
                    break;
                case "fried chicken":
                    itemPrice = 80;
                    break;
                case "bff fries":
                    itemPrice = 60;
                    break;
                case "Mc float":
                    itemPrice = 45;
                    break;
                case "pancit canton":
                    itemPrice = 55;
                    break;
                case "fries":
                    itemPrice = 40;
                    break;
                case "milkshakes":
                    itemPrice = 65;
                    break;
                default:
                    break;
            }

            // Create the order
            double totalAmount = deliveryFee + itemPrice;
            Order newOrder = new Order(chosenRestaurant.Name, chosenItem, location, distance, deliveryFee, itemPrice, totalAmount);

            // Display the order details
            Console.WriteLine("Order Details:");
            Console.WriteLine("Restaurant: " + newOrder.RestaurantName);
            Console.WriteLine("Item: " + newOrder.Item);
            Console.WriteLine("Location: " + newOrder.Location);
            Console.WriteLine("Distance: " + newOrder.Distance + " km");
            Console.WriteLine("Delivery Fee: $" + newOrder.DeliveryFee);
            Console.WriteLine("Item Price: $" + newOrder.ItemPrice);
            Console.WriteLine("Total Amount: $" + newOrder.TotalAmount);

            // Wait for the user to press a key before exiting
            Console.ReadKey();
        }
    }
}
