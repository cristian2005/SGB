using SGB;

namespace Presentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeComponent();
            if (!ProbarConexion())
            {
                MessageBox.Show("Error al conectar con la base de datos. La aplicaci�n se cerrar�.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Base de dato conectada");
            }
        }
        private static bool ProbarConexion()
        {
            try
            {
                var db = new BibliotecaBDContext();
                return db.Database.CanConnect();
            }
            catch
            {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
