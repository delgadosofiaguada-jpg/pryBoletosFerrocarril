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
            cmdConfirmar = new Button();
            nudDias = new NumericUpDown();
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
            gbConsultaPrecio.Controls.Add(cmdConfirmar);
            gbConsultaPrecio.Controls.Add(nudDias);
            gbConsultaPrecio.Controls.Add(lblDias);
            gbConsultaPrecio.Controls.Add(mtbDistancia);
            gbConsultaPrecio.Controls.Add(lblDistancia);
            gbConsultaPrecio.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbConsultaPrecio.Location = new Point(12, 12);
            gbConsultaPrecio.Name = "gbConsultaPrecio";
            gbConsultaPrecio.Size = new Size(276, 172);
            gbConsultaPrecio.TabIndex = 0;
            gbConsultaPrecio.TabStop = false;
            gbConsultaPrecio.Text = "Consultar precio del Boleto";
            // 
            // cmdConfirmar
            // 
            cmdConfirmar.Enabled = false;
            cmdConfirmar.Location = new Point(15, 143);
            cmdConfirmar.Name = "cmdConfirmar";
            cmdConfirmar.Size = new Size(84, 23);
            cmdConfirmar.TabIndex = 4;
            cmdConfirmar.Text = "Confirmar";
            cmdConfirmar.UseVisualStyleBackColor = true;
            cmdConfirmar.Click += cmdConfirmar_Click;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(141, 88);
            nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(120, 25);
            nudDias.TabIndex = 3;
            nudDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(15, 96);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(109, 17);
            lblDias.TabIndex = 2;
            lblDias.Text = "Dias de estadía";
            // 
            // mtbDistancia
            // 
            mtbDistancia.Location = new Point(141, 39);
            mtbDistancia.Mask = "99999999km";
            mtbDistancia.Name = "mtbDistancia";
            mtbDistancia.Size = new Size(120, 25);
            mtbDistancia.TabIndex = 1;
            mtbDistancia.ValidatingType = typeof(int);
            mtbDistancia.MaskInputRejected += mtbDistancia_MaskInputRejected;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(15, 47);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(69, 17);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // lstbTotal
            // 
            lstbTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbTotal.FormattingEnabled = true;
            lstbTotal.ItemHeight = 17;
            lstbTotal.Location = new Point(12, 231);
            lstbTotal.Name = "lstbTotal";
            lstbTotal.Size = new Size(272, 89);
            lstbTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(12, 198);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 17);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            // 
            // Boleteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 332);
            Controls.Add(lblTotal);
            Controls.Add(lstbTotal);
            Controls.Add(gbConsultaPrecio);
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
        private NumericUpDown nudDias;
        private Label lblDias;
        private ListBox lstbTotal;
        private Label lblTotal;
        private Button cmdConfirmar;
    }
}
