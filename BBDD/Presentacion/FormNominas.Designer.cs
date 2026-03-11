namespace BBDD.Presentacion
{
    partial class FormNominas
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
            lstNominas = new ListBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // labbel_tabla
            // 
            labbel_tabla.AccessibleName = "ID";
            labbel_tabla.AutoSize = true;
            labbel_tabla.BorderStyle = BorderStyle.FixedSingle;
            labbel_tabla.Location = new Point(51, 37);
            labbel_tabla.Name = "labbel_tabla";
            labbel_tabla.Size = new Size(73, 22);
            labbel_tabla.TabIndex = 40;
            labbel_tabla.Text = "Nominas:";
            // 
            // lstNominas
            // 
            lstNominas.FormattingEnabled = true;
            lstNominas.Location = new Point(51, 62);
            lstNominas.Name = "lstNominas";
            lstNominas.Size = new Size(319, 344);
            lstNominas.TabIndex = 37;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(476, 235);
            button1.Name = "button1";
            button1.Size = new Size(199, 57);
            button1.TabIndex = 41;
            button1.Text = "Generar Nominas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(423, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // FormNominas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(labbel_tabla);
            Controls.Add(lstNominas);
            Name = "FormNominas";
            Text = "FormNominas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labbel_tabla;
        private ListBox lstNominas;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}