using BBDD.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BBDD.Presentacion
{
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombosSecundarios();

                cmbTipoInforme.Items.Add("1. Nóminas de un mes (por oficina)");
                cmbTipoInforme.Items.Add("2. Nóminas de un empleado");
                cmbTipoInforme.Items.Add("3. Empleados y trienios por sede");
                cmbTipoInforme.Items.Add("4. Gasto en nóminas de una oficina por mes");
                cmbTipoInforme.Items.Add("5. Gasto en nóminas por país y mes");

                cmbTipoInforme.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarCombosSecundarios()
        {
            Oficina ofi = new Oficina();
            List<Oficina> listaOficinas = ofi.ReadAllOficinas();
            cmbOficinas.DataSource = null;
            cmbOficinas.DataSource = listaOficinas;
            cmbOficinas.DisplayMember = "NameCiudad";
            cmbOficinas.ValueMember = "Id";

            Empleado emp = new Empleado();
            List<Empleado> listaEmpleados = emp.ReadAllEmpleados();
            cmbEmpleados.DataSource = null;
            cmbEmpleados.DataSource = listaEmpleados;
            cmbEmpleados.DisplayMember = "Name";
            cmbEmpleados.ValueMember = "Id";

            dtpFecha.Value = DateTime.Now.AddMonths(-1);
        }

        private void cmbTipoInforme_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOficinas.Visible = false;
            cmbOficinas.Visible = false;
            lblEmpleados.Visible = false;
            cmbEmpleados.Visible = false;
            lblFecha.Visible = false;
            dtpFecha.Visible = false;

            dgvResultados.DataSource = null;
            dgvResultados.Columns.Clear();

            switch (cmbTipoInforme.SelectedIndex)
            {
                case 0: // Nóminas de un mes — mes + oficina opcional
                    lblFecha.Visible = true;
                    dtpFecha.Visible = true;
                    lblOficinas.Visible = true;
                    cmbOficinas.Visible = true;
                    break;
                case 1: // Nóminas de un empleado
                    lblEmpleados.Visible = true;
                    cmbEmpleados.Visible = true;
                    break;
                case 2: // Trienios — sin filtros
                    break;
                case 3: // Gasto oficina por mes
                    lblFecha.Visible = true;
                    dtpFecha.Visible = true;
                    lblOficinas.Visible = true;
                    cmbOficinas.Visible = true;
                    break;
                case 4: // Gasto por país — sin filtros
                    break;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Informes inf = new Informes();
                DataTable resultado = null;

                switch (cmbTipoInforme.SelectedIndex)
                {
                    case 0:
                        int anio0 = dtpFecha.Value.Year;
                        int mes0 = dtpFecha.Value.Month;
                        int idOfi0 = (cmbOficinas.SelectedItem != null)
                            ? ((Oficina)cmbOficinas.SelectedItem).Id : -1;
                        resultado = inf.GetNominasPorMes(anio0, mes0, idOfi0);
                        break;

                    case 1:
                        if (cmbEmpleados.SelectedItem == null)
                        {
                            MessageBox.Show("Selecciona un empleado.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int idEmp = ((Empleado)cmbEmpleados.SelectedItem).Id;
                        resultado = inf.GetNominasPorEmpleado(idEmp);
                        break;

                    case 2:
                        resultado = inf.GetEmpleadosConTrienios();
                        break;

                    case 3:
                        if (cmbOficinas.SelectedItem == null)
                        {
                            MessageBox.Show("Selecciona una oficina.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int anio3 = dtpFecha.Value.Year;
                        int mes3 = dtpFecha.Value.Month;
                        int idOfi3 = ((Oficina)cmbOficinas.SelectedItem).Id;
                        resultado = inf.GetGastoOficinaMes(anio3, mes3, idOfi3);
                        break;

                    case 4:
                        resultado = inf.GetGastoPorPaisMes();
                        break;
                }

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    dgvResultados.DataSource = resultado;
                }
                else
                {
                    dgvResultados.DataSource = null;
                    dgvResultados.Columns.Clear();
                    MessageBox.Show("No hay datos para mostrar con los filtros seleccionados.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el informe: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbOficinas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpFecha_ValueChanged(object sender, EventArgs e) { }
        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}