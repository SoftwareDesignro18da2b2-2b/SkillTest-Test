using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTest_Test
{
    class Tilmeldingskatalog
    {
        Dictionary<int, Person> _persons;
        List<Person> _personsList;

        string _lejrID;
        bool _ugeRegel;
        DateTime _startdato;
        DateTime _slutdato;
        bool _useForLoop;
        bool _useList;

        public Tilmeldingskatalog(string lejrID, bool ugeRegel, DateTime startdato, DateTime slutdato)
        {
            if (UseList)
            {
                _personsList = new List<Person>(); 
            }
            else
            {
                _persons = new Dictionary<int, Person>();
            }
            _useForLoop = false;
            _useList = false;
            LejrID = lejrID;
            UgeRegel = ugeRegel;
            Slutdato = slutdato;
            Startdato = startdato;
        }

        void VerifyStartEndDate(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("Start date cannot be later than End");
            }
        }

        public string LejrID { get { return _lejrID; } private set { _lejrID = value; } }
        public bool UgeRegel { get { return _ugeRegel; } private set { _ugeRegel = value; } }
        public DateTime Startdato { get { return _startdato; }
            private set {
                VerifyStartEndDate(value, Slutdato);
                _startdato = value;
            }
        }
        public DateTime Slutdato { get { return _slutdato; }
            private set {
                VerifyStartEndDate(Startdato, value);
                _slutdato = value; }
        }

        public bool UseForLoop { get {return _useForLoop; } set { _useForLoop = value; } }
        public bool UseList { get { return _useList; } set { _useList = value; } }

        public override string ToString()
        {
            string result = "";

            result += $"LejrID: {LejrID}, UgeRegel: {UgeRegel}, Startdato: {Startdato}, Slutdato: {Slutdato}";
            result += "Deltagere\r\n";

            if (_useForLoop)
            {
                for (int idx = 1; idx < _persons.Keys.Count+1; idx++) 
                {
                    result += "\r\n";
                    result += _persons[idx];
                }
            }
            else
            {
                foreach (Person p in _persons.Values)
                {
                    result += "\r\n";
                    result += p;
                }
            }
            return result;
        }

        public void AddPerson(Person person)
        {
            if (UseList)
            {
                _personsList.Add(person);
            }
            else
            {
                _persons.Add(person.Id, person);
            }
        }

        public void DeletePerson(int id)
        {
            if (UseList)
            {
                Person pFound = null;
                foreach(Person p in _personsList)
                {
                    if (p.Id == id)
                    {
                        pFound = p;
                    }
                }

                if (pFound != null)
                {
                    _personsList.Remove(pFound);
                }
            }
            else
            {
                _persons.Remove(id);
            }
        }

    }
}
