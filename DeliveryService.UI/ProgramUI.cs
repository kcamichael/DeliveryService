
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
}

//     public void AddDelivery();
//     {
//         _dRepo.AddDelivery
//     }
// }
