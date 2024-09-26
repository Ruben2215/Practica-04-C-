namespace Practica_04
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbEdad = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.rbhombre = new System.Windows.Forms.RadioButton();
            this.rbmujer = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbEstatura = new System.Windows.Forms.TextBox();
            this.BnGuardar = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(229, 28);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(190, 22);
            this.TbNombre.TabIndex = 5;
            this.TbNombre.TextChanged += new System.EventHandler(this.TbNombre_TextChanged);
            // 
            // TbEdad
            // 
            this.TbEdad.Location = new System.Drawing.Point(229, 184);
            this.TbEdad.Name = "TbEdad";
            this.TbEdad.Size = new System.Drawing.Size(190, 22);
            this.TbEdad.TabIndex = 7;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(229, 111);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(190, 22);
            this.tbTel.TabIndex = 8;
            this.tbTel.TextChanged += new System.EventHandler(this.tbTel_TextChanged);
            // 
            // TbApellido
            // 
            this.TbApellido.Location = new System.Drawing.Point(229, 64);
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(190, 22);
            this.TbApellido.TabIndex = 9;
            // 
            // rbhombre
            // 
            this.rbhombre.AutoSize = true;
            this.rbhombre.Location = new System.Drawing.Point(29, 254);
            this.rbhombre.Name = "rbhombre";
            this.rbhombre.Size = new System.Drawing.Size(77, 20);
            this.rbhombre.TabIndex = 10;
            this.rbhombre.TabStop = true;
            this.rbhombre.Text = "Hombre";
            this.rbhombre.UseVisualStyleBackColor = true;
            // 
            // rbmujer
            // 
            this.rbmujer.AutoSize = true;
            this.rbmujer.Location = new System.Drawing.Point(139, 254);
            this.rbmujer.Name = "rbmujer";
            this.rbmujer.Size = new System.Drawing.Size(61, 20);
            this.rbmujer.TabIndex = 11;
            this.rbmujer.TabStop = true;
            this.rbmujer.Text = "Mujer";
            this.rbmujer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Edad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TbEstatura
            // 
            this.TbEstatura.Location = new System.Drawing.Point(229, 145);
            this.TbEstatura.Name = "TbEstatura";
            this.TbEstatura.Size = new System.Drawing.Size(190, 22);
            this.TbEstatura.TabIndex = 14;
            // 
            // BnGuardar
            // 
            this.BnGuardar.Location = new System.Drawing.Point(161, 317);
            this.BnGuardar.Name = "BnGuardar";
            this.BnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BnGuardar.TabIndex = 15;
            this.BnGuardar.Text = "Guardar";
            this.BnGuardar.UseVisualStyleBackColor = true;
            this.BnGuardar.Click += new System.EventHandler(this.BnGuardar_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(303, 316);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BnGuardar);
            this.Controls.Add(this.TbEstatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbmujer);
            this.Controls.Add(this.rbhombre);
            this.Controls.Add(this.TbApellido);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.TbEdad);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbEdad;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.RadioButton rbhombre;
        private System.Windows.Forms.RadioButton rbmujer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbEstatura;
        private System.Windows.Forms.Button BnGuardar;
        private System.Windows.Forms.Button Clear;
    }
}

