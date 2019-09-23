using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        Data.Database.PersonaAdapter _personaData;

        public Data.Database.PersonaAdapter PersonaData
        {
            get { return _personaData; }
            set { _personaData = value; }
        }

        public List<Persona> GetAll()
        {
            PersonaAdapter persona = new PersonaAdapter();
            return persona.GetAll();
        }

        public Persona GetOne(int Id)
        {
            PersonaAdapter persona = new PersonaAdapter();
            return persona.GetOne(Id);
        }

        public void Delete(int Id)
        {
            PersonaAdapter persona = new PersonaAdapter();
            persona.Delete(Id);
        }

        public void Save(Persona persona)
        {
            PersonaAdapter per = new PersonaAdapter();
            per.Save(persona);
        }

    }
}
