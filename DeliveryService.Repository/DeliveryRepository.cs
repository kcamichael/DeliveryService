
public class DeliveryRepository
{
    private List<Delivery> _deliveryDb = new List<Delivery>();
    private int _count = 0;

    //C.R.U.D

    //Create
    public bool AddDelivery(Delivery delivery)
    {
        if (Delivery is null)
        {
            return false;
        }
        else
        {
            _count++;
            delivery.ID = _count;
            _deliveryDb.Add(Delivery);
            return true;
        }
    }

    //Read All
    public List<Delivery> GetDeliveries()
    {
        return _deliveryDb;
    }

    //Read by ID
    public Delivery GetDeliveryByID(int DeliveryID)
    {
        foreach (Delivery delivery in _deliveryDb)
        {
            if (delivery.ID == DeliveryID)
            {
                return delivery;
            }
        }
        return null;
    }

    //Update
    public bool UpdateDeliveryData(int deliveryId, Delivery newDeliveryDataFromUI)
    {
        //! helper method:                                                      Expound on what this does?
        Delivery oldDeliveryData = GetDeliveryByID(deliveryId);

        if (oldDeliveryData != null)
        {
            oldDeliveryData.DeliveryID = newDeliveryDataFromUI.DeliveryID;
            oldDeliveryData.OrderDate = newDeliveryDataFromUI.OrderDate;
            oldDeliveryData.DeliveryDate = newDeliveryDataFromUI.DeliveryDate;
            oldDeliveryData.OrderStatus = newDeliveryDataFromUI.OrderStatus;
            oldDeliveryData.ItemNumber = newDeliveryDataFromUI.ItemNumber;
            oldDeliveryData.ItemQuantity = newDeliveryDataFromUI.ItemQuantity;
            oldDeliveryData.CustomerID = newDeliveryDataFromUI.CustomerID;
            return true;
        }
        return false;
    }

    //Delete
    public bool RemoveDelivery(int deliveryId)
    {
        return _deliveryDb.Remove(GetDeliveryByID(deliveryId));
    }
}