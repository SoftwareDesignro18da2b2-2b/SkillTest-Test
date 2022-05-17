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

            Console.WriteLine();
            Console.WriteLine("Opgave 4: Udvid Tilmeldingskatalog klassen med nogle CRUD metoder");
            //Tilmeldingskatalog.UseList = true;
            Console.WriteLine("Creating catalog");
            Tilmeldingskatalog tKat1 = new Tilmeldingskatalog("Sommerlejr", true, new DateTime(2022,7,16), new DateTime(2022, 7, 30));

            Console.WriteLine();
            Console.WriteLine("Adding persons to catalog:");
            tKat1.AddPerson(p1);
            tKat1.AddPerson(p2);
            Console.WriteLine(tKat1);

            Console.WriteLine();
            Console.WriteLine("Deleting persons from catalog:");
            tKat1.DeletePerson(p1.Id);
            tKat1.DeletePerson(p2.Id);
            Console.WriteLine(tKat1);

            Console.WriteLine();
            Console.WriteLine("Opgave 6. Exceptions");
            try
            {
                Tilmeldingskatalog tKat2 = new Tilmeldingskatalog("Sommerlejr", false, new DateTime(2022, 7, 30), new DateTime(2022, 7, 23));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Caught exception: {e.Message}");
            }

            try
            {
                Tilmeldingskatalog tKat3 = new Tilmeldingskatalog("Sommerlejr", true, new DateTime(2022, 7, 6), new DateTime(2022, 7, 21));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Caught exception: {e.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Opgave 7 Implementation af arv");
            PatruljeFører tooYoung = new PatruljeFører(42, "Too Young", "Børneby", "Ulveungerne", new DateTime(2010, 2, 26));
            Console.WriteLine($"Name: {tooYoung.Navn} - OK: {tooYoung.OK}");
            PatruljeFører oldEnough = new PatruljeFører(42, "Old enough", "Voksenby", "Old boys", new DateTime(1970, 2, 26));
            Console.WriteLine($"Name: {oldEnough.Navn} - OK: {oldEnough.OK}");

            Console.WriteLine();
            Console.WriteLine("Opgave 10 Anvendelse af for løkke");
            tKat1.UseForLoop = true;
            Console.WriteLine(tKat1);

        }
    }
}
