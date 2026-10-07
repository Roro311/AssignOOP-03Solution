namespace AssignOOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1: Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?
            //Method Overloading: Allows a class to have multiple methods with the same name but different Parameters.
            //Method Overriding: Allows a derived class to provide a specific implementation of a method that is already defined in its base class

            //b)  What is the difference between Static Binding and Dynamic Binding?
            //Static Binding: The binding of a method call to its implementation is determined at compile time. This is used for methods that are not overridden.
            //Dynamic Binding: The binding of a method call to its implementation is determined at runtime. This is used for overridden methods.


            #endregion

            #region Q2  Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //The sealed keyword is used to prevent a class from being inherited.
            //When a class is marked as sealed, it cannot be used as a base class for any other class.
            //This is useful when you want to restrict the inheritance hierarchy and ensure that the class's behavior remains unchanged.

            //b)  What is the difference between a sealed class and a sealed method?
            //A sealed class is a class that cannot be inherited, while a sealed method is a method that cannot be overridden in derived classes.

            //c)  Can a sealed method be overridden? Why?
            //No, a sealed method cannot be overridden.
            //When a method is marked as sealed, it prevents any derived class from overriding that method.

            #endregion

            #endregion

            #region Part 02 — Practical
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");

            // a. Create a Driver
            Driver driver = new Driver("Ahmed Mohamed");

            // b. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter("Main Delivery Center");

            // c. Assign Driver to DeliveryCenter
            center.AssignedDriver = driver;

            Console.WriteLine($"Driver : {center.AssignedDriver.Name}");

            // Address
            DeliveryAddress address1 =
                new DeliveryAddress("Cairo", "Nasr City", 10);

            DeliveryAddress address2 = address1;

            address2.Street = "New Cairo";

            // d. Create StandardShipment
            StandardShipment standard =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    80,
                    address1);

            // e. Create ExpressShipment
            ExpressShipment express =
                new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2,
                    60,
                    address1,
                    30);

            // f. Create InternationalShipment
            InternationalShipment international =
                new InternationalShipment(
                    "SH003",
                    "Television",
                    8,
                    120,
                    address1,
                    "Germany",
                    100);

            // g. Add all shipments
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            // h. Print all shipments
            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine("==========================================");

            // i. DeliveryHelper
            DeliveryHelper.PrintShipmentDetails(standard);
            DeliveryHelper.PrintShipmentDetails(express);
            DeliveryHelper.PrintShipmentDetails(international);

            Console.WriteLine("==========================================");
            Console.WriteLine("Updating Weight...");
            Console.WriteLine("==========================================");

            // j. Demonstrate both UpdateWeight versions

            Console.WriteLine($"Original Weight : {standard.Weight} KG");

            // Version 1
            standard.UpdateWeight(5);

            Console.WriteLine($"Updated Weight : {standard.Weight} KG");

            // Version 2
            standard.UpdateWeight(5, 0.5m);

            Console.WriteLine(
                $"Updated Weight After Packing : {standard.Weight} KG");

            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine("==========================================");

            // k. Mixed Shipment array
            Shipment[] mixedShipments =
            {
            standard,
            express,
            international
        };

            for (int i = 0; i < mixedShipments.Length; i++)
            {
                mixedShipments[i].PrintShipment();
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("Demonstrating Address Copy");
            Console.WriteLine("==========================================");

            Console.WriteLine(
                $"Original Address : {address1.GetFullAddress()}");

            Console.WriteLine(
                $"Copied Address : {address2.GetFullAddress()}");

            Console.WriteLine("==========================================");
            Console.WriteLine("Demonstrating Sealed Class");
            Console.WriteLine("==========================================");

            CompletedShipment completed =
                new CompletedShipment(
                    "SH004",
                    "Book",
                    1,
                    50,
                    address1);

            completed.PrintShipment();

            Console.WriteLine("==========================================");
            Console.WriteLine("Demonstrating Sealed Method");
            Console.WriteLine("==========================================");

            PriorityInternationalShipment priority =
                new PriorityInternationalShipment(
                    "SH005",
                    "Documents",
                    2,
                    100,
                    address1,
                    "France",
                    40);

            priority.GenerateCustomsReport();

            Console.WriteLine("==========================================");
            #endregion
        }
    }
}
