using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversion
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }
    public class Person
    {
        public string Name;
    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> findAllChildrenOf(string name);
    }
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person,Relationship,Person)> values =
            new List<(Person,Relationship,Person)> ();
        public void AddParentandChild(Person parent, Person child)
        {
            values.Add((parent, Relationship.Parent, child));
            values.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> findAllChildrenOf(string name)
        {
            return values.Where(x => x.Item1.Name == name
            && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }

        //public List<(Person, Relationship, Person)> Relations => values;
    }

    public class Research
    {
        //Following Dependency Inversion Principle
        public Research(IRelationshipBrowser relationshipBrowser)
        {
            foreach (var item in relationshipBrowser.findAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {item.Name}");
            }
        }

        //Previously passing low level dependency to high level class.
        //public Research(Relationships relationships)
        //{
        //    var relations = relationships.Relations;
        //    foreach (var item in relationships.Relations.Where(x => x.Item1.Name =="John" && x.Item2 == Relationship.Parent))
        //    {
        //        Console.WriteLine($"John has a child called {item.Item3.Name}");
        //    }
        //}


        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "John" };
            Person p2 = new Person { Name = "Johnny" };
            Person p3 = new Person { Name = "Janardhan" };

            var relationships = new Relationships ();
            relationships.AddParentandChild(p1, p2);
            relationships.AddParentandChild(p1, p3);

            new Research(relationships);
            Console.ReadLine();
        }
    }
}
