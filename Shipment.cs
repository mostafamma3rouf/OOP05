using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    internal class Shipment
    {
        private string _trackingcode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryfee;
        public DeliveryAddress Destination;

        public decimal _estimatedcost;

        public string TrackingCode
        {
            get { return _trackingcode; }
            set
            {
                bool IsNullOrNot;
                do
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Invalid TrackingCode");
                        IsNullOrNot = false;
                    }
                    _trackingcode = value;
                    IsNullOrNot = true;

                } while (!IsNullOrNot);
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                bool IsNullOrNot;
                do
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Invalid Description");
                        IsNullOrNot = false;
                    }
                    _description = value;
                    IsNullOrNot = true;

                } while (!IsNullOrNot);
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                bool IsGreaterOrNot;
                do
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Invalid Weight");
                        IsGreaterOrNot = false;
                    }
                    _weight = value;
                    IsGreaterOrNot = true;

                } while (!IsGreaterOrNot);
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryfee; }
            private set
            {
                bool IsGreaterOrNot;
                do
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Invalid DeliveryFee");
                        IsGreaterOrNot = false;
                    }
                    _deliveryfee = value;
                    IsGreaterOrNot = true;

                } while (!IsGreaterOrNot);
            }
        }

        // Add a static constructor to Shipment.
        static Shipment()
        {
            Console.WriteLine("that static initialization has happened");
        }

        // Add a static field to Shipment: TotalShipmentsCreated.
        public static int TotalShipmentsCreated = 0;

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            TotalShipmentsCreated++;
        }

        // Create a method: Shipment CopyShipment().
        public Shipment CopyShipment() => new Shipment(TrackingCode, Description, Weight, DeliveryFee, Destination);

        // Create Shipment ShallowCopy().
        // Use MemberwiseClone() to create the copy.
        public Shipment ShallowCopy() => (Shipment)this.MemberwiseClone();

        // Create Shipment DeepCopy().
        public Shipment DeepCopy() => new Shipment(TrackingCode, Description, Weight, DeliveryFee, Destination.Copy());

        // Add: static int GetTotalShipmentsCreated().
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

    }
}
