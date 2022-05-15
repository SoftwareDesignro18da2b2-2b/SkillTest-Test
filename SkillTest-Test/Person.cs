using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTest_Test
{
    class Person
    {
        public int Id { get; private set; }
        public string Navn { get; private set; }
        public string Adresse { get; private set; } 
        public string Patrulje { get; private set; }
        public DateTime Fødselsdato { get; private set; }

        public Person(int id, string navn , string adresse, string patrulje, DateTime fødselsdato)
        {
            Id = id;
            Navn = navn;
            Adresse = adresse;
            Patrulje = patrulje;
            Fødselsdato = fødselsdato;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Navn: {Navn}, Adresse: {Adresse}, Patrulje: {Patrulje}, Fødselsdato: {Fødselsdato}";
        }
    }
}
