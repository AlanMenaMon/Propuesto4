namespace login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btn_regitrar = new Button();
            listBox_empleados = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(147, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(233, 23);
            txtTelefono.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(147, 253);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(233, 23);
            txtCorreo.TabIndex = 2;
            // 
            // btn_regitrar
            // 
            btn_regitrar.Location = new Point(150, 325);
            btn_regitrar.Name = "btn_regitrar";
            btn_regitrar.Size = new Size(224, 59);
            btn_regitrar.TabIndex = 3;
            btn_regitrar.Text = "REGISTRAR";
            btn_regitrar.UseVisualStyleBackColor = true;
            btn_regitrar.Click += btn_regitrar_Click;
            // 
            // listBox_empleados
            // 
            listBox_empleados.FormattingEnabled = true;
            listBox_empleados.Location = new Point(147, 77);
            listBox_empleados.Name = "listBox_empleados";
            listBox_empleados.Size = new Size(237, 19);
            listBox_empleados.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 59);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 5;
            label1.Text = "LISTA DE EMPLEADO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 110);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 171);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "CELULAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 235);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "CORREO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox_empleados);
            Controls.Add(btn_regitrar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btn_regitrar;
        private ListBox listBox_empleados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
