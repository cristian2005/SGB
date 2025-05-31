using SGB;
using logicaNegocio;
using logicaNegocio.CrudUsuario;

namespace Presentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            //InitializeComponent();
            //if (!ProbarConexion())
            //{
            //    MessageBox.Show("Error al conectar con la base de datos. La aplicaci�n se cerrar�.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
            //{
            //    MessageBox.Show("Base de dato conectada");
            //}
        }
        //private static bool ProbarConexion()
        //{
        //    try
        //    {
        //        var db = new BibliotecaBDContext();
        //        return db.Database.CanConnect();
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevoU_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario register = new FrmRegistrarUsuario();
            register.Show();
            this.Hide();
        }

        private void BtnBuscarU_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario buscar = new FrmBuscarUsuario();
            buscar.Show();

            this.Hide();
            
        }
    }
}
