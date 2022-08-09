namespace ControlDeMedidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> lstMuestra = new List<string>();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Calcular rersultados
            double metro = double.Parse(txtMetros.Text);

            double centimetro = metro * 100;
            double pulgada = centimetro / 2.54;
            double pie = pulgada / 12;
            double yarda = pie / 3;

            //Mostrar resultados
            lstMuestra.Items.Add(+centimetro);
            lstMuestra.Items.Add(+pulgada);
            lstMuestra.Items.Add(+yarda);
            lstMuestra.Items.Add(+pie);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstMuestra.Items.Clear();
            txtMetros.Clear();
            txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de salir?",
                "Control de Area y Volumen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}