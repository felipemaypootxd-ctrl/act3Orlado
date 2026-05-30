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
            llenarClientes(dgvClientes);
        }
        public class Cliente
        {
            public string Nombre { get; set; }
            public string correo { get; set; }
            public string Direccion { get; set; }
            public string telefono { get; set; }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtCorreo.Text) ||
        string.IsNullOrWhiteSpace(txtDomicilio.Text) ||
        string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, llene los datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si falta algo
            }


            Cliente nuevoCliente = new Cliente
            {
                Nombre = txtNombre.Text,
                correo = txtCorreo.Text,
                Direccion = txtDomicilio.Text,
                telefono = txtTelefono.Text

            };
            listaClientes.Add(nuevoCliente);
            dgvClientes.Rows.Add(txtNombre.Text,txtCorreo.Text,txtDomicilio.Text,txtTelefono.Text);
            
           
            txtNombre.Clear();
            txtCorreo.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();

         
        }
        public void llenarClientes(DataGridView dt)
        {
            dgvClientes.Rows.Add(txtNombre.Text, txtCorreo.Text, txtDomicilio.Text, txtTelefono.Text);
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar==' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar==' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
