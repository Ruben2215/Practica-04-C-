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
using System.Text.RegularExpressions;


namespace Practica_04
{
    public partial class Form1 : Form
    {
        //comentario de prueba

        public Form1()
        {
            InitializeComponent();
            TbEdad.TextChanged += validarEdad;
            TbEstatura.TextChanged += validarEstatura;
            tbTel.TextChanged += validarTelefono;
            TbNombre.TextChanged += validarNombre;
            TbApellido.TextChanged += validarApellido;
            

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
            validarNombre(TbNombre, EventArgs.Empty);
            validarApellido(TbApellido, EventArgs.Empty);
            validarEdad(TbEdad, EventArgs.Empty);
            validarEstatura(TbEstatura, EventArgs.Empty);
            validarTelefono(tbTel, EventArgs.Empty);

            if (EsTextoValido(TbNombre.Text) &&
        EsTextoValido(TbApellido.Text) &&
        EsEntero(TbEdad.Text) &&
        EsEntero(TbEstatura.Text) &&
        tbTel.Text.Length == 10 &&
        EsEnteroValido10Digitos(tbTel.Text) &&
        (rbhombre.Checked || rbmujer.Checked))
            {
                string nombre = TbNombre.Text;
                string apellidos = TbApellido.Text;
                string edad = TbEdad.Text;
                string Estatura = TbEstatura.Text;
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
            else
            {
                MessageBox.Show("Completa todos los campos","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool EsEntero(string valor) {
            int resultado;
            return int.TryParse(valor, out resultado);

        }

        private bool EsDecimal(string valor) {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);

        }

        private bool EsEnteroValido10Digitos(string valor) {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsTextoValido(string valor) {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
            //El \n no funciona como se necesita, el \s valida tambien espacios


        }

        private void validarEdad(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;

           if (!EsEntero(textBox.Text))
            {
                MessageBox.Show("Ingresa una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();

            }
        }

        private void validarEstatura(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;

            if (!EsEntero(textBox.Text) )
            {
                MessageBox.Show("Ingresa una estatura valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();

            }

        }

       
        private void validarTelefono(object sender, EventArgs e) {

            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Length == 10 && EsEnteroValido10Digitos(textbox.Text))
            {
                textbox.BackColor = Color.Green;
            }
            else if (textbox.Text.Length > 10) //Si es mayor a 10 digitos lanzara error y color rojo
            {
                textbox.BackColor = Color.Red;
                MessageBox.Show("Ingrese un telefono de 10 digitos máximo", "Error telefono", MessageBoxButtons.OK);

            }
            else if (textbox.Text.Length < 10) //Si es menor a 10 digitos lanzara el color rojo
            {
                textbox.BackColor = Color.Red;
            }

        }

        private void validarNombre(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;

            if (!EsTextoValido(textBox.Text))
            {

                MessageBox.Show("Ingresa un Nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();

            }

        }
        private void validarApellido(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;

            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingresa un apellido valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();

            }


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

        private void tbTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
