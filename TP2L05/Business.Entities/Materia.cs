using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia:BusinessEntity
    {
        string _descripcion;
        int _hssemanales, _hstotales, _idplan;


        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int HSSemanales
        {
            get { return _hssemanales; }
            set { _hssemanales = value; }
        }

        public int HSTotales
        {
            get { return _hstotales; }
            set { _hstotales = value; }
        }

        public int IDPlan
        {
            get { return _idplan; }
            set { _idplan = value; }
        }
    }
}
