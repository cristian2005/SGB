namespace SGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            if (!ProbarConexion())
            {
                MessageBox.Show("Error al conectar con la base de datos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
