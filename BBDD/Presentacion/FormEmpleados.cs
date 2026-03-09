using BBDD.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBDD.Presentacion
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                Empleado aux = new Empleado();
                List<Empleado> employee = aux.ReadAllEmpleados();

                foreach (Empleado employment in employee)
                {
                    lstEmpleados.Items.Add(employment);
                }

                UPDATE_botton.Enabled = false;
                DELETE_botton.Enabled = false;
                txtIDEmpleado.Enabled = false;

                Pais p = new Pais();
                List<Pais> listaPaises = p.ReadAllPaises();

                cmbPaises.DataSource = listaPaises;

                cmbPaises.DisplayMember = "Name";

                cmbPaises.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CLEAN_botton_Click(object sender, EventArgs e)
        {
            txtIDEmpleado.Text = string.Empty;
            txtNameEmpleado.Text = string.Empty;
            txtIBANEmpleado.Text = string.Empty;
            ADD_botton.Enabled = true;
            DELETE_botton.Enabled = false;
            lstEmpleados.ClearSelected();
        }

        private void ADD_botton_Click(object sender, EventArgs e)
        {
            if (txtNameEmpleado.Text != string.Empty)
            {
                string id = getId();
                Empleado emp = new Empleado(int.Parse(id));
                emp.Name = txtNameEmpleado.Text;
                emp.IBAN = txtIBANEmpleado.Text;
                emp.pais = (Pais)cmbPaises.SelectedItem;
                try
                {
                    if (emp.InsertEmpleado() == 1)
                    {
                        lstEmpleados.Items.Add(emp);
                        CLEAN_botton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("INSERT return != 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string getId()
        {
            int contador = 1;
            bool found = false;
            string id = "";

            while (!found)
            {
                id = contador.ToString();
                Empleado eAux = new Empleado();

                if (!eAux.CheckIfIdExists(id))
                {
                    found = true;
                }
                else
                {
                    contador++;
                }
            }
            return id;
        }

        private void UPDATE_botton_Click(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text != string.Empty && txtNameEmpleado.Text != string.Empty)
            {

                Empleado emp = new Empleado(int.Parse(txtIDEmpleado.Text));
                emp.Name = txtNameEmpleado.Text;
                emp.IBAN = txtIBANEmpleado.Text;
                emp.pais = (Pais)cmbPaises.SelectedItem;
                try
                {
                    int val = emp.UpdateEmpleado();
                    if (val == 1)
                    {
                        int index = lstEmpleados.SelectedIndex;
                        lstEmpleados.Items.RemoveAt(index);
                        lstEmpleados.Items.Insert(index, emp);
                        CLEAN_botton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("DELETE return != 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstEmpleados.SelectedItem != null)
            {
                Empleado employee = (Empleado)lstEmpleados.SelectedItem;
                txtIDEmpleado.Text = employee.Id.ToString();
                txtNameEmpleado.Text = employee.Name;
                txtIBANEmpleado.Text = employee.IBAN;
                cmbPaises.SelectedItem = employee.pais;
                DELETE_botton.Enabled = true;
                UPDATE_botton.Enabled = true;
                ADD_botton.Enabled = false;

            }

        }

        private void DELETE_botton_Click(object sender, EventArgs e)
        {
            Empleado c = new Empleado(int.Parse(txtIDEmpleado.Text));

            if (MessageBox.Show("¿Realmente quieres borrar este elemento " + c.Id + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtIDEmpleado.Text != string.Empty)
                {

                    try
                    {
                        int val = c.DeleteEmpleado();
                        if (val == 1)
                        {
                            lstEmpleados.Items.RemoveAt(lstEmpleados.SelectedIndex);
                            CLEAN_botton.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("DELETE return != 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }


    }
}
