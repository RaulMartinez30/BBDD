namespace BBDD.Presentacion
{
    partial class FormEmpleados
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
            numImpuestosPais = new NumericUpDown();
            lstEmpleados = new ListBox();
            CLEAN_botton = new Button();
            DELETE_botton = new Button();
            UPDATE_botton = new Button();
            ADD_botton = new Button();
            IBAN = new Label();
            label2 = new Label();
            txtNamePais = new TextBox();
            label1 = new Label();
            txtIDPais = new TextBox();
            Pais_labbel = new Label();
            cmbPaises = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numImpuestosPais).BeginInit();
            SuspendLayout();
            // 
            // numImpuestosPais
            // 
            numImpuestosPais.DecimalPlaces = 2;
            numImpuestosPais.Location = new Point(490, 163);
            numImpuestosPais.Name = "numImpuestosPais";
            numImpuestosPais.Size = new Size(182, 27);
            numImpuestosPais.TabIndex = 22;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(24, 34);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(319, 404);
            lstEmpleados.TabIndex = 21;
            // 
            // CLEAN_botton
            // 
            CLEAN_botton.Location = new Point(588, 345);
            CLEAN_botton.Name = "CLEAN_botton";
            CLEAN_botton.Size = new Size(94, 29);
            CLEAN_botton.TabIndex = 20;
            CLEAN_botton.Text = "CLEAN";
            CLEAN_botton.UseVisualStyleBackColor = true;
            // 
            // DELETE_botton
            // 
            DELETE_botton.Location = new Point(440, 345);
            DELETE_botton.Name = "DELETE_botton";
            DELETE_botton.Size = new Size(94, 29);
            DELETE_botton.TabIndex = 19;
            DELETE_botton.Text = "DELETE";
            DELETE_botton.UseVisualStyleBackColor = true;
            // 
            // UPDATE_botton
            // 
            UPDATE_botton.Location = new Point(588, 286);
            UPDATE_botton.Name = "UPDATE_botton";
            UPDATE_botton.Size = new Size(94, 29);
            UPDATE_botton.TabIndex = 18;
            UPDATE_botton.Text = "UPDATE";
            UPDATE_botton.UseVisualStyleBackColor = true;
            // 
            // ADD_botton
            // 
            ADD_botton.Location = new Point(440, 286);
            ADD_botton.Name = "ADD_botton";
            ADD_botton.Size = new Size(94, 29);
            ADD_botton.TabIndex = 17;
            ADD_botton.Text = "ADD";
            ADD_botton.UseVisualStyleBackColor = true;
            // 
            // IBAN
            // 
            IBAN.AutoSize = true;
            IBAN.BorderStyle = BorderStyle.FixedSingle;
            IBAN.Location = new Point(406, 163);
            IBAN.Name = "IBAN";
            IBAN.Size = new Size(52, 22);
            IBAN.TabIndex = 16;
            IBAN.Text = "IBAN: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(404, 105);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 15;
            label2.Text = "Name:";
            // 
            // txtNamePais
            // 
            txtNamePais.Location = new Point(490, 102);
            txtNamePais.Name = "txtNamePais";
            txtNamePais.Size = new Size(182, 27);
            txtNamePais.TabIndex = 14;
            // 
            // label1
            // 
            label1.AccessibleName = "ID";
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(429, 48);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 13;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // txtIDPais
            // 
            txtIDPais.Location = new Point(490, 45);
            txtIDPais.Name = "txtIDPais";
            txtIDPais.Size = new Size(182, 27);
            txtIDPais.TabIndex = 12;
            // 
            // Pais_labbel
            // 
            Pais_labbel.AutoSize = true;
            Pais_labbel.BorderStyle = BorderStyle.FixedSingle;
            Pais_labbel.Location = new Point(422, 219);
            Pais_labbel.Name = "Pais_labbel";
            Pais_labbel.Size = new Size(36, 22);
            Pais_labbel.TabIndex = 24;
            Pais_labbel.Text = "Pais";
            // 
            // cmbPaises
            // 
            cmbPaises.FormattingEnabled = true;
            cmbPaises.Location = new Point(490, 213);
            cmbPaises.Name = "cmbPaises";
            cmbPaises.Size = new Size(151, 28);
            cmbPaises.TabIndex = 25;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPaises);
            Controls.Add(Pais_labbel);
            Controls.Add(numImpuestosPais);
            Controls.Add(lstEmpleados);
            Controls.Add(CLEAN_botton);
            Controls.Add(DELETE_botton);
            Controls.Add(UPDATE_botton);
            Controls.Add(ADD_botton);
            Controls.Add(IBAN);
            Controls.Add(label2);
            Controls.Add(txtNamePais);
            Controls.Add(label1);
            Controls.Add(txtIDPais);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            Load += FormEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)numImpuestosPais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numImpuestosPais;
        private ListBox lstEmpleados;
        private Button CLEAN_botton;
        private Button DELETE_botton;
        private Button UPDATE_botton;
        private Button ADD_botton;
        private Label IBAN;
        private Label label2;
        private TextBox txtNamePais;
        private Label label1;
        private TextBox txtIDPais;
        private Label Pais_labbel;
        private ComboBox cmbPaises;
    }
}