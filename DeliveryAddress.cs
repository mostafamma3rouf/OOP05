using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    internal class DeliveryAddress
    {
        private string _city;
        private string _street;
        private int _buildingnumber;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int BuildingNumber
        {
            get { return _buildingnumber; }
            set { _buildingnumber = value; }
        }

        public DeliveryAddress(string city, string street, int buildingnumber)
        {
            _city = city;
            _street = street;
            _buildingnumber = buildingnumber;
        }

        public string GetFullAddress() => $"the complete address: {City} - {Street} - {BuildingNumber}";
    }
}
