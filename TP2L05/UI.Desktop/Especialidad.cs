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
    public partial class Especialidad : Form
    {
        public Especialidad()
        {
            InitializeComponent();
            dvgEspecialidades.AutoGenerateColumns = false;
            dvgEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgEspecialidades.MultiSelect = false;
        }



        public void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            this.dvgEspecialidades.DataSource = el.GetAll();
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dvgEspecialidades.SelectedRows.Count == 1)
            {
                int ID = ((Business.Entities.Especialidad)this.dvgEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
                formEspecialidad.ShowDialog();
                this.Listar();
            }


        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dvgEspecialidades.SelectedRows.Count == 1)
            {
                int ID = ((Business.Entities.Especialidad)this.dvgEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formEspecialidad.ShowDialog();
                this.Listar();
            }
        }
    }
}
