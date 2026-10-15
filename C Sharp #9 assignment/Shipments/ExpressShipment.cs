using C_Sharp__9_assignment.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp__9_assignment.Shipments
{
    internal class ExpressShipment : Shipment, ITrackable, IEnsurable
    {
        #region Fields

        private decimal _extraFee;

        #endregion
        #region Constructors

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, delivaryFee, destination)
        {
            ExtraFee = extraFee;
        }

        #endregion
        #region Properties

        public decimal ExtraFee
        {
            get
            {
                return _extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    _extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost => DeliveryFee + ExtraFee + (Weight * 5);

        #endregion

        #region Methods
        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for delivery";
        }
        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.8m;
        }
        public override void PrintShipment()
        {
            Console.WriteLine("ExpressShipment\n");
            Console.WriteLine($"""
                Tracking Code: {TrackingCode}
                Description: {Description} 
                Weight: {Weight}
                Delivery Fee: {DeliveryFee}
                Destination: {Destination.GetFullAddress()}
                Estimated Cost: {EstimatedCost} EGP
                """);
            Console.WriteLine($"Extra Fee: {_extraFee}");
        }
        #endregion
    }
}
