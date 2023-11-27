using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            if (usuario == "Ramón Emir" && contraseña == "cbtis75")
            {
                MessageBox.Show("Has iniciado sesión como Ramón Emir");
                Form formulario = new Form3();
                formulario.Show();
            }
            else if (usuario == "Ramón Emir")
            {
                MessageBox.Show("Contraseña incorrecta. Por favor, inténtalo de nuevo.");
                textBoxContraseña.Clear();
            }
            else if (contraseña == "cbtis75")
            {
                MessageBox.Show("Usuario incorrecto. Por favor, inténtalo de nuevo.");
                textBoxUsuario.Clear();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos. Por favor, inténtalo de nuevo.");
                textBoxUsuario.Clear();
                textBoxContraseña.Clear();
            }
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.PasswordChar == '\0')
            {
                textBoxContraseña.PasswordChar = '*';
            }
            else
            {
                textBoxContraseña.PasswordChar = '\0';
            }
        }
    }
}
