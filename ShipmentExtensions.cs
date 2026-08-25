using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | Standard | " +
                   $"{shipment.Weight} KG | In Transit";
        }

        //public static bool IsDelivered(this Shipment shipment)
        //{
        //    return shipment.TrackingStatus == "Delivered";
        //}
    }
}
