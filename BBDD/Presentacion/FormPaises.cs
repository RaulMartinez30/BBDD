using BBDD.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBDD.Presentacion
{
    public partial class FormPaises : Form
    {
        public FormPaises()
        {
            InitializeComponent();
        }

        private void Paises_Load(object sender, EventArgs e)
        {
            CargarPaises();
        }

        private void CargarPaises()
        {
            Pais aux = new Pais();
            try
            {
                List<Pais> countries = aux.ReadAllPaises();

                foreach (Pais country in countries)
                {
                    lstPaises.Items.Add(country);

                }
                UPDATE_botton.Enabled = false;
                DELETE_botton.Enabled = false;

                txtIDPais.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ID_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CLEAN_botton_Click(object sender, EventArgs e)
        {
            txtIDPais.Text = string.Empty;
            txtNamePais.Text = string.Empty;
            numImpuestosPais.Value = 0;
            ADD_botton.Enabled = true;
            DELETE_botton.Enabled = false;
            lstPaises.ClearSelected();
        }

        private void ADD_botton_Click(object sender, EventArgs e)
        {
            if (txtNamePais.Text != string.Empty)
            {
                string id = getId(txtNamePais.Text);
                Pais c = new Pais(id);
                c.Name = txtNamePais.Text;
                c.Impuestos = numImpuestosPais.Value;
                try
                {
                    if (c.InsertPais() == 1)
                    {
                        lstPaises.Items.Add(c);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string getId(string name)
        {
            string idBase = name.Substring(0, 2).ToUpper();
            string id = idBase;
            bool found = false;
            for (int i = 2; i < name.Length && !found; i++)
            {
                id = idBase + name.Substring(i, 1).ToUpper();
                Pais cAux = new Pais();
                if (!cAux.CheckIfIdExists(id))
                {
                    found = true;

                }
            }
            return id;
        }

        private void UPDATE_botton_Click(object sender, EventArgs e)
        {
            if (txtIDPais.Text != string.Empty && txtNamePais.Text != string.Empty)
            {

                Pais c = new Pais(txtIDPais.Text);
                c.Name = txtNamePais.Text;
                c.Impuestos = numImpuestosPais.Value;
                try
                {
                    int val = c.UpdatePais();
                    if (val == 1)
                    {
                        int index = lstPaises.SelectedIndex;
                        lstPaises.Items.RemoveAt(index);
                        lstPaises.Items.Insert(index, c);
                        CLEAN_botton.PerformClick();
                    }
                    else {
                        MessageBox.Show("DELETE return != 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstPaises.SelectedItem != null)
            {
                Pais country = (Pais)lstPaises.SelectedItem;
                txtIDPais.Text = country.Id;
                txtNamePais.Text = country.Name;
                numImpuestosPais.Value = country.Impuestos;
                DELETE_botton.Enabled = true;
                UPDATE_botton.Enabled = true;
                ADD_botton.Enabled = false;

            }

        }

        private void DELETE_botton_Click(object sender, EventArgs e)
        {
            Pais c = new Pais (txtIDPais.Text);
            if (txtIDPais.Text != string.Empty)
            {
                try
                {
                    int val = c.DeletePais();
                    if (val == 1)
                    {
                        lstPaises.Items.RemoveAt(lstPaises.SelectedIndex);
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

        private void numNamePais_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}