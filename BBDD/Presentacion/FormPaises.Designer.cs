namespace BBDD.Presentacion
{
    partial class FormPaises
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
            txtIDPais = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNamePais = new TextBox();
            label3 = new Label();
            ADD_botton = new Button();
            UPDATE_botton = new Button();
            DELETE_botton = new Button();
            CLEAN_botton = new Button();
            lstPaises = new ListBox();
            numImpuestosPais = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numImpuestosPais).BeginInit();
            SuspendLayout();
            // 
            // txtIDPais
            // 
            txtIDPais.Location = new Point(502, 47);
            txtIDPais.Name = "txtIDPais";
            txtIDPais.Size = new Size(182, 27);
            txtIDPais.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleName = "ID";
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(441, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(416, 107);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // txtNamePais
            // 
            txtNamePais.Location = new Point(502, 104);
            txtNamePais.Name = "txtNamePais";
            txtNamePais.Size = new Size(182, 27);
            txtNamePais.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(431, 165);
            label3.Name = "label3";
            label3.Size = new Size(39, 22);
            label3.TabIndex = 4;
            label3.Text = "Tax: ";
            label3.Click += label3_Click;
            // 
            // ADD_botton
            // 
            ADD_botton.Location = new Point(452, 264);
            ADD_botton.Name = "ADD_botton";
            ADD_botton.Size = new Size(94, 29);
            ADD_botton.TabIndex = 5;
            ADD_botton.Text = "ADD";
            ADD_botton.UseVisualStyleBackColor = true;
            ADD_botton.Click += ADD_botton_Click;
            // 
            // UPDATE_botton
            // 
            UPDATE_botton.Location = new Point(600, 264);
            UPDATE_botton.Name = "UPDATE_botton";
            UPDATE_botton.Size = new Size(94, 29);
            UPDATE_botton.TabIndex = 6;
            UPDATE_botton.Text = "UPDATE";
            UPDATE_botton.UseVisualStyleBackColor = true;
            UPDATE_botton.Click += UPDATE_botton_Click;
            // 
            // DELETE_botton
            // 
            DELETE_botton.Location = new Point(452, 323);
            DELETE_botton.Name = "DELETE_botton";
            DELETE_botton.Size = new Size(94, 29);
            DELETE_botton.TabIndex = 8;
            DELETE_botton.Text = "DELETE";
            DELETE_botton.UseVisualStyleBackColor = true;
            DELETE_botton.Click += DELETE_botton_Click;
            // 
            // CLEAN_botton
            // 
            CLEAN_botton.Location = new Point(600, 323);
            CLEAN_botton.Name = "CLEAN_botton";
            CLEAN_botton.Size = new Size(94, 29);
            CLEAN_botton.TabIndex = 9;
            CLEAN_botton.Text = "CLEAN";
            CLEAN_botton.UseVisualStyleBackColor = true;
            CLEAN_botton.Click += CLEAN_botton_Click;
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.Location = new Point(36, 12);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(319, 404);
            lstPaises.TabIndex = 10;
            lstPaises.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // numImpuestosPais
            // 
            numImpuestosPais.DecimalPlaces = 2;
            numImpuestosPais.Location = new Point(502, 165);
            numImpuestosPais.Name = "numImpuestosPais";
            numImpuestosPais.Size = new Size(182, 27);
            numImpuestosPais.TabIndex = 11;
            numImpuestosPais.ValueChanged += numNamePais_ValueChanged;
            // 
            // Paises
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 447);
            Controls.Add(numImpuestosPais);
            Controls.Add(lstPaises);
            Controls.Add(CLEAN_botton);
            Controls.Add(DELETE_botton);
            Controls.Add(UPDATE_botton);
            Controls.Add(ADD_botton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNamePais);
            Controls.Add(label1);
            Controls.Add(txtIDPais);
            Name = "Paises";
            Text = "GIT";
            Load += Paises_Load;
            ((System.ComponentModel.ISupportInitialize)numImpuestosPais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDPais;
        private Label label1;
        private Label label2;
        private TextBox txtNamePais;
        private Label label3;
        private Button ADD_botton;
        private Button UPDATE_botton;
        private Button DELETE_botton;
        private Button CLEAN_botton;
        private ListBox lstPaises;
        private NumericUpDown numImpuestosPais;
    }
}