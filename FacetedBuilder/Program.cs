// See https://aka.ms/new-console-template for more information
using FacetedBuilder;


Person person = new PersonBuilder()
                    .Works
                       .At("PowerSchool")
                       .Position("Engineer")
                       .Earns(2500000)
                    .LivesAt
                        .Street("HSR Layout")
                        .InCity("Bengaluru")
                        .Postal("560102");

Console.WriteLine(person.ToString());
Console.ReadLine();
