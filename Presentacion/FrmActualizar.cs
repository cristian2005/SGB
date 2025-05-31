using logicaNegocio.CrudUsuario;
using SGB.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmActualizar : Form
    {
        public FrmActualizar()
        {
            InitializeComponent();
        }
        public FrmActualizar(int id, string nombre, string correo, string telefono, string direccion)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtNombre.Text = nombre;
            txtCorreo.Text = correo;
            txtTelefono.Text = telefono;
            txtDireccionAct.Text = direccion;
        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {

        }
        FrmBuscarUsuario form = new FrmBuscarUsuario();
        private void BtnDescartarU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarAct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccionAct.Text;

            UpdateUsuario actualizar = new UpdateUsuario();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
            else
            {
                actualizar.ActualizarUsuario(id, nombre, correo, telefono, direccion);
                MessageBox.Show("Usuario Guardado corectamente.");

                this.Close();
            }
        }
    }
}
