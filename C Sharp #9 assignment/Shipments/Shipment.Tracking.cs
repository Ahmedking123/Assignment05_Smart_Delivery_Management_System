using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp__9_assignment
{
    internal abstract partial class Shipment
    {
        public abstract string GetTrackingStatus();
           
        public void UpdateTrackingStatus(string newStatus)
        {
            // Update the tracking status of the shipment
            OnTrackingStatusChanged(newStatus);
        }
        private partial void OnTrackingStatusChanged(string NewStatus);

        private partial void OnTrackingStatusChanged(string NewStatus)
        {
            Console.WriteLine($"Traking status chagned to: {NewStatus}");
        }
    }
}
