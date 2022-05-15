using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTest_Test
{
    class Tilmeldingskatalog
    {
        Dictionary<int,Person> _persons;

        string _lejrID;
        bool _ugeRegel;
        DateTime _startdato;
        DateTime _slutdato;

        public Tilmeldingskatalog(string lejrID, bool ugeRegel, DateTime startdato, DateTime slutdato)
        {
            _persons = new Dictionary<int, Person>();
            LejrID = lejrID;
            UgeRegel = ugeRegel;
            Startdato = startdato;
            Slutdato = slutdato;
        }

        public string LejrID { get { return _lejrID; } private set { _lejrID = value; } }
        public bool UgeRegel { get { return _ugeRegel; } private set { _ugeRegel = _ugeRegel; } }
        public DateTime Startdato { get { return _startdato; } private set { _startdato = value; } }
        public DateTime Slutdato { get { return _slutdato; } private set { _slutdato = value; } }

        public override string ToString()
        {
            string result = "";

            result += $"LejrID: {LejrID}, UgeRegel: {UgeRegel}, Startdato: {Startdato}, Slutdato: {Slutdato}";
            result += "Deltagere\r\n";

            foreach (Person p in _persons.Values)
            {
                
                result += "\r\n";
                result += p;
            }

            return result;
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person.Id, person);
        }

        public void DeletePerson(int id)
        {
            _persons.Remove(id);
        }

    }
}
