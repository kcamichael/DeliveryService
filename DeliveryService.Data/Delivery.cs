// POCOs
public class Delivery
{
    public DateOnly OrderDate { get; set; }
    public DateOnly DeliveryDate { get; set; }
    public bool OrderStatus { get; set; }           //! string? bool w/ loops?
    public int ItemNumber { get; set; }
    public int ItemQuantity { get; set; }
    public int CustomerID { get; set; }

    public override string ToString()
    {
        string str = $"OrderDate: {OrderDate}\n" +
                    $"Delivery Date: {DeliveryDate}\n" +
                    $"Order Status: {OrderStatus}\n" +
                    $"Item Number: {ItemNumber}\n" +
                    $"Item Quantity: {ItemQuantity}\n" +
                    $"Customer Account Number: {CustomerID}\n" +
                    "=============================\n";
        return str;
    }
    Delivery delivery = new Delivery
    {
        OrderDate = DateTime.Now,
        DeliveryDate = DateTime.Now.AddDays(5),
        Status = DeliveryStatus.Scheduled,
        ItemNumber = 12345,
        ItemQuantity = 2,
        CustomerID = 9876
    };

    Console.WriteLine(delivery.ToString());
}
