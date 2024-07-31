using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacetedBuilder
{
    public class Person
    {
        //Address
        public string StreeAddress, City, Postal;

        //Employment
        public string Company, Position;
        public int Income;

        public override string ToString()
        {
            return $"{nameof(StreeAddress)} : {StreeAddress} \n" +
                   $"{nameof(City)} : {City} \n" +
                   $"{nameof(Postal)} : {Postal} \n" +
                   $"{nameof(Company)} : {Company} \n" +
                   $"{nameof(Position)} : {Position} \n" +
                   $"{nameof(Income)} : {Income}";
        }
    }
    public class PersonBuilder
    {
        protected Person person = new Person();
        public PersonAddressBuilder LivesAt => new PersonAddressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }

    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string officeName)
        {
            person.Company = officeName;
            return this;
        }

        public PersonJobBuilder Position(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earns(int income)
        {
            person.Income = income;
            return this;
        }
    }
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder Street(string address)
        {
            person.StreeAddress = address;
            return this;
        }

        public PersonAddressBuilder InCity(string city)
        {
            person.City = city;
            return this;
        }

        public PersonAddressBuilder Postal(string postal)
        {
            person.Postal = postal;
            return this;
        }
    }
}
