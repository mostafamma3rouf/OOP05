using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    internal partial class Shipment
    {
        public string TrackingStatus { get; private set; } = "Pending";

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
        }
    }
}
