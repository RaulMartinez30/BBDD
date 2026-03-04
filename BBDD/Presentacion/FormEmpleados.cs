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
            Empleados aux = new Empleados();
            try
            {
                List<Empleados> employee = aux.ReadAllEmpleados();

                foreach (Empleados employment in employee)
                {
                    lstEmpleados.Items.Add(employee);

                }
                UPDATE_botton.Enabled = false;
                DELETE_botton.Enabled = false;

                txtIDEmpleado.Enabled = false;
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
                string id = getId(txtNameEmpleado.Text);
                Pais e = new Empleados(id);
                e.Name = txtNameEmpleado.Text;
                e.IBAN = txtIBANEmpleado.Text;
                e.Pais = (Pais) cmbPaises.SelectedItem;
                try
                {
                    if (e.InsertEmpleado() == 1)
                    {
                        lstEmpleados.Items.Add(e);
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

        private string getId(string name)
        {
            string idBase = name.Substring(0, 2).ToUpper();
            string id = idBase;
            bool found = false;
            for (int i = 2; i < name.Length && !found; i++)
            {
                id = idBase + name.Substring(i, 1).ToUpper();
                Empleados eAux = new Empleados();
                if (!eAux.CheckIfIdExists(id))
                {
                    found = true;

                }
            }
            return id;
        }

        private void UPDATE_botton_Click(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text != string.Empty && txtNameEmpleado.Text != string.Empty)
            {

                Empleados e = new Empleados(txtIDEmpleado.Text);
                e.Name = txtNameEmpleado.Text;
                e.IBAN = txtIDEmpleado.Text;
                try
                {
                    int val = e.UpdatePais();
                    if (val == 1)
                    {
                        int index = lstEmpleados.SelectedIndex;
                        lstEmpleados.Items.RemoveAt(index);
                        lstEmpleados.Items.Insert(index, e);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstEmpleados.SelectedItem != null)
            {
                Empleados employee = (Empleados)lstEmpleados.SelectedItem;
                txtIDEmpleado.Text = employee.Id;
                txtNameEmpleado.Text = employee.Name;
                txtIBANEmpleado.Text = employee.IBAN;
                cmbPaises.SelectedItem = employee.Pais;
                DELETE_botton.Enabled = true;
                UPDATE_botton.Enabled = true;
                ADD_botton.Enabled = false;

            }

        }
    }
}
