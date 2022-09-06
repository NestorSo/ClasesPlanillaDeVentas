namespace pjDivisionEntreCero
{
    public partial class frmDivisonEntreCero : Form
    {
        public frmDivisonEntreCero()
        {
            InitializeComponent();
        }

        private void frmDivisonEntreCero_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturando datos
                int numerador = int.Parse(txtNumerador.Text);
                int denominador = int.Parse(txtDenominador.Text);

                // Realizando los calculos 
                double resultado = numerador / denominador;
                //imprimiendo resultado 
                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe escribir dos numeros enteros",
                                "Formato de numeros invalido", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } 
            catch(DivideByZeroException divideByZeroExceptionParameter)
            {
                MessageBox.Show(divideByZeroExceptionParameter.Message,
                                "Intento dividir por cero", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}