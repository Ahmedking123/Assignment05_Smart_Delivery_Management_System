using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using C_Sharp__9_assignment.InterFaces;

namespace C_Sharp__9_assignment.Shipments
{
    internal sealed class CompletedShipment : Shipment , ITrackable, IEnsurable
    {
        
        #region Constructors

        public CompletedShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination) : base(trackingCode, description, weight, delivaryFee, destination)
        {
        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5);



        #endregion

        #region Methods
        public override decimal CalculateInsurance() => EstimatedCost * 0.5m;


        public override string GetTrackingStatus() => new string("Shipment " + TrackingCode + " has been delivered");

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment\n");
            Console.WriteLine($"""
                Tracking Code: {TrackingCode}
                Description: {Description} 
                Weight: {Weight}
                Delivery Fee: {DeliveryFee}
                Destination: {Destination.GetFullAddress()}
                Estimated Cost: {EstimatedCost} EGP
                """);
        }
        #endregion
    }
}

