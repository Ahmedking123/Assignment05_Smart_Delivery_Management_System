using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace C_Sharp__9_assignment
{
    internal static class ShipmentExtension
    {
        public static void GetSummary(this Shipment shipment)
        {
            Console.WriteLine($"Tracking Code: {shipment.TrackingCode}");
            Console.WriteLine($"Shipment type: {shipment.GetType().Name}");
            Console.WriteLine($"Shipment Status: {shipment.GetTrackingStatus()}");
            Console.WriteLine($"Shipment weight: {shipment.Weight}");
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus().ToLower().Contains("delivered");
        }
    }
}
