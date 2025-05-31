using logicaNegocio.CrudUsuario;
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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void BtnGuardarU_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            CreateUsuario crear = new CreateUsuario();


            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
            else
            {
                crear.CrearUsuario(nombre, correo, telefono, direccion);
                MessageBox.Show("Usuario creado corectamente.");

                this.Close();
                form.ShowDialog();
            }


        }
        FrmInicio form = new FrmInicio();
        private void BtnDescartarU_Click(object sender, EventArgs e)
        {
            this.Close();
            form.ShowDialog();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
