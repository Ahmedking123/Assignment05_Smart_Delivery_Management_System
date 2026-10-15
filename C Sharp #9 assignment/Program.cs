using C_Sharp__9_assignment.Shipments;

namespace C_Sharp__9_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Question

            //Q1/ they both will hold the same reference
            //Q2/ no it doesn't create a new object since it will point to the same object since they both hold the same reference
            //Q3/ coping the object creates a new object that holds the same values but a different reference while copying the reference will point to the same object in memory

            #endregion

            #region Second Question

            //Q1/ shallow copy copies the values of the object and the references of the reference types
            //Q2/ deep copy copies the values of the object and creates new objects for the reference types
            //Q3/ it copies the references so it will point to the same object
            //Q4/ it creates new object for the references
            //Q5/ when dealing with an abject that has reference types so when the object is copied the new copy will hold new references for the reference types so when a change is required it will not affect the original object

            #endregion

            #region Third Question

            //Q1/ static field its values is shared among all instances while instance field its values is unique to each instance
            //Q2/ static methods is method that can be called without creating an instance of the class, no it cannot.
            //Q3/ static constructor is called once only before the call of any other constructor and only initializes static fields,it is excuted once creating an instance of the class for the first time
            //Q4/static class is a class that can't create an instance from it,no it is not possible

            #endregion

            #region Fourth question

            //Q1/ extansions method adds new method to the existing datat types without modifying it
            //Q2/ this keyword
            //Q3/ static class
            //Q4/ no it cannot

            #endregion

            #region Fifth Question

            //Q1/ is a class its members are divided in two different places
            //Q2/ to organize the code
            //Q3/ is a method its functionality is divided in to different places or its body is implemented in a different place
            //Q4/ it drops a compile-time error

            #endregion

            #region Practical Part

            //Creating delivery center
            DeliveryCenter.CenterName = "Mansoura Delivery Center";
            Driver driver = new Driver("Ahmed");
            DeliveryCenter deliveryCenter = new DeliveryCenter(driver);

            DeliveryUtilities.PrintSystemTitle();
            Console.WriteLine("\n\nShipment System Initialized\n\n");
            DeliveryUtilities.PrintSeperator();
            
            //Creating shipments
            Console.WriteLine("\nTotal Shipment created: " + Shipment.GetTotalShipmentCreated());
            DeliveryUtilities.PrintSeperator();
            Console.WriteLine("Creating Shipments.....");
            DeliveryUtilities.PrintSeperator();

            Shipment standardShipment = new StandardShipment("Sh 001", "Laptop", 2.3m, 50m, new DeliveryAddress("Mansoura", "Ahmed maher", 20));
            Shipment expressShipment = new ExpressShipment("Sh 002", "Phone", 0.217m, 50m, new DeliveryAddress("Mansoura", "El Gomhoria", 37), 20);
            Shipment internationalShipment = new InternationalShipment("Sh 003", "AMD CPU", 0.120m, 2000, new DeliveryAddress("Brooklyn", "Arnold", 12), "USA", 400m);

            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);

            DeliveryUtilities.PrintSeperator();
            Console.WriteLine("Total Shipment created: " + Shipment.GetTotalShipmentCreated());

            //Object copying
            DeliveryUtilities.PrintSeperator();
            Console.WriteLine("Object Copying");
            DeliveryUtilities.PrintSeperator();

            Shipment shipment = standardShipment;
            Console.WriteLine("Orignal shipment: " + standardShipment.TrackingCode);
            Console.WriteLine("Copied shipmeent: " + shipment.TrackingCode);
            Console.WriteLine();
            Console.WriteLine("Same shipment: " + (shipment == standardShipment).ToString());

            //Shallow copy
            DeliveryUtilities.PrintSeperator();
            Console.WriteLine("Shallow Copy");
            DeliveryUtilities.PrintSeperator();

            shipment = standardShipment.ShallowCopy();

            Console.WriteLine("Original shipment address: " + standardShipment.Destination.City);
            Console.WriteLine("Copied shipment address: " + shipment.Destination.City);
            Console.WriteLine();
            Console.WriteLine("Changing address.......");
            standardShipment.Destination.City = "Nasr city";
            Console.WriteLine();
            Console.WriteLine("Original shipment address: " + standardShipment.Destination.City);
            Console.WriteLine("Copied shipment address: " + shipment.Destination.City);
            Console.WriteLine();
            Console.WriteLine("Same address :" + (standardShipment.Destination.City == shipment.Destination.City).ToString());

            //Deep copy
            DeliveryUtilities.PrintSeperator();
            Console.WriteLine("Deep copy");
            DeliveryUtilities.PrintSeperator();
            Console.WriteLine();

            shipment = standardShipment.DeepCopy();

            Console.WriteLine("Original shipment address: " + standardShipment.Destination.City);
            Console.WriteLine("Copied shipment address: " + shipment.Destination.City);
            Console.WriteLine();
            Console.WriteLine("Changing address......");
            standardShipment.Destination.City = "Mansoura";
            Console.WriteLine();
            Console.WriteLine("Original shipment address: " + standardShipment.Destination.City);
            Console.WriteLine("Copied shipment address: " + shipment.Destination.City);
            Console.WriteLine();
            Console.WriteLine("Same address :" + (standardShipment.Destination.City == shipment.Destination.City).ToString());

            //Extension Methods
            DeliveryUtilities.PrintSeperator();
            standardShipment.GetSummary();
            Console.WriteLine();
            expressShipment.GetSummary();
            Console.WriteLine();
            internationalShipment.GetSummary();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{standardShipment.TrackingCode} Is Delivered: {standardShipment.IsDelivered()}");
            Console.WriteLine($"{expressShipment.TrackingCode} Is Delivered: {expressShipment.IsDelivered()}");
            
            //Partial Method
            DeliveryUtilities.PrintSeperator();
            Console.WriteLine("Partial Method");
            DeliveryUtilities.PrintSeperator();
            standardShipment.UpdateTrackingStatus("Is Delivered");
            DeliveryUtilities.PrintSeperator();

            #endregion
        }
    }
}
