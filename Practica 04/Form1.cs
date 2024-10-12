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
using MySql.Data.MySqlClient;



namespace Practica_04
{
    public partial class Form1 : Form
    {
        string SqlConection = "Server=localhost; Port=3306; Database=Registros_Avanzada; Uid = root; Pwd=;";
          
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
                int edad = int.Parse(TbEdad.Text);
                decimal estatura = decimal.Parse(TbEstatura.Text);
                string telefono = tbTel.Text;

                String Genero = "";
                if (rbhombre.Checked)
                {
                    Genero = "Hombre";
                }
                else if (rbmujer.Checked)
                {
                    Genero = "Mujer";
                }
                InsertarRegistro(nombre, apellidos, edad, estatura, telefono, Genero);


                String Datos = $"Nombre: {nombre}\r\nApellidos: {apellidos}\r\nEdad: {edad}\r\nTelefono: " +
                    $"{telefono}\r\nEstatura: {estatura}\r\nGenero: {Genero}\r\n\r\n";


                string rutaArchivo = "C:\\Users\\Ruben Clemente\\Documents\\Practica 04\\Datos.txt";

                bool archivoExiste = File.Exists(rutaArchivo);

                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    if (archivoExiste)
                    {
                        writer.WriteLine(Datos);

                    }
                MessageBox.Show("Datos guardados en MySQL\r\n\r\n" + Datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completa todos los campos","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool EsEntero(string valor) {
            float resultado;
            return float.TryParse(valor, out resultado);

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

        private void InsertarRegistro(string nombre, string apellido, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(SqlConection))
            {
                conection.Open();

                string insertQuery = "INSERT INTO registros(Nombre, Apellido, Telefono, Estatura, Edad, Genero)" +
                    "VALUES (@Nombre,@Apellido, @Telefono, @Estatura, @Edad, @Genero)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();

                }
                conection.Close();

            }
        }

        private void TbEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbhombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
