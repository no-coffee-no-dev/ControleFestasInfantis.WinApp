namespace ControleFestasInfantis.WinApp.ModuloCliente
{
    partial class TelaVisualizarAlugueisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlListaAlugueis = new GroupBox();
            listaAlugueis = new ListBox();
            lblNomeDoCliente = new Label();
            pnlListaAlugueis.SuspendLayout();
            SuspendLayout();
            // 
            // pnlListaAlugueis
            // 
            pnlListaAlugueis.Controls.Add(listaAlugueis);
            pnlListaAlugueis.Location = new Point(12, 70);
            pnlListaAlugueis.Name = "pnlListaAlugueis";
            pnlListaAlugueis.Size = new Size(403, 393);
            pnlListaAlugueis.TabIndex = 33;
            pnlListaAlugueis.TabStop = false;
            pnlListaAlugueis.Text = "Aluguéis";
            // 
            // listaAlugueis
            // 
            listaAlugueis.Dock = DockStyle.Fill;
            listaAlugueis.FormattingEnabled = true;
            listaAlugueis.ItemHeight = 15;
            listaAlugueis.Location = new Point(3, 19);
            listaAlugueis.Name = "listaAlugueis";
            listaAlugueis.Size = new Size(397, 371);
            listaAlugueis.TabIndex = 34;
            // 
            // lblNomeDoCliente
            // 
            lblNomeDoCliente.AutoSize = true;
            lblNomeDoCliente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeDoCliente.Location = new Point(12, 20);
            lblNomeDoCliente.Name = "lblNomeDoCliente";
            lblNomeDoCliente.Size = new Size(107, 37);
            lblNomeDoCliente.TabIndex = 34;
            lblNomeDoCliente.Text = "Cliente";
            // 
            // TelaVisualizarAlugueisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 475);
            Controls.Add(lblNomeDoCliente);
            Controls.Add(pnlListaAlugueis);
            Name = "TelaVisualizarAlugueisForm";
            Text = "TelaVisualizarAlugueisForm";
            pnlListaAlugueis.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox pnlListaAlugueis;
        private ListBox listaAlugueis;
        private Label lblNomeDoCliente;
    }
}