namespace ControleFestasInfantis.WinApp
{
    partial class TelaPrincipal
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
            menuStrip2 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            aluguelToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            temasToolStripMenuItem1 = new ToolStripMenuItem();
            itensToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            VisualizarItens = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            lblRodape = new ToolStripStatusLabel();
            menuStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aluguelToolStripMenuItem, clienteToolStripMenuItem, despesasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // aluguelToolStripMenuItem
            // 
            aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            aluguelToolStripMenuItem.Size = new Size(115, 22);
            aluguelToolStripMenuItem.Text = "Aluguel";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(115, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temasToolStripMenuItem1, itensToolStripMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(115, 22);
            despesasToolStripMenuItem.Text = "Temas";
            // 
            // temasToolStripMenuItem1
            // 
            temasToolStripMenuItem1.Name = "temasToolStripMenuItem1";
            temasToolStripMenuItem1.Size = new Size(107, 22);
            temasToolStripMenuItem1.Text = "Temas";
            temasToolStripMenuItem1.Click += temasToolStripMenuItem1_Click;
            // 
            // itensToolStripMenuItem
            // 
            itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            itensToolStripMenuItem.Size = new Size(107, 22);
            itensToolStripMenuItem.Text = "Itens";
            itensToolStripMenuItem.Click += itensToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator2, VisualizarItens, toolStripSeparator1, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 45);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.plus;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7, 7, 7, 0);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "Inserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.pen;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeletar.Image = Properties.Resources.delete;
            btnDeletar.ImageScaling = ToolStripItemImageScaling.None;
            btnDeletar.ImageTransparentColor = Color.Magenta;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Padding = new Padding(7);
            btnDeletar.Size = new Size(42, 42);
            btnDeletar.Text = "Deletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // VisualizarItens
            // 
            VisualizarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            VisualizarItens.Image = Properties.Resources.list;
            VisualizarItens.ImageScaling = ToolStripItemImageScaling.None;
            VisualizarItens.ImageTransparentColor = Color.Magenta;
            VisualizarItens.Name = "VisualizarItens";
            VisualizarItens.Padding = new Padding(7);
            VisualizarItens.Size = new Size(42, 42);
            VisualizarItens.Text = "Visualizar Itens";
            VisualizarItens.Click += VisualizarItens_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.BackColor = Color.Transparent;
            lblTipoCadastro.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(67, 42);
            lblTipoCadastro.Text = "                    ";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Location = new Point(0, 63);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 362);
            panelRegistros.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblRodape
            // 
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(132, 17);
            lblRodape.Text = "_________________________";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(panelRegistros);
            Name = "TelaPrincipal";
            Text = "Cad-Festas";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem aluguelToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem temasToolStripMenuItem1;
        private ToolStripMenuItem itensToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnDeletar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel lblTipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblRodape;
        private ToolStripButton VisualizarItens;
        private ToolStripSeparator toolStripSeparator1;
    }
}