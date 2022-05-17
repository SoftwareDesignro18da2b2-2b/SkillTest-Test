using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTest_Test
{
    class PatruljeFører : Person
    {
        public PatruljeFører(int id, string navn, string adresse, string patrulje, DateTime fødselsdato)
            : base(id, navn, adresse, patrulje, fødselsdato)
        {
        }

        public bool OK { get { return (Fødselsdato.Date.AddYears(18) <= DateTime.Now.Date); } }
    }
}
