namespace pryBoletosFerrocarril
{
    public partial class Boleteria : Form
    {
        public Boleteria()
        {
            InitializeComponent();
        }

        int Total = 0;
        int Distancia = 0;
        int Dias = 0;

        private void mtbDistancia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbDistancia.Text != "")
            {
                cmdConfirmar.Enabled = true;
            }
            else
            {
                cmdConfirmar.Enabled = false;
            }

        }

        private void Calcular()
        {
            
            lstbTotal.Items.Add(Distancia);
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
