using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        Data.Database.MateriaAdapter _materiaData;

        public Data.Database.MateriaAdapter MateriaData
        {
            get { return _materiaData; }
            set { _materiaData = value; }
        }

        public List<Materia> GetAll()
        {
            MateriaAdapter materia = new MateriaAdapter();
            return materia.GetAll();
        }

        public Materia GetOne(int Id)
        {
            MateriaAdapter materia = new MateriaAdapter();
            return materia.GetOne(Id);
        }

        public void Delete(int Id)
        {
            MateriaAdapter materia = new MateriaAdapter();
            materia.Delete(Id);
        }

        public void Save(Materia materia)
        {
            MateriaAdapter mat = new MateriaAdapter();
            mat.Save(materia);
        }
    }
}
