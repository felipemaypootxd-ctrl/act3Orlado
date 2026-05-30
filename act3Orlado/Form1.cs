using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act3Orlado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        List<Cliente> listaClientes = new List<Cliente>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Cliente
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtCorreo.Text) ||
        string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si falta algo
            }

            
            Cliente nuevoCliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Telefono = txtCorreo.Text,
                Direccion = txtDomicilio.Text
            };
            listaClientes.Add(nuevoCliente);

           
            txtNombre.Clear();
            txtCorreo.Clear();
            txtDomicilio.Clear();

         
        //    MessageBox.Show("¡Cliente registrado con éxito en el sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar==' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled |= true;
            }
        }
    }
}
