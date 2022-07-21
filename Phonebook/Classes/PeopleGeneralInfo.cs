using System;

namespace Phonebook
{
    [Serializable]
    public class PeopleGeneralInfo
    {
        public People PeopleClass { get; set; }
        public Address AddressClass { get; set; }
        public Phone PhoneClass { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public string Yearborn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PhoneType { get; set; }
        public string Email { get; set; }
        PeopleGeneralInfo() { }

        public PeopleGeneralInfo(People people, Address address, Phone phone, string email)
        {
            this.PeopleClass = people;
            this.AddressClass = address;
            this.PhoneClass = phone;
            this.Name = this.PeopleClass.Name;
            this.Surname = this.PeopleClass.Surname;
            this.Patronymic = this.PeopleClass.Patronymic;
            this.Gender = this.PeopleClass.Gender;
            this.Yearborn = this.PeopleClass.Bornyear;
            this.Address = this.AddressClass.Street + ' ' + this.AddressClass.House + ' ' + this.AddressClass.Apartment;
            this.Phone = this.PhoneClass.Number;
            this.PhoneType = this.PhoneClass.Type;
            this.Email = email;
        }
    }
}
