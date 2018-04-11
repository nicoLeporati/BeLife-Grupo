using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ModelEntities;

namespace GraphicLayer
{
    public partial class FormRegistrarCliente : Form
    {
        public FormRegistrarCliente()
        {
            InitializeComponent();
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar cliente por rut ingresado con metodo de BusinessLayer
            string rut = txtRut.Text;
            Cliente cliente = new BcCliente().BuscarPorRut(rut);

            // Si es encontrado, se cargan los datos en los campos
            if (cliente is Cliente)
            {
                txtNombres.Text = cliente.Nombres.ToString();
                txtApellidos.Text = cliente.Apellidos.ToString();
                dtpNacimiento.Value = cliente.FechaNacimiento;
                cmbEstadoCivil.SelectedIndex = cliente.IdEstadoCivil - 1;
                if (cliente.IdSexo == 1) { rbMasculino.Select(); } else { rdFemenino.Select(); }

                // Cambiar botones
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else // si no se encuentra muestra un mensaje de error
            {
                MessageBox.Show("No se encontraron resultados");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear Cliente y poblar sus datos
            Cliente cliente = new Cliente();
            cliente.RutCliente = txtRut.Text;
            cliente.Nombres = txtNombres.Text;
            cliente.Apellidos = txtApellidos.Text;
            cliente.FechaNacimiento = dtpNacimiento.Value;
            cliente.IdSexo = (rbMasculino.Checked) ? cliente.IdSexo = 1 : cliente.IdSexo = 2;
            cliente.IdEstadoCivil = cmbEstadoCivil.SelectedIndex + 1;

            // Actualizar con metodo de BusinessLayer
            // si el metodo retorna verdadero muestra el mensaje de verificacion, de lo contrario
            // muestra uno de error
            if (new BcCliente().Actualizar(cliente))
            {
                MessageBox.Show("Cliente Actualizado");
            }
            else
            {
                MessageBox.Show("ERROR! Cliente NO se modifico");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear Cliente y poblar sus datos
            Cliente cliente = new Cliente();
            cliente.RutCliente = txtRut.Text;
            cliente.Nombres = txtNombres.Text;
            cliente.Apellidos = txtApellidos.Text;
            cliente.FechaNacimiento = dtpNacimiento.Value;
            cliente.IdSexo = (rbMasculino.Checked) ? cliente.IdSexo = 1 : cliente.IdSexo = 2;
            cliente.IdEstadoCivil = cmbEstadoCivil.SelectedIndex + 1;

            // Registrar con metodo de BusinessLayer
            // si el metodo retorna verdadero muestra el mensaje de verificacion, de lo contrario
            // muestra uno de error
            if (new BcCliente().Registrar(cliente))
            {
                MessageBox.Show("Cliente Registrado");
            }
            else
            {
                MessageBox.Show("ERROR! Cliente no se pudo registrar");
            }

            // Cambiar botones
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;

            // Si la eliminacion retorna verdadero, se reinician los campos y se muestra un
            // mensaje
            if (new BcCliente().EliminarPorRut(rut))
            {
                txtRut.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                dtpNacimiento.Value = DateTime.Now;
                cmbEstadoCivil.SelectedIndex = 0;
                rbMasculino.Select();

                // Se cambian los botones
                btnGuardar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;

                MessageBox.Show("Cliente eliminado");
            }
            else // Si retorna falso es un mensaje de error
            {
                MessageBox.Show("ERROR! El cliente no se pudo eliminar");
            }
        }
    }
}
