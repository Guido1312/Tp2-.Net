using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class DocenteCurso : BusinessEntity
    {

        int _idcursos, _iddocente, _cargo;

        public int Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public int IDCursos
        {
            get { return _idcursos; }
            set { _idcursos = value; }
        }

        public int IDDocente
        {
            get { return _iddocente; }
            set { _iddocente = value; }
        }
    }
}
