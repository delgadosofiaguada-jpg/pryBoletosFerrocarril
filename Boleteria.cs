namespace pryBoletosFerrocarril
{
    public partial class Boleteria : Form
    {
        public Boleteria()
        {
            InitializeComponent();
        }
        private void mtbDistancia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbDistancia.Text == "")
            {
                cmdConfirmar.Enabled = false;
            }
            else
            {
                cmdConfirmar.Enabled = true;
            }

        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            int Distancia = 0;
            Decimal TotalPagar = 0;
            Decimal PrecioDistancia = 0;

            if (!int.TryParse(mtbDistancia.Text, out Distancia))
            {
                MessageBox.Show("Debe ingresar un valor numérico válido para los kilómetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbDistancia.Focus();
                return;
            }

            int Dias = (int)nudDias.Value;
            PrecioDistancia = (Distancia * 5);

            if (Distancia >= 100 && Dias >= 7)
            {
                TotalPagar = PrecioDistancia / 2;
            }
            lstbTotal.Items.Add("Distancia recorrida: " + Distancia);
            lstbTotal.Items.Add("Dias de estadía " + Dias);
            lstbTotal.Items.Add("Descuento:" + PrecioDistancia);
            lstbTotal.Items.Add("Total a pagar: " + TotalPagar);
        }
    }
}
