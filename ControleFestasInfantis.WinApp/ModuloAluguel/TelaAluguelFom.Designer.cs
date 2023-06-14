namespace ControleFestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelFom
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
            textBox1 = new TextBox();
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // CBX_CLIENTE
            // 
            CBX_CLIENTE.FormattingEnabled = true;
            CBX_CLIENTE.Location = new Point(70, 56);
            CBX_CLIENTE.Name = "CBX_CLIENTE";
            CBX_CLIENTE.Size = new Size(117, 23);
            CBX_CLIENTE.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Hora inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 5;
            label4.Text = "Hora Termino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 6;
            label5.Text = "Valor Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 7;
            label6.Text = "Endereço de Entrega";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 88);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 8;
            label7.Text = "Tema";
            // 
            // CBX_TEMA
            // 
            CBX_TEMA.FormattingEnabled = true;
            CBX_TEMA.Location = new Point(70, 85);
            CBX_TEMA.Name = "CBX_TEMA";
            CBX_TEMA.Size = new Size(117, 23);
            CBX_TEMA.TabIndex = 9;
            // 
            // DTP_HORAINICIO
            // 
            DTP_HORAINICIO.Location = new Point(97, 124);
            DTP_HORAINICIO.Name = "DTP_HORAINICIO";
            DTP_HORAINICIO.Size = new Size(200, 23);
            DTP_HORAINICIO.TabIndex = 10;
            // 
            // DTP_HORATERMINO
            // 
            DTP_HORATERMINO.Location = new Point(97, 159);
            DTP_HORATERMINO.Name = "DTP_HORATERMINO";
            DTP_HORATERMINO.Size = new Size(200, 23);
            DTP_HORATERMINO.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(83, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(83, 23);
            textBox3.TabIndex = 13;
            // 
            // TelaAluguelFom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 358);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
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
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TelaAluguelFom";
            Text = "TelaAluguelFom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
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
        private TextBox textBox2;
        private TextBox textBox3;
    }
}