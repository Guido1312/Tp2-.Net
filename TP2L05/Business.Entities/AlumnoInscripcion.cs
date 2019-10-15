using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        string _condicion;
        int _idalumno, _idcurso, _nota;

        public string Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }

        public int IDAlumno
        {
            get { return _idalumno; }
            set { _idalumno = value; }
        }

        public int IDCurso
        {
            get { return _idcurso; }
            set { _idcurso = value; }
        }

        public int Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

    }
}
