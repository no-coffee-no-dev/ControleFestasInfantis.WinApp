namespace ControleFestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new MaskedTextBox();
            label4 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 35);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 70);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 99);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefone:";
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 32);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(395, 23);
            txtNome.TabIndex = 18;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(93, 96);
            txtTelefone.Mask = "(99) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(149, 23);
            txtTelefone.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 99);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 26;
            label4.Text = "CPF:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(358, 144);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 28;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(439, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(304, 96);
            txtCpf.Mask = "000-000-000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(149, 23);
            txtCpf.TabIndex = 30;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 197);
            Controls.Add(txtCpf);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaClienteForm";
            Text = "Cadastrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNome;
        private MaskedTextBox txtTelefone;
        private Label label4;
        private Button btnGravar;
        private Button btnCancelar;
        private MaskedTextBox txtCpf;
    }
}