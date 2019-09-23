using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ModuloLogic : BusinessLogic
    {
        Data.Database.ModuloAdapter _moduloData;

        public Data.Database.ModuloAdapter ModuloData
        {
            get { return _moduloData; }
            set { _moduloData = value; }
        }

        public List<Modulo> GetAll()
        {
            ModuloAdapter modulo = new ModuloAdapter();
            return modulo.GetAll();
        }

        public Modulo GetOne(int Id)
        {
            ModuloAdapter modulo = new ModuloAdapter();
            return modulo.GetOne(Id);
        }

        public void Delete(int Id)
        {
            ModuloAdapter modulo = new ModuloAdapter();
            modulo.Delete(Id);
        }

        public void Save(Modulo modulo)
        {
            ModuloAdapter mod = new ModuloAdapter();
            mod.Save(modulo);
        }



    }
}
