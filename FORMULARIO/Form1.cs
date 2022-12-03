using clases;

namespace FORMULARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vendedor vendedor1 = new vendedor();
            vendedor1.Apellidos = txtApellidos.Text;
            vendedor1.Nombres = txtNombres.Text;
            vendedor1.Apellidos = txtApellidos.Text;
            vendedor1.Tipo = cboTipos.Text;
            vendedor1.TipoContrato = cboTipoContratos.Text;

            vendedor1.calcularSueldo(750);

            dgvVendedores.Rows.Insert(0,vendedor1.Tipo,vendedor1.Apellidos,vendedor1.Nombres,vendedor1.Documento,vendedor1.Sueldo)

        }
    }
}