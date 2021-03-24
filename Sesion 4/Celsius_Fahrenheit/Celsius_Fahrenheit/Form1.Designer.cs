
namespace Celsius_Fahrenheit
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
            this.label1 = new System.Windows.Forms.Label();
            this.grados = new System.Windows.Forms.TextBox();
            this.Celsius = new System.Windows.Forms.RadioButton();
            this.Fahrenheit = new System.Windows.Forms.RadioButton();
            this.Cambiar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados";
            // 
            // grados
            // 
            this.grados.Location = new System.Drawing.Point(28, 48);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(100, 23);
            this.grados.TabIndex = 1;
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(28, 90);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(147, 19);
            this.Celsius.TabIndex = 2;
            this.Celsius.TabStop = true;
            this.Celsius.Text = "De Celsius a Fahrenheit";
            this.Celsius.UseVisualStyleBackColor = true;
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(28, 115);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(147, 19);
            this.Fahrenheit.TabIndex = 3;
            this.Fahrenheit.TabStop = true;
            this.Fahrenheit.Text = "De Fahrenheit a Celsius";
            this.Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // Cambiar
            // 
            this.Cambiar.Location = new System.Drawing.Point(28, 157);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(75, 23);
            this.Cambiar.TabIndex = 5;
            this.Cambiar.Text = "Cambiar";
            this.Cambiar.UseVisualStyleBackColor = true;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(282, 140);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(145, 40);
            this.Desconectar.TabIndex = 6;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(282, 48);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(145, 40);
            this.Conectar.TabIndex = 7;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 210);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Cambiar);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.grados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cambiar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grados;
        private System.Windows.Forms.RadioButton Celsius;
        private System.Windows.Forms.RadioButton Fahrenheit;
        private System.Windows.Forms.Button Cambiar;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Button Conectar;
    }
}

