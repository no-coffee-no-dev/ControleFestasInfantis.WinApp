namespace ControleFestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            CBX_CLIENTE = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CBX_TEMA = new ComboBox();
            DTP_HORAINICIO = new DateTimePicker();
            DTP_HORATERMINO = new DateTimePicker();
            TXT_VALORTOTAL = new TextBox();
            TXT_ENDERECO = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            label8 = new Label();
            DTP_DATA = new DateTimePicker();
            label9 = new Label();
            txtPercentual = new TextBox();
            btnCalcularValorTotal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 25);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // CBX_CLIENTE
            // 
            CBX_CLIENTE.FormattingEnabled = true;
            CBX_CLIENTE.Location = new Point(133, 56);
            CBX_CLIENTE.Name = "CBX_CLIENTE";
            CBX_CLIENTE.Size = new Size(117, 23);
            CBX_CLIENTE.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 197);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Hora inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 232);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 5;
            label4.Text = "Hora Termino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 299);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 6;
            label5.Text = "Valor Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 269);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 7;
            label6.Text = "Endereço de Entrega";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 92);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 8;
            label7.Text = "Tema";
            // 
            // CBX_TEMA
            // 
            CBX_TEMA.FormattingEnabled = true;
            CBX_TEMA.Location = new Point(133, 89);
            CBX_TEMA.Name = "CBX_TEMA";
            CBX_TEMA.Size = new Size(117, 23);
            CBX_TEMA.TabIndex = 9;
            // 
            // DTP_HORAINICIO
            // 
            DTP_HORAINICIO.Format = DateTimePickerFormat.Time;
            DTP_HORAINICIO.Location = new Point(133, 191);
            DTP_HORAINICIO.Name = "DTP_HORAINICIO";
            DTP_HORAINICIO.ShowUpDown = true;
            DTP_HORAINICIO.Size = new Size(200, 23);
            DTP_HORAINICIO.TabIndex = 10;
            // 
            // DTP_HORATERMINO
            // 
            DTP_HORATERMINO.Format = DateTimePickerFormat.Time;
            DTP_HORATERMINO.Location = new Point(133, 226);
            DTP_HORATERMINO.Name = "DTP_HORATERMINO";
            DTP_HORATERMINO.ShowUpDown = true;
            DTP_HORATERMINO.Size = new Size(200, 23);
            DTP_HORATERMINO.TabIndex = 11;
            // 
            // TXT_VALORTOTAL
            // 
            TXT_VALORTOTAL.Location = new Point(133, 299);
            TXT_VALORTOTAL.Name = "TXT_VALORTOTAL";
            TXT_VALORTOTAL.ReadOnly = true;
            TXT_VALORTOTAL.Size = new Size(83, 23);
            TXT_VALORTOTAL.TabIndex = 12;
            // 
            // TXT_ENDERECO
            // 
            TXT_ENDERECO.Location = new Point(133, 266);
            TXT_ENDERECO.Name = "TXT_ENDERECO";
            TXT_ENDERECO.Size = new Size(83, 23);
            TXT_ENDERECO.TabIndex = 13;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(223, 342);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 31;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(316, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 33;
            txtId.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 157);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 34;
            label8.Text = "Data do Evento";
            // 
            // DTP_DATA
            // 
            DTP_DATA.Format = DateTimePickerFormat.Short;
            DTP_DATA.Location = new Point(133, 151);
            DTP_DATA.Name = "DTP_DATA";
            DTP_DATA.Size = new Size(200, 23);
            DTP_DATA.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 121);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 36;
            label9.Text = "Percentual Desconto";
            // 
            // txtPercentual
            // 
            txtPercentual.Location = new Point(133, 118);
            txtPercentual.Name = "txtPercentual";
            txtPercentual.Size = new Size(83, 23);
            txtPercentual.TabIndex = 37;
            // 
            // btnCalcularValorTotal
            // 
            btnCalcularValorTotal.Location = new Point(223, 299);
            btnCalcularValorTotal.Name = "btnCalcularValorTotal";
            btnCalcularValorTotal.Size = new Size(69, 23);
            btnCalcularValorTotal.TabIndex = 38;
            btnCalcularValorTotal.Text = "Calcular";
            btnCalcularValorTotal.UseVisualStyleBackColor = true;
            btnCalcularValorTotal.Click += btnCalcularValorTotal_Click;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 395);
            Controls.Add(btnCalcularValorTotal);
            Controls.Add(txtPercentual);
            Controls.Add(label9);
            Controls.Add(DTP_DATA);
            Controls.Add(label8);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(TXT_ENDERECO);
            Controls.Add(TXT_VALORTOTAL);
            Controls.Add(DTP_HORATERMINO);
            Controls.Add(DTP_HORAINICIO);
            Controls.Add(CBX_TEMA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CBX_CLIENTE);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaAluguelForm";
            Text = "Cadastrar Aluguel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CBX_CLIENTE;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox CBX_TEMA;
        private DateTimePicker DTP_HORAINICIO;
        private DateTimePicker DTP_HORATERMINO;
        private TextBox TXT_VALORTOTAL;
        private TextBox TXT_ENDERECO;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label label8;
        private DateTimePicker DTP_DATA;
        private Label label9;
        private TextBox txtPercentual;
        private Button btnCalcularValorTotal;
    }
}