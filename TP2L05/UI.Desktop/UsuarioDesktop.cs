using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }


        public override void MapearDeDatos() {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

            if (this.Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar"; 
            }

            if (this.Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
          }


        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {

                if (this.Modo == ModoForm.Alta)
                {
                    Usuario usu = new Usuario();
                    this.UsuarioActual = usu;
                    this.UsuarioActual.State = BusinessEntity.States.New;
                }
                else
                {
                    //int id = 0;
                    //if (!int.TryParse("asdasd", out id))
                    //{
                    //    MessageBox.Show("Debe ingrear un int");
                    //}
                    //Convert.ToInt32("1244");
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                }

                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
            }
            if (this.Modo == ModoForm.Consulta)
            {
                this.UsuarioActual.State = BusinessEntity.States.Unmodified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                this.UsuarioActual.State = BusinessEntity.States.Deleted;
            }
        }


        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic us = new UsuarioLogic();
            us.Save(this.UsuarioActual);
        }

        public override bool Validar() {

           if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                Notificar("ERROR!","Debe ingresar Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.txtApellido.Text))
            {
                Notificar("ERROR!", "Debe ingresar Apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtEmail.Text))
            {
                Notificar("ERROR!", "Debe ingresar Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                Notificar("ERROR!", "Debe ingresar un Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                Notificar("ERROR!", "Debe ingresar una Clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtConfirmarClave.Text))
            {
                Notificar("ERROR!", "Debe ingresar la Clave nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtConfirmarClave.Text != this.txtClave.Text)
            {
                Notificar("ERROR!", "La clave no coincide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((this.txtClave.Text).Length < 8)
            {
                Notificar("ERROR!", "La clave debe contener 8 caraceres como minimo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (! Regex.IsMatch(this.txtEmail.Text, expresion))
            {
               Notificar("ERROR!", "El Email no es valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
            }
            return true;
        }


        public Usuario UsuarioActual { get; set; }

        public UsuarioDesktop (ModoForm modo) : this()
        {
            this.Modo = modo;
        }


        public UsuarioDesktop (int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic us = new UsuarioLogic();            
            this.UsuarioActual = us.GetOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                GuardarCambios();
                Close();
            }
        }

       
    }
}
