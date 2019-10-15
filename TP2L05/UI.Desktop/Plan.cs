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
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
            dvgPlanes.AutoGenerateColumns = false;
            dvgPlanes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgPlanes.MultiSelect = false;
        }



        public void Listar()
        {
            PlanLogic plan = new PlanLogic();
            this.dvgPlanes.DataSource = plan.GetAll();
        }

        private void Plan_Load(object sender, EventArgs e)
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
            PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dvgPlanes.SelectedRows.Count == 1)
            {
                int ID = ((Business.Entities.Plan)this.dvgPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
                formPlan.ShowDialog();
                this.Listar();
            }


        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dvgPlanes.SelectedRows.Count == 1)
            {
                int ID = ((Business.Entities.Plan)this.dvgPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formPlan.ShowDialog();
                this.Listar();
            }
        }
    }
}
