namespace FoodDeliveryApp
{
    public class Order
    {
        public string RestaurantName { get; set; }
        public string Item { get; set; }
        public string Location { get; set; }
        public double Distance { get; set; }
        public double DeliveryFee { get; set; }
        public double ItemPrice { get; set; }
        public double TotalAmount { get; set; }

        public Order(string restaurantName, string item, string location, double distance, double deliveryFee, double itemPrice, double totalAmount)
        {
            RestaurantName = restaurantName;
            Item = item;
            Location = location;
            Distance = distance;
            DeliveryFee = deliveryFee;
            ItemPrice = itemPrice;
            TotalAmount = totalAmount;
        }
    }
}