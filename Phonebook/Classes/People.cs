using System;

namespace Phonebook
{
    [Serializable]
    public class People
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Bornyear { get; set; }
        public string Gender { get; set; }
        public People() { }
        public People(string surname, string name, string patronymic, string bornyear, string gender)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Bornyear = bornyear;
            Gender = gender;
        }
    }
}
