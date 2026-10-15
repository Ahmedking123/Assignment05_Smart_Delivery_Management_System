using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp__9_assignment
{
    internal class DeliveryAddress
    {
        #region Fields

        public string City;
        public string Street;
        public int BuildingNumber;

        #endregion
        #region Constructors

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        #endregion
        #region Methods

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street} street {City} city";
        }

        #endregion
    }
}
