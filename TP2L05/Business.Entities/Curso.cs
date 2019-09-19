using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        int _aniocalendario, _cupo, _idcomision, _idmateria;
        string _descripcion;

        public int AnioCalendario
        {
            get { return _aniocalendario; }
            set { _aniocalendario = value; }
        }

        public int Cupo
        {
            get { return _cupo; }
            set { _cupo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int IDComision
        {
            get { return _idcomision; }
            set { _idcomision = value; }
        }

        public int IDMateria
        {
            get { return _idmateria; }
            set { _idmateria = value; }
        }

    }
}
