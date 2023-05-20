// POCOs
public class Delivery
{
    public int DeliveryID { get; set; }
    public DateOnly OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
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
        OrderDate = DateOnly.
        DeliveryDate = DateTime.Now.AddDays(5), //...Maybe?
        OrderStatus = DeliveryStatus.Scheduled,
        ItemNumber = 123,
        ItemQuantity = 2,
        CustomerID = 0001
    };
    Console.WriteLineNewStruct(.ToString());

    
}
