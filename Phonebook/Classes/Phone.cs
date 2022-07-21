using System;

namespace Phonebook
{
    [Serializable]
    public class Phone
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public Phone() { }
        public Phone(string number, string type)
        {
            Number = number;
            Type = type;
        }
    }
}
