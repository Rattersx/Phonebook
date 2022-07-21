using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phonebook
{
    [Serializable]
    public class Address
    {
        public Address() { }
        public Address(string street, string house, string apartment)
        {
            Street = street;
            House = house;
            Apartment = apartment;
        }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }
}
