using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logicaNegocio;
using logicaNegocio.CrudUsuario;

namespace Presentacion
{
    public partial class FrmBuscarUsuario : Form
    {
        public FrmBuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmInicio form2 = new FrmInicio();
            form2.ShowDialog();
        }
        private void FrmBuscarUsuario_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells[0].Value.ToString());

            DeleteUsuario delete = new DeleteUsuario();

            delete.EliminarUsuario(id);
            refrescar();
        }
        public void refrescar()
        {
            ReadUsuario ReadUsuario = new ReadUsuario();

            dgvBuscar.DataSource = ReadUsuario.Readusuario();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse (dgvBuscar.CurrentRow.Cells[0].Value.ToString());
            string nombre = dgvBuscar.CurrentRow.Cells["Nombre"].Value.ToString();
            string correo = dgvBuscar.CurrentRow.Cells["Correo"].Value.ToString();
            string telefono = dgvBuscar.CurrentRow.Cells["Telefono"].Value.ToString();
            string direccion = dgvBuscar.CurrentRow.Cells["Direccion"].Value.ToString();

            FrmActualizar frmActualizar = new FrmActualizar(id,nombre,correo,telefono,direccion);

            frmActualizar.ShowDialog();

            refrescar();
        }
    }
}
