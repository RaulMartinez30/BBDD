namespace BBDD.Presentacion
{
    partial class FormOficina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labbel_tabla = new Label();
            numBonusOficina = new NumericUpDown();
            lstOficina = new ListBox();
            CLEAN_botton = new Button();
            DELETE_botton = new Button();
            UPDATE_botton = new Button();
            ADD_botton = new Button();
            label3 = new Label();
            label2 = new Label();
            txtNameCiudad = new TextBox();
            label1 = new Label();
            txtIDOficina = new TextBox();
            cmbPaises = new ComboBox();
            Pais_labbel = new Label();
            label4 = new Label();
            txtDireccion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numBonusOficina).BeginInit();
            SuspendLayout();
            // 
            // labbel_tabla
            // 
            labbel_tabla.AccessibleName = "ID";
            labbel_tabla.AutoSize = true;
            labbel_tabla.BorderStyle = BorderStyle.FixedSingle;
            labbel_tabla.Location = new Point(39, 33);
            labbel_tabla.Name = "labbel_tabla";
            labbel_tabla.Size = new Size(49, 22);
            labbel_tabla.TabIndex = 24;
            labbel_tabla.Text = "Tabla:";
            // 
            // numBonusOficina
            // 
            numBonusOficina.DecimalPlaces = 2;
            numBonusOficina.Location = new Point(508, 239);
            numBonusOficina.Name = "numBonusOficina";
            numBonusOficina.Size = new Size(182, 27);
            numBonusOficina.TabIndex = 23;
            numBonusOficina.ValueChanged += numBonusOficina_ValueChanged;
            // 
            // lstOficina
            // 
            lstOficina.FormattingEnabled = true;
            lstOficina.ImeMode = ImeMode.Off;
            lstOficina.Location = new Point(39, 58);
            lstOficina.Name = "lstOficina";
            lstOficina.Size = new Size(319, 344);
            lstOficina.TabIndex = 22;
            lstOficina.SelectedIndexChanged += lstOficina_SelectedIndexChanged;
            // 
            // CLEAN_botton
            // 
            CLEAN_botton.BackColor = Color.LightGoldenrodYellow;
            CLEAN_botton.Cursor = Cursors.Hand;
            CLEAN_botton.FlatStyle = FlatStyle.Popup;
            CLEAN_botton.Location = new Point(596, 354);
            CLEAN_botton.Name = "CLEAN_botton";
            CLEAN_botton.Size = new Size(107, 29);
            CLEAN_botton.TabIndex = 21;
            CLEAN_botton.Text = "LIMPIAR";
            CLEAN_botton.UseVisualStyleBackColor = false;
            CLEAN_botton.Click += CLEAN_botton_Click;
            // 
            // DELETE_botton
            // 
            DELETE_botton.BackColor = Color.LightCoral;
            DELETE_botton.Cursor = Cursors.Hand;
            DELETE_botton.FlatStyle = FlatStyle.Popup;
            DELETE_botton.Location = new Point(448, 354);
            DELETE_botton.Name = "DELETE_botton";
            DELETE_botton.Size = new Size(94, 29);
            DELETE_botton.TabIndex = 20;
            DELETE_botton.Text = "ELIMINAR";
            DELETE_botton.UseVisualStyleBackColor = false;
            DELETE_botton.Click += DELETE_botton_Click;
            // 
            // UPDATE_botton
            // 
            UPDATE_botton.BackColor = Color.Turquoise;
            UPDATE_botton.Cursor = Cursors.Hand;
            UPDATE_botton.FlatStyle = FlatStyle.Popup;
            UPDATE_botton.Location = new Point(596, 295);
            UPDATE_botton.Name = "UPDATE_botton";
            UPDATE_botton.Size = new Size(107, 29);
            UPDATE_botton.TabIndex = 19;
            UPDATE_botton.Text = "ACTUALIZAR";
            UPDATE_botton.UseVisualStyleBackColor = false;
            UPDATE_botton.Click += UPDATE_botton_Click;
            // 
            // ADD_botton
            // 
            ADD_botton.BackColor = Color.MediumSeaGreen;
            ADD_botton.Cursor = Cursors.Hand;
            ADD_botton.FlatStyle = FlatStyle.Popup;
            ADD_botton.Location = new Point(448, 295);
            ADD_botton.Name = "ADD_botton";
            ADD_botton.Size = new Size(94, 29);
            ADD_botton.TabIndex = 18;
            ADD_botton.Text = "AÑADIR";
            ADD_botton.UseVisualStyleBackColor = false;
            ADD_botton.Click += ADD_botton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(432, 239);
            label3.Name = "label3";
            label3.Size = new Size(51, 22);
            label3.TabIndex = 17;
            label3.Text = "Bonus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(422, 145);
            label2.Name = "label2";
            label2.Size = new Size(61, 22);
            label2.TabIndex = 16;
            label2.Text = "Ciudad:";
            label2.Click += label2_Click;
            // 
            // txtNameCiudad
            // 
            txtNameCiudad.Location = new Point(508, 142);
            txtNameCiudad.Name = "txtNameCiudad";
            txtNameCiudad.Size = new Size(182, 27);
            txtNameCiudad.TabIndex = 15;
            txtNameCiudad.TextChanged += txtNameCiudad_TextChanged;
            // 
            // label1
            // 
            label1.AccessibleName = "ID";
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(454, 55);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 14;
            label1.Text = "ID:";
            // 
            // txtIDOficina
            // 
            txtIDOficina.Location = new Point(508, 55);
            txtIDOficina.Name = "txtIDOficina";
            txtIDOficina.Size = new Size(182, 27);
            txtIDOficina.TabIndex = 13;
            txtIDOficina.TextChanged += txtIDOficina_TextChanged;
            // 
            // cmbPaises
            // 
            cmbPaises.FormattingEnabled = true;
            cmbPaises.Location = new Point(508, 97);
            cmbPaises.Name = "cmbPaises";
            cmbPaises.Size = new Size(151, 28);
            cmbPaises.TabIndex = 27;
            cmbPaises.SelectedIndexChanged += cmbPaises_SelectedIndexChanged;
            cmbPaises.TextUpdate += cmbPaises_TextUpdate;
            // 
            // Pais_labbel
            // 
            Pais_labbel.AutoSize = true;
            Pais_labbel.BorderStyle = BorderStyle.FixedSingle;
            Pais_labbel.Location = new Point(447, 103);
            Pais_labbel.Name = "Pais_labbel";
            Pais_labbel.Size = new Size(36, 22);
            Pais_labbel.TabIndex = 26;
            Pais_labbel.Text = "Pais";
            Pais_labbel.Click += Pais_labbel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(406, 196);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 29;
            label4.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(508, 191);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(182, 27);
            txtDireccion.TabIndex = 28;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // FormOficina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(cmbPaises);
            Controls.Add(Pais_labbel);
            Controls.Add(labbel_tabla);
            Controls.Add(numBonusOficina);
            Controls.Add(lstOficina);
            Controls.Add(CLEAN_botton);
            Controls.Add(DELETE_botton);
            Controls.Add(UPDATE_botton);
            Controls.Add(ADD_botton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNameCiudad);
            Controls.Add(label1);
            Controls.Add(txtIDOficina);
            Name = "FormOficina";
            Text = "FormOficina";
            Load += FormOficina_Load;
            ((System.ComponentModel.ISupportInitialize)numBonusOficina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labbel_tabla;
        private NumericUpDown numBonusOficina;
        private ListBox lstOficina;
        private Button CLEAN_botton;
        private Button DELETE_botton;
        private Button UPDATE_botton;
        private Button ADD_botton;
        private Label label3;
        private Label label2;
        private TextBox txtNameCiudad;
        private Label label1;
        private TextBox txtIDOficina;
        private ComboBox cmbPaises;
        private Label Pais_labbel;
        private Label label4;
        private TextBox txtDireccion;
    }
}