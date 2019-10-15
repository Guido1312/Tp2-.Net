using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        public Business.Entities.Especialidad EspecialidadActual { get; set; }

        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }


        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadLogic es = new EspecialidadLogic();
            this.EspecialidadActual = es.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual
.ID.ToString();
            this.txtDescripcion.Text= this.EspecialidadActual.Descripcion;

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
                    Business.Entities.Especialidad esp = new Business.Entities.Especialidad();
                    this.EspecialidadActual = esp;
                    this.EspecialidadActual.State = BusinessEntity.States.New;
                }
                else
                {
                    //int id = 0;
                    //if (!int.TryParse("asdasd", out id))
                    //{
                    //    MessageBox.Show("Debe ingrear un int");
                    //}
                    //Convert.ToInt32("1244");
                    this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                }

                this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
            }
            if (this.Modo == ModoForm.Consulta)
            {
                this.EspecialidadActual.State = BusinessEntity.States.Unmodified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                this.EspecialidadActual.State = BusinessEntity.States.Deleted;

            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic es = new EspecialidadLogic();
            es.Save(this.EspecialidadActual);
        }

        public override bool Validar()
        {

            if (string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
