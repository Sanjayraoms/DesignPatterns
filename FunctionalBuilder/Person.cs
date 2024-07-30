using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalBuilder
{
    public class Person
    {
        public string Name, Position, Location;
    }

    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSelf : FunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        private readonly List<Func<Person,Person>> actions = new List<Func<Person,Person>>();

        private TSelf AddActions(Action<Person> action)
        {
            actions.Add(p => { action(p); return p; });
            return (TSelf)this;
        } 

        public TSelf Do(Action<Person> action) => AddActions(action);

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
    }
    public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name) => Do(p => p.Name = name);

    }

    public static class PersonBuilderExtenxions
    {
        public static PersonBuilder WorksAs(this PersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);
    }

    public static class PersonBuilderExt2
    {
        public static PersonBuilder WorksAt(this PersonBuilder builder, string Location)
            => builder.Do(p => p.Location = Location);
    }
}
