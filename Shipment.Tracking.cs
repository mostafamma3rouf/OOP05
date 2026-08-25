using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    internal partial class Shipment
    {
        public string TrackingStatus { get; private set; } = "Pending";
        partial void OnTrackingStatusChanged(string newStatus);
        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        // Update Tracking Status
        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;

            OnTrackingStatusChanged(newStatus);
        }
    }
}
