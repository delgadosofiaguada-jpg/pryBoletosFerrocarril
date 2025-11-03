namespace pryBoletosFerrocarril
{
    public partial class Boleteria : Form
    {
        public Boleteria()
        {
            InitializeComponent();
        }


        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            int Distancia = 0;
            int Dias = 0;
            Decimal Total = 0;
            Decimal PrecioKm = 5;

            //  Convertir el texto de los MaskedTextBox a int usando int.TryParse
            if (!int.TryParse(mtbDistancia.Text, out Distancia))
            {
                MessageBox.Show("Debe ingresar un valor numérico válido para los kilómetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbDistancia.Focus();
                return;
            }

            if (!int.TryParse(mtbDias.Text, out Dias))
            {
                MessageBox.Show("Debe ingresar un valor numérico válido para los días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbDias.Focus();
                return;
            }

            if (Dias < 1 || Dias > 30)
            {
                MessageBox.Show("La cantidad de dias debe estar entre 1 y 30", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbDias.Focus();
                return;
            }

            Total = (Distancia * 2 * PrecioKm);

            if (Distancia >= 100 && Dias >= 7)
            {
                Total = Total / 2;
            }

            MessageBox.Show("Distancia:" + Distancia + "Km\n" +
                "Dias de estancia: " + Dias + "\n" + "Precio por km: " + PrecioKm + "\n" +
               "Precio ida y vuelta: " + Total + "\n" + "Precio final: $ " + Total);

        }


        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            mtbDistancia.Clear();
            mtbDias.Clear();
            mtbDistancia.Focus();
        }

       

        
    }
}
