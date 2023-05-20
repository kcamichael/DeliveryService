
public class ProgramUI
{
    //Globally scoped variable container that points to the repo
    //* private DeliveryRepository _dRepo = new DeliveryRepository();

    public Void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            System.Console.WriteLine($"Welcome to Warner Transit Federal\n"+
                "=============Delivery Status============\n"+
                "1. List Enroute Deliveries\n"+
                "2. List Completed Deliveries\n"+
                "============Manage Deliveries===========\n"+
                "3. Add a Delivery\n"+
                "4. Cancel a Delivery\n"+
                "5. Update Delivery Status\n"+
                "==================Exit=================\n"+
                "00. Exit Application\n");

            int userInput = int.Parse(Console.ReadLine()!);

            switch (userInput)
            {
                case 1:
                    ListEnrouteDeliveries();
                    break;
                case 2:
                    ListCompletedDeliveries();
                    break;
                case 3:
                    CreateDelivery();
                    break;
                case 4:
                    DeleteDelivery();
                    break;
                case 5:
                    UpdateDelivery();
                    break;
                case 00:
                    _isRunning = ExitApplication();
                    break;
                default:
                    System.Console.WriteLine("Invalid key entry!");
                    PressAnyKey();
                    break;
            }
        }
    }

    private void PressAnyKey()
    {
        System.Console.WriteLine("Press Any Key To Continue.");
        Console.ReadKey();
    }
    private bool ExitApplication()
    {
        Console.Clear();
        System.Console.WriteLine("Thank you!!");
        PressAnyKey();
        Console.Clear();
        return false;
    }

    private void ListEnrouteDeliveries()
    {
        throw new NotImplementedException();
    }

    private void ListCompletedDeliveries()
    {
        throw new NotImplementedException();
    }
    private void CreateDelivery()
    {
        throw new NotImplementedException();
    }

    private void DeleteDelivery()
    {
        throw new NotImplementedException();
    }

    private void UpdateDelivery()
    {
        throw new NotImplementedException();
    }

    private void UpdateDelivery()
    {
        Console.Clear();
        try
        {
            System.Console.WriteLine("== Update Delivery ==");

            foreach (var delivery in _deliveryDb.GetDeliveries())
            {
                System.Console.WriteLine($"{delivery.ID}");
            }
            System.Console.WriteLine("=============================\n");

            System.Console.WriteLine("Please input a Delivery Id");
            int userInputDeliveryId = int.Parse(Console.ReadLine()!);

            Delivery selectedDelivery = _deliveryRepo.GetDeliveryByID(userInputDeliveryId);

            if (selectedDelivery != null)
            {
                Console.Clear();

                //create an empty form 
                Delivery deliveryForm = new Delivery();

                System.Console.WriteLine("Please enter a Delivery ID:");
                deliveryForm.DeliveryID = Console.ReadLine()!;

                System.Console.WriteLine("Please enter an Order Date:");
                deliveryForm.OrderDate = Console.ReadLine()!;

                System.Console.WriteLine("Please enter a Delivery Date:");
                deliveryForm.DeliveryDate = Console.ReadLine()!;

                System.Console.WriteLine("Please enter an Order Status:");
                deliveryForm.OrderStatus = Console.ReadLine()!;

                System.Console.WriteLine("Please enter an Item Number:");
                deliveryForm.DeliveryDate = Console.ReadLine()!;

                System.Console.WriteLine("Please enter an Item Quantity:");
                deliveryForm.ItemQuantity = Console.ReadLine()!;

                System.Console.WriteLine("Please enter a Customer ID:");
                deliveryForm.CustomerID = Console.ReadLine()!;

                System.Console.WriteLine("Has this delivery been Delivered? y/n");

                string userInput = Console.ReadLine()!.ToLower();

                if (userInput == "y")
                {
                    deliveryForm.OrderStatus = true;
                }
                else
                {
                    deliveryForm.OrderStatus = false;
                }

                if (_deliveryRepo.UpdateDeliveryData(selectedDelivery.DeliveryID, deliveryForm))
                {
                    System.Console.WriteLine("SUCCESS!");
                }
                else
                {
                    System.Console.WriteLine("FAIL!");
                }
            }
            else
            {
                System.Console.WriteLine($"The Delivery with the id: {userInputDeliveryId} doesn't Exist!");
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        PressAnyKey();
    }

    private void CreateDelivery()
    {
        try
        {
            Console.Clear();

            System.Console.WriteLine("== Add Delivery Menu ==");

            //create an empty form 
            Delivery deliveryForm = new Delivery();

            System.Console.WriteLine("Please enter a First Name:");
            deliveryForm.FirstName = Console.ReadLine()!;

            System.Console.WriteLine("Please enter a Last Name:");
            deliveryForm.LastName = Console.ReadLine()!;

            System.Console.WriteLine("Does this Delivery have ? y/n");

            string userInput = Console.ReadLine()!.ToLower();

            if (userInput == "y")
            {
                deliveryForm.Delivery = true;
            }
            else
            {
                deliveryForm.Delivery = false;
            }

            if (_deliveryRepo.AddDelivery(deliveryForm))
            {
                System.Console.WriteLine("SUCCESS!");
            }
            else
            {
                System.Console.WriteLine("FAIL!");
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        PressAnyKey();
    }


}