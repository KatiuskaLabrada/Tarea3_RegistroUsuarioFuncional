using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {        
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fem_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Función que permite cerrar el programa
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Función que permite limpiar los campos del formulario
        private void clear_Click(object sender, EventArgs e)
        {
            name.Clear();
            lastName.Clear();
            id.Clear();
            years.Clear();
            country.SelectedIndex = 0;
            phoneNumber.Clear();
            address.Clear();
            mail.Clear();
            address.Clear();
            fem.Checked = false;
            man.Checked = false;
        }

        //Función que muestra los campos introducidos en el formulario
        private void save_Click_1(object sender, EventArgs e)
        {
            String valName = name.Text;
            String valLastName = lastName.Text;
   
            MessageBox.Show("Hola" + " " + valName + " " + valLastName + "," + " " + "tus datos fueron recibidos con exito.",
            "Información Importante");

        }
    }
}
