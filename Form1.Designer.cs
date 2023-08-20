namespace SistemaGestion
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
            label1 = new Label();
            cajaNombre = new TextBox();
            cajaEdad = new TextBox();
            cajaSalario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cajaLenguaje = new TextBox();
            label6 = new Label();
            cajaAños = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 29);
            label1.Name = "label1";
            label1.Size = new Size(397, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestión de Empleados";
            // 
            // cajaNombre
            // 
            cajaNombre.Location = new Point(285, 113);
            cajaNombre.Name = "cajaNombre";
            cajaNombre.ReadOnly = true;
            cajaNombre.Size = new Size(271, 23);
            cajaNombre.TabIndex = 1;
            // 
            // cajaEdad
            // 
            cajaEdad.Location = new Point(285, 175);
            cajaEdad.Name = "cajaEdad";
            cajaEdad.ReadOnly = true;
            cajaEdad.Size = new Size(271, 23);
            cajaEdad.TabIndex = 2;
            // 
            // cajaSalario
            // 
            cajaSalario.Location = new Point(285, 231);
            cajaSalario.Name = "cajaSalario";
            cajaSalario.ReadOnly = true;
            cajaSalario.Size = new Size(271, 23);
            cajaSalario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 157);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 213);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Salario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 274);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 8;
            label5.Text = "Lenguaje de Programación";
            // 
            // cajaLenguaje
            // 
            cajaLenguaje.Location = new Point(285, 292);
            cajaLenguaje.Name = "cajaLenguaje";
            cajaLenguaje.ReadOnly = true;
            cajaLenguaje.Size = new Size(271, 23);
            cajaLenguaje.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 328);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 10;
            label6.Text = "Años de experiencia";
            // 
            // cajaAños
            // 
            cajaAños.Location = new Point(285, 346);
            cajaAños.Name = "cajaAños";
            cajaAños.ReadOnly = true;
            cajaAños.Size = new Size(271, 23);
            cajaAños.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(cajaAños);
            Controls.Add(label5);
            Controls.Add(cajaLenguaje);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cajaSalario);
            Controls.Add(cajaEdad);
            Controls.Add(cajaNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox cajaNombre;
        private TextBox cajaEdad;
        private TextBox cajaSalario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cajaLenguaje;
        private Label label6;
        private TextBox cajaAños;
    }
}