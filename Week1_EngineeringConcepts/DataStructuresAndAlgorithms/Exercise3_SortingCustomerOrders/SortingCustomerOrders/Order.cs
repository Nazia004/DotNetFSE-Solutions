namespace SortingCustomerOrders
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public double TotalPrice { get; set; }

        public Order(int orderId, string customerName, double totalPrice)
        {
            OrderId = orderId;
            CustomerName = customerName;
            TotalPrice = totalPrice;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, Customer: {CustomerName}, Total Price: ₹{TotalPrice}";
        }
    }
}