namespace ControleFestasInfantis.WinApp.ModuloAluguel
{
    partial class Tela_config
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
            D = new Label();
            label2 = new Label();
            NumUpDown_Descontoinicial = new NumericUpDown();
            NumUpDown_Descontofinal = new NumericUpDown();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)NumUpDown_Descontoinicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDown_Descontofinal).BeginInit();
            SuspendLayout();
            // 
            // D
            // 
            D.AutoSize = true;
            D.Location = new Point(7, 34);
            D.MaximumSize = new Size(100, 0);
            D.Name = "D";
            D.Size = new Size(96, 30);
            D.TabIndex = 0;
            D.Text = "Desconto por aluguel realizado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Desconto Final";
            // 
            // NumUpDown_Descontoinicial
            // 
            NumUpDown_Descontoinicial.Location = new Point(109, 34);
            NumUpDown_Descontoinicial.Name = "NumUpDown_Descontoinicial";
            NumUpDown_Descontoinicial.Size = new Size(120, 23);
            NumUpDown_Descontoinicial.TabIndex = 2;
            // 
            // NumUpDown_Descontofinal
            // 
            NumUpDown_Descontofinal.Location = new Point(109, 74);
            NumUpDown_Descontofinal.Name = "NumUpDown_Descontofinal";
            NumUpDown_Descontofinal.Size = new Size(120, 23);
            NumUpDown_Descontofinal.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(73, 121);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 32;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(154, 121);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Tela_config
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 185);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(NumUpDown_Descontofinal);
            Controls.Add(NumUpDown_Descontoinicial);
            Controls.Add(label2);
            Controls.Add(D);
            Name = "Tela_config";
            Text = "Configuração de Desconto";
            ((System.ComponentModel.ISupportInitialize)NumUpDown_Descontoinicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDown_Descontofinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label D;
        private Label label2;
        private NumericUpDown NumUpDown_Descontoinicial;
        private NumericUpDown NumUpDown_Descontofinal;
        private Button btnGravar;
        private Button btnCancelar;
    }
}