using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        int _idespecialidad;
        string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int IDEspecialidad
        {
            get { return _idespecialidad; }
            set { _idespecialidad = value; }
        }

    }
}
