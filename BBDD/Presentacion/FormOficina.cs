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
    public partial class FormOficina : Form
    {
        public FormOficina()
        {
            InitializeComponent();
        }




        private void txtNamePais_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pais_labbel_Click(object sender, EventArgs e)
        {
            
        }
        private void txtIDOficina_TextChanged(object sender, EventArgs e) // Id de la oficina
        {   

        }

        private int getId() {

            int id = 0;
            bool found = false;
            Oficina ofAux = new Oficina();

            
            while(!found)
            {

                id++;

                if (!ofAux.CheckIfIdExists(id))
                {

                    found = true;
                }

            }


            return id;
        }

        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e) // Desplegable paises
        {
           

        }

        public void cargarPaises ()
        {
            try
            {
                Pais p = new Pais();


                List<Pais> lista = p.ReadAllPaises();


                cmbPaises.DataSource = lista;


                cmbPaises.DisplayMember = "Name";
                cmbPaises.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando países: " + ex.Message);
            }
        }

        private void txtNameCiudad_TextChanged(object sender, EventArgs e) // Nombre ciudad
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e) // Direccion
        {

        }

        private void numBonusOficina_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ADD_botton_Click(object sender, EventArgs e)
        {

            if (txtNameCiudad.Text != string.Empty)
            {
                int id = getId();
                Oficina o = new Oficina(id);
                o.pais = (Pais) cmbPaises.SelectedItem;
                o.NameCiudad = txtNameCiudad.Text;
                o.Direccion = txtDireccion.Text;
                o.Bonus = (int)numBonusOficina.Value;
                try
                {
                    if (o.InsertOficina() == 1)
                    {
                        lstOficina.Items.Add(o);
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

    

        private void UPDATE_botton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtIDOficina.Text) && cmbPaises.SelectedItem != null)
            {
                Oficina o = new Oficina(int.Parse(txtIDOficina.Text));

                
                o.pais = (Pais)cmbPaises.SelectedItem;

                o.NameCiudad = txtNameCiudad.Text;
                o.Direccion = txtDireccion.Text;
                o.Bonus = numBonusOficina.Value;

                try
                {
                    if (o.UpdateOficina() == 1) 
                    {
                      
                        int index = lstOficina.SelectedIndex;
                        lstOficina.Items.RemoveAt(index);
                        lstOficina.Items.Insert(index, o);
                        CLEAN_botton.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void FormOficina_Load(object sender, EventArgs e)
        {
            cargarOficinas();
            cargarPaises();

        }
        private void cargarOficinas()
        {
            Oficina aux = new Oficina();
            try
            {
                List<Oficina> oficinas = aux.ReadAllOficinas();

                foreach (Oficina oficina in oficinas)
                {
                    lstOficina.Items.Add(oficina);

                }
                UPDATE_botton.Enabled = false;
                DELETE_botton.Enabled = false;

                txtIDOficina.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void DELETE_botton_Click(object sender, EventArgs e)
        {

            Oficina o = new Oficina(int.Parse(txtIDOficina.Text));
            if (MessageBox.Show("¿Realmente quieres borrar este elemento " + o.Id + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                if (txtIDOficina.Text != string.Empty)
                {
                    try
                    {
                        int val = o.DeleteOficina();
                        if (val == 1)
                        {
                            lstOficina.Items.RemoveAt(lstOficina.SelectedIndex);
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

        private void CLEAN_botton_Click(object sender, EventArgs e)
        {

            txtIDOficina.Text = string.Empty;
            cmbPaises.Text = string.Empty;
            txtNameCiudad.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            numBonusOficina.Value = 0;
            ADD_botton.Enabled = true;
            DELETE_botton.Enabled = false;
            lstOficina.ClearSelected();

        }

        private void lstOficina_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstOficina.SelectedItem != null)
            {
                Oficina oficina = (Oficina)lstOficina.SelectedItem;
                txtIDOficina.Text = oficina.Id.ToString();
                cmbPaises.Text = oficina.pais.Id;
                txtNameCiudad.Text = oficina.NameCiudad;
                txtDireccion.Text = oficina.Direccion;
                numBonusOficina.Value = oficina.Bonus;
                DELETE_botton.Enabled = true;
                UPDATE_botton.Enabled = true;
                ADD_botton.Enabled = false;

            }
        }
    }
}
