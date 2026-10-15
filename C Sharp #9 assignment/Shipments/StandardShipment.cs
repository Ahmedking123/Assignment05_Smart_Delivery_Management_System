using C_Sharp__9_assignment.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp__9_assignment.Shipments
{
    internal class StandardShipment : Shipment, ITrackable, IEnsurable
    {
        #region Constructors

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public StandardShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination) : base(trackingCode, description, weight, delivaryFee, destination)
        {

        }
        #endregion
        #region Methods

        public override void PrintShipment()
        {
            Console.WriteLine("Standerd shipment\n");
            Console.WriteLine($"""
                Tracking Code: {TrackingCode}
                Description: {Description} 
                Weight: {Weight}
                Delivery Fee: {DeliveryFee}
                Destination: {Destination.GetFullAddress()}
                Estimated Cost: {EstimatedCost} EGP
                """);

        }

        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.5m;
        }

        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is ready";
        }
        #endregion
    }
}
