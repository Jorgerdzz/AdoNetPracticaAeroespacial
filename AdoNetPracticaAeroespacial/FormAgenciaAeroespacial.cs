using AdoNetPracticaAeroespacial.Models;
using AdoNetPracticaAeroespacial.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetPracticaAeroespacial
{
    public partial class FormAgenciaAeroespacial : Form
    {
        RepositoryAgenciaAereoespacial repo;
        public FormAgenciaAeroespacial()
        {
            InitializeComponent();
            this.repo = new RepositoryAgenciaAereoespacial();
            this.LoadNaves();
        }

        private async void LoadNaves()
        {
            List<string> naves = await this.repo.GetNavesAsync();
            this.cmbNaves.Items.Clear();
            foreach (string nombre in naves)
            {
                this.cmbNaves.Items.Add(nombre);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            this.cmbNaves.Items.Clear();
            int naveId = int.Parse(this.txtNaveId.Text);
            string nombreNave = this.txtNombre.Text;
            string modelo = this.txtModelo.Text;
            int capacidadMax = int.Parse(this.txtCapacidad.Text);
            string estado = this.txtEstado.Text;
            int registros = await this.repo.InsertarNaveAsync(naveId, nombreNave, modelo, capacidadMax, estado); ;
            MessageBox.Show("Naves insertadas: " + registros);
            this.LoadNaves();
        }

        private async void cmbNaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreNave = this.cmbNaves.SelectedItem.ToString();
            Nave nave = await this.repo.GetDatosNaveAsync(nombreNave);
            this.txtNaveId.Text = nave.NaveId.ToString();
            this.txtNombre.Text = nave.NombreNave.ToString();
            this.txtModelo.Text = nave.Modelo.ToString();
            this.txtCapacidad.Text = nave.CapacidadMax.ToString();
            this.txtEstado.Text = nave.Estado.ToString();

            List<string> astronautas = await this.repo.GetAstronautasNaveAsync(nombreNave);
            this.lstAstronautas.Items.Clear();
            foreach (string apellido in astronautas)
            {
                this.lstAstronautas.Items.Add(apellido);
            }

            int presupuestoTotal = await this.repo.GetPresupuestoTotalNaveAsync(nombreNave);
            this.txtPresupuesto.Text = presupuestoTotal.ToString();

        }

        private async void lstAstronautas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apellido = this.lstAstronautas.SelectedItem.ToString();
            Astronauta astronauta = await this.repo.GetDatosAstronautaAsync(apellido);
            this.txtApellido.Text = astronauta.Apellido.ToString();
            this.txtRango.Text = astronauta.Rango.ToString();
            this.txtFechaIngreso.Text = astronauta.FechaIngreso.ToString();
            this.txtSalario.Text = astronauta.Salario.ToString();
            this.txtBono.Text = astronauta.Bono.ToString();
            this.txtId.Text = astronauta.NaveId.ToString();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string apellido = this.txtApellido.Text;
            string rango = this.txtRango.Text;
            int salario = int.Parse(this.txtSalario.Text);
            int registros = await this.repo.UpdateAstronautaAsync(apellido, rango, salario);
            MessageBox.Show("Astronauta modificado: " + registros);
        }

        private async void btnInsertarAstro_Click(object sender, EventArgs e)
        {
            string apellido = this.txtApellido.Text;
            string rango = this.txtRango.Text;
            string fechaIngreso = this.txtFechaIngreso.Text;
            int salario = int.Parse(this.txtSalario.Text);
            int bono = int.Parse(this.txtBono.Text);
            int naveId = int.Parse(this.txtId.Text);
            string mensaje = await this.repo.ValidarCapacidadMaxAsync(apellido, rango, fechaIngreso, salario, bono, naveId);
            if (mensaje == "I")
            {
                MessageBox.Show("Astronauta insertado");
            }
            else
            {
                MessageBox.Show("Se ha superado la capacidad maxima de la nave");
            }
        }
    }
}
