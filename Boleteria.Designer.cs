namespace pryBoletosFerrocarril
{
    partial class Boleteria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbConsultaPrecio = new GroupBox();
            nudDias = new NumericUpDown();
            cmdConfirmar = new Button();
            lblDias = new Label();
            mtbDistancia = new MaskedTextBox();
            lblDistancia = new Label();
            lstbTotal = new ListBox();
            lblTotal = new Label();
            gbConsultaPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // gbConsultaPrecio
            // 
            gbConsultaPrecio.Controls.Add(nudDias);
            gbConsultaPrecio.Controls.Add(cmdConfirmar);
            gbConsultaPrecio.Controls.Add(lblDias);
            gbConsultaPrecio.Controls.Add(mtbDistancia);
            gbConsultaPrecio.Controls.Add(lblDistancia);
            gbConsultaPrecio.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbConsultaPrecio.Location = new Point(14, 16);
            gbConsultaPrecio.Margin = new Padding(3, 4, 3, 4);
            gbConsultaPrecio.Name = "gbConsultaPrecio";
            gbConsultaPrecio.Padding = new Padding(3, 4, 3, 4);
            gbConsultaPrecio.Size = new Size(352, 229);
            gbConsultaPrecio.TabIndex = 0;
            gbConsultaPrecio.TabStop = false;
            gbConsultaPrecio.Text = "Consultar precio del Boleto";
            // 
            // nudDias
            // 
            nudDias.Location = new Point(186, 120);
            nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(75, 29);
            nudDias.TabIndex = 5;
            nudDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmdConfirmar
            // 
            cmdConfirmar.Enabled = false;
            cmdConfirmar.Location = new Point(17, 190);
            cmdConfirmar.Margin = new Padding(3, 4, 3, 4);
            cmdConfirmar.Name = "cmdConfirmar";
            cmdConfirmar.Size = new Size(126, 31);
            cmdConfirmar.TabIndex = 4;
            cmdConfirmar.Text = "Confirmar";
            cmdConfirmar.UseVisualStyleBackColor = true;
            cmdConfirmar.Click += cmdConfirmar_Click;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(17, 128);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(143, 22);
            lblDias.TabIndex = 2;
            lblDias.Text = "Dias de estadía";
            // 
            // mtbDistancia
            // 
            mtbDistancia.Location = new Point(161, 52);
            mtbDistancia.Margin = new Padding(3, 4, 3, 4);
            mtbDistancia.Mask = "0000km";
            mtbDistancia.Name = "mtbDistancia";
            mtbDistancia.Size = new Size(82, 29);
            mtbDistancia.TabIndex = 1;
            mtbDistancia.ValidatingType = typeof(int);
            mtbDistancia.MaskInputRejected += mtbDistancia_MaskInputRejected;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(17, 63);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(87, 22);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // lstbTotal
            // 
            lstbTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbTotal.FormattingEnabled = true;
            lstbTotal.ItemHeight = 21;
            lstbTotal.Location = new Point(14, 308);
            lstbTotal.Margin = new Padding(3, 4, 3, 4);
            lstbTotal.Name = "lstbTotal";
            lstbTotal.Size = new Size(310, 109);
            lstbTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(14, 264);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 23);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            // 
            // Boleteria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 443);
            Controls.Add(lblTotal);
            Controls.Add(lstbTotal);
            Controls.Add(gbConsultaPrecio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Boleteria";
            Text = "Boletería Ferrocarril";
            gbConsultaPrecio.ResumeLayout(false);
            gbConsultaPrecio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbConsultaPrecio;
        private MaskedTextBox mtbDistancia;
        private Label lblDistancia;
        private Label lblDias;
        private ListBox lstbTotal;
        private Label lblTotal;
        private Button cmdConfirmar;
        private NumericUpDown nudDias;
    }
}
