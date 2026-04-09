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

            cmbEmpleados.DropDown += cmbEmpleados_DropDown;
            cmbOficinas.DropDown += cmbOficinas_DropDown;
        }

        private void FormPosicion_Load(object sender, EventArgs e)
        {
            txtIDPosicion.Enabled = false;
            dtpEndDate.Enabled = false;

            cargarCombos();
            cargarPosiciones();
        }

        // 🔹 Recargar empleados al abrir combo
        private void cmbEmpleados_DropDown(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            cmbEmpleados.DataSource = emp.ReadAllEmpleados();
            cmbEmpleados.DisplayMember = "Name";
            cmbEmpleados.ValueMember = "Id";
        }

        // 🔹 Recargar oficinas al abrir combo
        private void cmbOficinas_DropDown(object sender, EventArgs e)
        {
            Oficina ofi = new Oficina();
            cmbOficinas.DataSource = ofi.ReadAllOficinas();
            cmbOficinas.DisplayMember = "NameCiudad";
            cmbOficinas.ValueMember = "Id";
        }

        private void cargarCombos()
        {
            Empleado emp = new Empleado();
            cmbEmpleados.DataSource = emp.ReadAllEmpleados();
            cmbEmpleados.DisplayMember = "Name";
            cmbEmpleados.ValueMember = "Id";

            Oficina ofi = new Oficina();
            cmbOficinas.DataSource = ofi.ReadAllOficinas();
            cmbOficinas.DisplayMember = "NameCiudad";
            cmbOficinas.ValueMember = "Id";
        }

        private void cargarPosiciones()
        {
            lstPosicion.Items.Clear();

            Posicion p = new Posicion();
            List<Posicion> lista = p.ReadAllPosiciones();

            foreach (Posicion pos in lista)
            {
                lstPosicion.Items.Add(pos);
            }

            ADD_botton.Enabled = true;
            UPDATE_botton.Enabled = false;
            DELETE_botton.Enabled = false;
        }

        private int getId()
        {
            int id = 1;
            Posicion p = new Posicion();

            while (p.CheckIfIdExists(id.ToString()))
                id++;

            return id;
        }

        private void ADD_botton_Click(object sender, EventArgs e)
        {
            if (txtNamePosicion.Text != "" && cmbEmpleados.SelectedItem != null)
            {
                Posicion p = new Posicion(getId());
                p.empleado = (Empleado)cmbEmpleados.SelectedItem;
                p.oficina = (Oficina)cmbOficinas.SelectedItem;
                p.Name = txtNamePosicion.Text;
                p.YearSalary = numYearSalary.Value;
                p.StartDate = dtpStartDate.Value;
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
                        MessageBox.Show("Error al insertar");
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UPDATE_botton_Click(object sender, EventArgs e)
        {
            if (txtIDPosicion.Text != "")
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
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DELETE_botton_Click(object sender, EventArgs e)
        {
            if (lstPosicion.SelectedItem != null)
            {
                Posicion p = (Posicion)lstPosicion.SelectedItem;

                if (MessageBox.Show("¿Borrar " + p.Name + "?", "Confirmar",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (p.DeletePosicion() == 1)
                        {
                            cargarPosiciones();
                            CLEAN_botton.PerformClick();
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dtpEndDate.Value = p.EndDate.Value;
                }

                cmbEmpleados.SelectedValue = p.empleado.Id;
                cmbOficinas.SelectedValue = p.oficina.Id;

                ADD_botton.Enabled = false;
                UPDATE_botton.Enabled = true;
                DELETE_botton.Enabled = true;
            }
        }

        private void CLEAN_botton_Click(object sender, EventArgs e)
        {
            txtIDPosicion.Text = "";
            txtNamePosicion.Text = "";
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
            dtpEndDate.Enabled = !chkActual.Checked;
        }
    }
}