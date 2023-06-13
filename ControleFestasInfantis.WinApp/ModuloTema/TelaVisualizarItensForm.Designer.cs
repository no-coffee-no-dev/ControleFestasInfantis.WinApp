namespace ControleFestasInfantis.WinApp.ModuloTema
{
    partial class TelaVisualizarItensForm
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
            btnFechar = new Button();
            Itens = new GroupBox();
            lblNomeDoTema = new Label();
            this.listaItens = new ListBox();
            Itens.SuspendLayout();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(336, 471);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 41);
            btnFechar.TabIndex = 31;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // Itens
            // 
            Itens.Controls.Add(this.listaItens);
            Itens.Location = new Point(8, 63);
            Itens.Name = "Itens";
            Itens.Size = new Size(403, 393);
            Itens.TabIndex = 32;
            Itens.TabStop = false;
            Itens.Text = "Itens";
            // 
            // lblNomeDoTema
            // 
            lblNomeDoTema.AutoSize = true;
            lblNomeDoTema.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeDoTema.Location = new Point(8, 9);
            lblNomeDoTema.Name = "lblNomeDoTema";
            lblNomeDoTema.Size = new Size(86, 37);
            lblNomeDoTema.TabIndex = 33;
            lblNomeDoTema.Text = "Tema";
            // 
            // listaItens
            // 
            this.listaItens.Dock = DockStyle.Fill;
            this.listaItens.FormattingEnabled = true;
            this.listaItens.ItemHeight = 15;
            this.listaItens.Location = new Point(3, 19);
            this.listaItens.Name = "listaItens";
            this.listaItens.Size = new Size(397, 371);
            this.listaItens.TabIndex = 34;
            // 
            // TelaVisualizarItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 524);
            Controls.Add(lblNomeDoTema);
            Controls.Add(Itens);
            Controls.Add(btnFechar);
            Name = "TelaVisualizarItensForm";
            Text = "Visualizando Itens";
            Itens.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private GroupBox Itens;
        private Label lblNomeDoTema;
        private ListBox listaItens;
    }
}