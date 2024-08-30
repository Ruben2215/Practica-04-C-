using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Practica_04
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = TbNombre.Text;  
            string apellidos = TbApellido.Text;
            string edad = TbEdad.Text; 
            String Estatura = TbEstatura.Text;
            string Telefono = tbTel.Text;

            String Genero = "";
            if (rbhombre.Checked)
            {
                Genero = "Hombre";
            }
            else if (rbmujer.Checked)
            {
                Genero = "Mujer";
            }
            String Datos = $"Nombre: {nombre}\r\nApellidos: {apellidos}\r\nEdad: {edad}\r\nTelefono: {Telefono}\r\nEstatura: {Estatura}\r\nGenero: {Genero}\r\n\r\n";


            string rutaArchivo = "C:\\Users\\Ruben Clemente\\Documents\\Practica 04\\Datos.txt";

            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) 
                if (archivoExiste)
                {
                    writer.WriteLine(Datos);

                }
            MessageBox.Show("Datos guardados\r\n\r\n" + Datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TbNombre.Clear();
            TbApellido.Clear();
            TbEdad.Clear();
            TbEstatura.Clear();
            tbTel.Clear();
            rbhombre.Enabled = false;
            rbmujer.Enabled = false;
        }
    }
}
