using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPanelTask
{
    internal class Person
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FatherName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Gender { get; set; }

        public Person() { }

        public Person(string? name, string? surname, string? fathername, string? country, string? city, string? phone, DateTime birthday, string? gender)
        {
            Name = name;
            Surname = surname;
            FatherName = fathername;
            Country = country;
            City = city;
            Phone = phone;
            BirthDay = birthday;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nFather Name: {FatherName}\nCountry: {Country}\nCity: {City}\nPhone: {Phone}\nBirth Day: {BirthDay}\nGender: {Gender}";
        }
    }
}
