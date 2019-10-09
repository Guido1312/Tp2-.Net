using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

//esto es un control
namespace Business.Logic
{
    public class CursoLogic:BusinessLogic
    {
        Data.Database.CursoAdapter _cursoData;

        public Data.Database.CursoAdapter CursoData
        {
            get { return _cursoData; }
            set { _cursoData = value; }
        }

        public List<Curso> GetAll()
        {
            CursoAdapter curso = new CursoAdapter();
            return curso.GetAll();
        }

        public Especialidad GetOne(int Id)
        {
            CursoAdapter curso = new CursoAdapter();
            return curso.GetOne(Id);
        }

        public void Delete(int Id)
        {
            CursoAdapter curso = new CursoAdapter();
            curso.Delete(Id);
        }

        public void Save(Especialidad especialidad)
        {
            CursoAdapter cur = new CursoAdapter();
            cur.Save(curso);
        }
    }
}
