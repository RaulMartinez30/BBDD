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
    public partial class Paises : Form
    {
        public Paises()
        {
            InitializeComponent();
        }

        private void Paises_Load(object sender, EventArgs e)
        {

        }

        private void ID_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CLEAN_botton_Click(object sender, EventArgs e)
        {

        }

        private void ADD_botton_Click(object sender, EventArgs e)
        {
            if (txtNameCountry.Text != string.Empty)
            {
                string id = getId(txtNameCountry.Text);
                Country c = new Country(id);
                c.name = txtNameCountry.Text;
                c.TaxBase = numTaxBaseCountry.Value;
                try
                {
                    if (c.InsertCountry() == 1)
                    {
                        lstCountry.Items.add(c);
                        btnClear.PerformClick();
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
                Country cAux = new Country();
                if (!cAux.CheckIfIdExists(id))
                {
                    found = true;

                }
            }
            return id;
        }
    }
}