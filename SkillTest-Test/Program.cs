using System;

namespace SkillTest_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tilmeldingskatalog;");
            Console.WriteLine();
            Console.WriteLine("Opgave 1.Opret Klassen Person");
            Console.WriteLine();
            Person p1 = new Person(1, "Jens", "Adresse 1", "Patrulje 1", new DateTime(1961,4,13));
            Person p2 = new Person(2, "Vibeke", "Adresse 2", "Patrulje 2", new DateTime(1963, 5, 14));
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine("Opgave 4: Udvid Tilmeldingskatalog klassen med nogle CRUD metoder");
            Tilmeldingskatalog tKat = new Tilmeldingskatalog("Sommerlejr", true, new DateTime(2022,7,23), new DateTime(2022, 7, 30));
            tKat.AddPerson(p1);
            tKat.AddPerson(p2);
            Console.WriteLine(tKat);
        }
    }
}
