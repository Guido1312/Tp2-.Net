using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        Data.Database.EspecialidadAdapter _especialidadData;

        public Data.Database.EspecialidadAdapter EspecialidadData
        {
            get { return _especialidadData; }
            set { _especialidadData = value; }
        }

        public List<Especialidad> GetAll()
        {
            EspecialidadAdapter especialidad = new EspecialidadAdapter();
            return especialidad.GetAll();
        }

        public Especialidad GetOne(int Id)
        {
            EspecialidadAdapter especialidad = new EspecialidadAdapter();
            return especialidad.GetOne(Id);
        }

        public void Delete(int Id)
        {
            EspecialidadAdapter especialidad = new EspecialidadAdapter();
            especialidad.Delete(Id);
        }

        public void Save(Especialidad especialidad)
        {
            EspecialidadAdapter esp = new EspecialidadAdapter();
            esp.Save(especialidad);
        }
    }
}
