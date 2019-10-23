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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();

            PlanLogic p = new PlanLogic();

            List<Business.Entities.Plan> planes = p.GetAll();
            foreach (Business.Entities.Plan pl in planes)
            {
                cbIdPlan.Items.Add(pl.ID);
            }
        }

        public Business.Entities.Materia MateriaActual { get; set; }

        public MateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }


        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaLogic mate = new MateriaLogic();
            this.MateriaActual = mate.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text= this.MateriaActual.Descripcion;
            this.txtHsSemanales.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHsTotales.Text = this.MateriaActual.HSTotales.ToString();
            //this.cbIdPlan.Text = this.MateriaActual.IDPlan.ToString();

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
                    Business.Entities.Materia mate = new Business.Entities.Materia();
                    this.MateriaActual = mate;
                    this.MateriaActual.State = BusinessEntity.States.New;
                }
                else
                {
                    //int id = 0;
                    //if (!int.TryParse("asdasd", out id))
                    //{
                    //    MessageBox.Show("Debe ingrear un int");
                    //}
                    //Convert.ToInt32("1244");
                    this.MateriaActual.ID = int.Parse(this.txtID.Text);
                    this.MateriaActual.State = BusinessEntity.States.Modified;
                }

                this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                this.MateriaActual.HSSemanales = int.Parse(this.txtHsSemanales.Text);
                this.MateriaActual.HSTotales = int.Parse(this.txtHsTotales.Text);
                this.MateriaActual.IDPlan = ((int)cbIdPlan.SelectedItem);
            }
            if (this.Modo == ModoForm.Consulta)
            {
                this.MateriaActual.State = BusinessEntity.States.Unmodified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                this.MateriaActual.State = BusinessEntity.States.Deleted;

            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic mate = new MateriaLogic();
            mate.Save(this.MateriaActual);
        }

        public override bool Validar()
        {

            if (string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.txtHsSemanales.Text))
            {
                Notificar("ERROR!", "Debe ingresar la cantidad de horas semanales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.txtHsTotales.Text))
            {
                Notificar("ERROR!", "Debe ingresar la cantidad de horas totales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.cbIdPlan.Text))
            {
                Notificar("ERROR!", "Debe ingresar el ID del plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
