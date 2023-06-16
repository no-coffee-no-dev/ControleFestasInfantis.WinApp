namespace ControleFestasInfantis.WinApp.ModuloTema
{
    partial class TelaItemForm
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
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtTipo = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 20;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(63, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 21;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 57);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 22;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 101);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 23;
            label3.Text = "Tipo:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(63, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 23);
            txtNome.TabIndex = 24;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(63, 93);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(202, 23);
            txtTipo.TabIndex = 25;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(144, 191);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 30;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(230, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 138);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 32;
            label4.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(63, 135);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 33;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 244);
            Controls.Add(txtPreco);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTipo);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaItemForm";
            Text = "Cadastrar Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtTipo;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label4;
        private TextBox txtPreco;
    }
}