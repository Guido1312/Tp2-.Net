using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        Data.Database.UsuarioAdapter _usuarioData;

        public Data.Database.UsuarioAdapter UsuarioData
        {
            get { return _usuarioData;  }
            set { _usuarioData = value; }        
        }

        public List<Usuario> GetAll()
        {
            UsuarioAdapter usuario = new UsuarioAdapter();
            return usuario.GetAll();
        }

        public Usuario GetOne(int Id)
        {
            UsuarioAdapter usuario = new UsuarioAdapter();
            return usuario.GetOne(Id);
        }

        public void Delete(int Id)
        {
            UsuarioAdapter usuario = new UsuarioAdapter();
            usuario.Delete(Id);
        }

        public void Save (Usuario usuario)
        {
            UsuarioAdapter usu = new UsuarioAdapter();
            usu.Save(usuario);
        }

    }
}
