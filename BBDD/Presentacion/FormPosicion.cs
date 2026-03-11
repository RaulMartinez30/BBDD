using BBDD.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BBDD.Presentacion
{
    public partial class FormPosicion : Form
    {
        public FormPosicion()
        {
            InitializeComponent();
        }

        private void FormPosicion_Load(object sender, EventArgs e)
        {
            cargarCombos();
            cargarPosiciones();
            txtIDPosicion.Enabled = false;
        }

        private void cargarCombos()
        {
            try
            {
                // Cargar Empleados - Usando ReadAllEmpleados() y propiedad Id
                Empleado emp = new Empleado();
                List<Empleado> listaEmp = emp.ReadAllEmpleados();
                cmbEmpleados.DataSource = listaEmp;
                cmbEmpleados.DisplayMember = "Name";
                cmbEmpleados.ValueMember = "Id";

                // Cargar Oficinas - Usando ReadAllOficinas() y propiedad Id
                Oficina ofi = new Oficina();
                List<Oficina> listaOfi = ofi.ReadAllOficinas();
                cmbOficinas.DataSource = listaOfi;
                cmbOficinas.DisplayMember = "NameCiudad";
                cmbOficinas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando combos: " + ex.Message);
            }
        }

        private void cargarPosiciones()
        {
            lstPosicion.Items.Clear();
            Posicion p = new Posicion();
            try
            {
                List<Posicion> lista = p.ReadAllPosiciones();
                foreach (Posicion pos in lista)
                {
                    lstPosicion.Items.Add(pos);
                }
                UPDATE_botton.Enabled = false;
                DELETE_botton.Enabled = false;
                ADD_botton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int getId()
        {
            int id = 0;
            bool found = false;
            Posicion pAux = new Posicion();
            while (!found)
            {
                id++;
                // Usamos id.ToString() porque tu dominio pide String en CheckIfIdExists
                if (!pAux.CheckIfIdExists(id.ToString()))
                {
                    found = true;
                }
            }
            return id;
        }

        private void ADD_botton_Click(object sender, EventArgs e)
        {
            if (txtNamePosicion.Text != string.Empty && cmbEmpleados.SelectedItem != null)
            {
                Posicion p = new Posicion(getId());
                p.empleado = (Empleado)cmbEmpleados.SelectedItem;
                p.oficina = (Oficina)cmbOficinas.SelectedItem;
                p.Name = txtNamePosicion.Text;
                p.YearSalary = numYearSalary.Value;
                p.StartDate = dtpStartDate.Value;

                // Si el checkbox está marcado, la fecha fin es null
                p.EndDate = chkActual.Checked ? (DateTime?)null : dtpEndDate.Value;

                try
                {
                    if (p.InsertPosicion() == 1)
                    {
                        cargarPosiciones();
                        CLEAN_botton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar la posición.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UPDATE_botton_Click(object sender, EventArgs e)
        {
            if (txtIDPosicion.Text != string.Empty)
            {
                Posicion p = new Posicion(int.Parse(txtIDPosicion.Text));
                p.empleado = (Empleado)cmbEmpleados.SelectedItem;
                p.oficina = (Oficina)cmbOficinas.SelectedItem;
                p.Name = txtNamePosicion.Text;
                p.YearSalary = numYearSalary.Value;
                p.StartDate = dtpStartDate.Value;
                p.EndDate = chkActual.Checked ? (DateTime?)null : dtpEndDate.Value;

                try
                {
                    if (p.UpdatePosicion() == 1)
                    {
                        cargarPosiciones();
                        CLEAN_botton.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DELETE_botton_Click(object sender, EventArgs e)
        {
            if (txtIDPosicion.Text != string.Empty)
            {
                Posicion p = (Posicion)lstPosicion.SelectedItem;
                if (MessageBox.Show("¿Seguro que desea borrar " + p.Name + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (p.DeletePosicion() == 1)
                        {
                            cargarPosiciones();
                            CLEAN_botton.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void lstPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPosicion.SelectedItem != null)
            {
                Posicion p = (Posicion)lstPosicion.SelectedItem;
                txtIDPosicion.Text = p.Id.ToString();
                txtNamePosicion.Text = p.Name;
                numYearSalary.Value = p.YearSalary;
                dtpStartDate.Value = p.StartDate;

                if (p.EndDate == null)
                {
                    chkActual.Checked = true;
                    dtpEndDate.Enabled = false;
                }
                else
                {
                    chkActual.Checked = false;
                    dtpEndDate.Enabled = true;
                    dtpEndDate.Value = (DateTime)p.EndDate;
                }

                // Sincronizar combos con los IDs de empleado y oficina
                cmbEmpleados.SelectedValue = p.empleado.Id;
                cmbOficinas.SelectedValue = p.oficina.Id;

                ADD_botton.Enabled = false;
                UPDATE_botton.Enabled = true;
                DELETE_botton.Enabled = true;
            }
        }

        private void CLEAN_botton_Click(object sender, EventArgs e)
        {
            txtIDPosicion.Text = string.Empty;
            txtNamePosicion.Text = string.Empty;
            numYearSalary.Value = 0;
            chkActual.Checked = true;
            dtpEndDate.Enabled = false;
            dtpStartDate.Value = DateTime.Now;

            ADD_botton.Enabled = true;
            UPDATE_botton.Enabled = false;
            DELETE_botton.Enabled = false;
            lstPosicion.ClearSelected();
        }

        private void chkActual_CheckedChanged(object sender, EventArgs e)
        {
            // Si es el puesto actual, deshabilitamos el selector de fecha de fin
            dtpEndDate.Enabled = !chkActual.Checked;
        }
    }
}