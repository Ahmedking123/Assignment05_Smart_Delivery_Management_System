using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using C_Sharp__9_assignment.InterFaces;

namespace C_Sharp__9_assignment
{
    internal abstract partial class Shipment : ITrackable, IEnsurable
    {
        #region Fields

        private static int TotalShipmentCreated;
        private string? _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _DeliveryFee;

        #endregion
        #region Properties

        public string? TrackingCode
        {
            get
            {
                return _trackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value;
                }
            }
        }
        public decimal Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return _DeliveryFee;
            }
            set
            {
                if (value > 0)
                {
                    _DeliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination { get; set; }
        public abstract decimal EstimatedCost { get; }

        #endregion
        #region Constructors

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = delivaryFee;
            Destination = destination;
            TotalShipmentCreated++;
        }
        static Shipment()
        {
            TotalShipmentCreated = 0;
            Console.WriteLine("Shipment instances initialized.");
        }

        #endregion
        #region Methods
        public void UpdateDelivaryFee(decimal newDelivaryFee)
        {
            if (newDelivaryFee > 0)
            {
                DeliveryFee = newDelivaryFee;
            }
        }
        public abstract void PrintShipment();

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }
        public void UpdateWeight(decimal newWeight, decimal extraWeight)
        {
            if (newWeight > 0 && extraWeight > 0)
            {
                Weight = newWeight + extraWeight;
            }
        }

   

        public abstract decimal CalculateInsurance();
        
        public static int GetTotalShipmentCreated()
        {
            return TotalShipmentCreated;
        }

        public void Copy(Shipment otherShipment)
        {
            otherShipment = this;
        }
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment otherShipment = (Shipment)MemberwiseClone();
            otherShipment.Destination = new DeliveryAddress(this.Destination.City,this.Destination.Street,this.Destination.BuildingNumber)
            {

                Street = this.Destination.Street,
                City = this.Destination.City,
                BuildingNumber = this.Destination.BuildingNumber
            };
            return otherShipment;
        }
        #endregion
    }
}
