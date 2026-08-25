using System.Runtime.InteropServices.Marshalling;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1 Object Copying
            #region a) What happens when you assign one object variable to another object variable?
            /*
             * It takes a copy of it, and the difference lies in the type of data 
             * because some will take the value and others will point to the reference.
             */
            #endregion

            #region b) Does assigning one object to another create a new object? Explain.
            // No. Assigning one object to another usually does not create a new object.
            // Instead, both variables refer to the same object.
            #endregion

            #region c) What is the difference between copying an object and copying its reference?
            /*
             * * copying   => take a copy of the value, and when you modify it, 
                              only the copy is modified, and the original remains as is.

             * * reference => You take a copy of the reference, and when making changes, 
                              the changes are made to both the copy and the original.
             */
            #endregion
            #endregion

            #region Q2 Shallow Copy vs Deep Copy
            #region a) What is a Shallow Copy?
            // create a new object and copies all value type fields, references type: only the references are copied
            #endregion

            #region b) What is a Deep Copy?
            // create a new object and recursively copies all nested objects
            #endregion

            #region c) What happens to reference-type members when a Shallow Copy is created?
            /*
             * When a shallow copy is created, their references are copied
             * so both the original and copied object refer to the same referenced objects
             */
            #endregion

            #region d) What happens to reference-type members when a Deep Copy is created?
            // When a deep copy is created, new copies of the referenced objects are also created.
            #endregion

            #region e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // when copying a object that contains a mutable address object
            #endregion
            #endregion

            #region Q3 Static Members
            #region a) What is a static field, and how is it different from an instance field?
            /*
             * a static field is a field that belongs to the class itself
             * an instance field belongs to a specific object of the class
             */
            #endregion

            #region b) What is a static method? Can a static method directly access instance members?
            /*
             * a static method is a method that belongs to the class itself.
             * No, cannot directly access instance fields or methods 
               because it does not belong to a particular object.
             */
            #endregion

            #region c) What is a static constructor, and when is it executed?
            /*
             * a static constructor is a special constructor used to initialize static fields 
               or other static data of a class.

             * is executed automatically once.
             */
            #endregion

            #region d) What is a static class? Can you create an object from a static class?
            /*
             * is a class that cannot be instantiated and is designed to contain only static members.
             * No, cannot create an object of a static class.
             */
            #endregion
            #endregion

            #region Q4 Extension Methods
            #region a) What is an Extension Method?
            // method that allows you to add new functionality to an existing type without modifying
            // its original source code or creating a derived class.
            #endregion

            #region b) What keyword must be used in the first parameter of an extension method?
            // this
            #endregion

            #region c) Where must an extension method be declared?
            //must be declared inside a static class.
            #endregion

            #region d) Can an extension method access private members of the class it extends?
            // No, access private members of the class it extends.
            #endregion
            #endregion

            #region Q5 Partial Classes and Partial Methods
            #region a) What is a Partial Class?
            // a partial class allows you to split the definition of one class across multiple files.
            #endregion

            #region b) Why would a developer split one class into multiple files?
            // to make the code easier to organize, read, and maintain.
            #endregion

            #region c) What is a Partial Method?
            // a partial method is a method that can be declared in one part of a partial class
            // and implemented in another part.
            #endregion

            #region d) What happens if a declared partial method has no implementation?
            // the compiler generally removes the method declaration and any calls to it from the compiled code.
            #endregion
            #endregion
            #endregion

            #region Part 02 — Practical
            #region 1 Object Copying
            // does not create a new Shipment object. It copies the reference,
            // so both variables point to the same object.
            //Shipment shipment1 = new Shipment("SH001", "Laptop", 2.5m, 2800, new DeliveryAddress("cairo","Dr",8));
            //Shipment shipment2 = shipment1;
            //Shipment shipment3 = shipment1.CopyShipment();
            #endregion

            #region 2 Shallow Copy
            /*
               • The original and copied Shipment objects must be different objects.
               • Their DeliveryAddress objects must still reference the same object.
               • Change the address through the copied shipment and demonstrate that the original shipment's address is also
                affected.
             */
            //Shipment shipment4 = shipment1.ShallowCopy();
            //shipment4.Destination.City = "Roma";

            #endregion

            #region 3 Deep Copy
            /*
               • The Deep Copy must create a new Shipment and a new DeliveryAddress.
               • Change the address of the copied shipment; the original address must remain unchanged.
             */
            //Shipment shipment5 = shipment1.DeepCopy();
            //shipment5.Destination.City = "Paris";
            #endregion

            #region 4 Static Field
            /*
               • It should keep track of the total number of Shipment objects created.
               • Every time a shipment is created, increment the counter.
               • The value must be shared between all shipment objects.
             */
            #endregion

            #region 5 Static Constructor
            /*
              • Initialize the shipment counter and display a message indicating 
                that static initialization has happened.
              • The static constructor must not be called manually.
                Shipment System Initialized
             */
            #endregion

            #region 6 Static Method
            /*
              • Return the total number of shipment objects created.
              • Call the method without creating a Shipment object just to access the method.
                Total Shipments Created : 3
             */
            //Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion

            #region 7 Static Class
            /*
              • Create a static class named DeliveryUtilities.
              • Add static methods: PrintSeparator() and PrintSystemTitle().
              • Use these methods throughout Main() instead of repeatedly writing the same separator/title code.
             */
            //DeliveryUtilities.PrintSeparator();
            //DeliveryUtilities.PrintSystemTitle();

            #endregion

            #region 8 Extension Methods
            /*
            • Create a static class named ShipmentExtensions.
            • Add string GetSummary(this Shipment shipment).
            • The summary must contain Tracking Code, Shipment Type, Weight, and Tracking Status.
            SH001 | Standard | 3 KG | In Transit
            • Add bool IsDelivered(this Shipment shipment).
            • Return true only when the tracking status is Delivered.
            shipment.GetSummary();
            shipment.IsDelivered();
             */
            //shipment.GetSummary();
            //shipment.IsDelivered();
            #endregion
            #endregion
        }
    }
}
