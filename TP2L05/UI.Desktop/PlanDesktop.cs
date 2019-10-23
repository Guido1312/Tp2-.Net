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
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
            EspecialidadLogic e = new EspecialidadLogic();

            List<Business.Entities.Especialidad> espes = e.GetAll();
            foreach (Business.Entities.Especialidad es in espes)
            {
                cbIdEspecialidad.Items.Add(es.ID);
            }
        }

        public Business.Entities.Plan PlanActual { get; set; }

        public PlanDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }


        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            PlanLogic plan = new PlanLogic();
            this.PlanActual = plan.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text= this.PlanActual.Descripcion;
            //this.txt_idEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();

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
                    Business.Entities.Plan plan = new Business.Entities.Plan();
                    this.PlanActual = plan;
                    this.PlanActual.State = BusinessEntity.States.New;                 
                }
                else
                {
                    //int id = 0;
                    //if (!int.TryParse("asdasd", out id))
                    //{
                    //    MessageBox.Show("Debe ingrear un int");
                    //}
                    //Convert.ToInt32("1244");
                    this.PlanActual.ID = int.Parse(this.txtID.Text);
                    this.PlanActual.State = BusinessEntity.States.Modified;
                }

                this.PlanActual.Descripcion = this.txtDescripcion.Text;
                this.PlanActual.IDEspecialidad = ((int)cbIdEspecialidad.SelectedItem);
            }
            if (this.Modo == ModoForm.Consulta)
            {
                this.PlanActual.State = BusinessEntity.States.Unmodified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                this.PlanActual.State = BusinessEntity.States.Deleted;

            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic plan = new PlanLogic();
            plan.Save(this.PlanActual);
        }

        public override bool Validar()
        {

            if (string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.cbIdEspecialidad.Text))
            {
                Notificar("ERROR!", "Debe seleccionar el ID de la especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
