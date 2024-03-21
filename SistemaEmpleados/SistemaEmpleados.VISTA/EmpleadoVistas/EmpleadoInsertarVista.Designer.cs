namespace SistemaEmpleados.VISTA.EmpleadoVistas
{
    partial class EmpleadoInsertarVista
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPuesto = new TextBox();
            txtSalario = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 148);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "PUESTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 198);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "SALARIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 248);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 4;
            label5.Text = "FECHA DE CONTRATACION";
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(281, 145);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(288, 27);
            txtPuesto.TabIndex = 7;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(281, 195);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(288, 27);
            txtSalario.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(281, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Location = new Point(264, 343);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(465, 343);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 95);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 12;
            label1.Text = "IDEMPLEADO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 27);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(625, 86);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 14;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EmpleadoInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSalario);
            Controls.Add(txtPuesto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "EmpleadoInsertarVista";
            Text = "EmpleadoInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPuesto;
        private TextBox txtSalario;
        private DateTimePicker dateTimePicker1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}