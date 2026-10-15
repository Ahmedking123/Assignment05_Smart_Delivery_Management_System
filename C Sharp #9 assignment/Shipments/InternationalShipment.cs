using C_Sharp__9_assignment.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp__9_assignment.Shipments
{
    internal class InternationalShipment : Shipment, ITrackable, IEnsurable
    {
     
        #region Fields

        private string _destinationCountry;
        private decimal _customsFee;

        #endregion
        #region Properties

        public string DestinationCountry
        {
            get
            {
                return _destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value != "")
                {
                    _destinationCountry = value;
                }
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return _customsFee;
            }
            set
            {
                if (value >= 0)
                {
                    _customsFee = value;
                }
            }
        }
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;

        #endregion
        #region Constructors

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination, string destinationCountry, decimal CustomsFee) : base(trackingCode, description, weight, delivaryFee, destination)
        {
            DestinationCountry = destinationCountry;
            this.CustomsFee = CustomsFee;
        }

        #endregion
        #region Methods

        public override void PrintShipment()
        {
            Console.WriteLine("International shipment \n");
            Console.WriteLine($"""
                Tracking Code: {TrackingCode}
                Description: {Description} 
                Weight: {Weight}
                Delivery Fee: {DeliveryFee}
                Destination: {Destination.GetFullAddress()}
                Estimated Cost: {EstimatedCost} EGP
                """);
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee:C}");
        }
        public virtual void GenerateCustomsReports()
        {
            Console.WriteLine($"Customs report for Shipment: {TrackingCode}, CustomsFee: {CustomsFee:C}");
        }
        public override decimal CalculateInsurance()
        {
            return Weight * 0.12m;
        }

        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been delivered";
        }

        #endregion
    }
}
