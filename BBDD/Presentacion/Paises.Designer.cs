namespace BBDD.Presentacion
{
    partial class Paises
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
            getID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            ADD_botton = new Button();
            UPDATE_botton = new Button();
            DELETE_botton = new Button();
            CLEAN_botton = new Button();
            listBox1 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // getID
            // 
            getID.Location = new Point(502, 47);
            getID.Name = "getID";
            getID.Size = new Size(182, 27);
            getID.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.Location = new Point(502, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 2;
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
            DELETE_botton.Click += this.DELETE_botton_Click;
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(36, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 404);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(502, 165);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(182, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // Paises
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 447);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox1);
            Controls.Add(CLEAN_botton);
            Controls.Add(DELETE_botton);
            Controls.Add(UPDATE_botton);
            Controls.Add(ADD_botton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(getID);
            Name = "Paises";
            Text = "GIT";
            Load += Paises_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox getID;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button ADD_botton;
        private Button UPDATE_botton;
        private Button DELETE_botton;
        private Button CLEAN_botton;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
    }
}