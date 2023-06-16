using ControleFestasInfantis.Dominio.ModuloAluguel;
using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;
using ControleFestasInfantis.Infra.Data.Memoria.ModuloAluguel;
using ControleFestasInfantis.Infra.Data.Memoria.ModuloCliente;
using ControleFestasInfantis.Infra.Data.Memoria.ModuloItem;
using ControleFestasInfantis.Infra.Data.Memoria.ModuloTema;
using ControleFestasInfantis.WinApp.ModuloAluguel;
using ControleFestasInfantis.WinApp.ModuloCliente;
using ControleFestasInfantis.WinApp.ModuloItem;
using ControleFestasInfantis.WinApp.ModuloTema;

namespace ControleFestasInfantis.WinApp
{
    public partial class TelaPrincipal : Form
    {
        UserControl listagem;

        private ControladorBase controlador;

        private IRepositorioCliente repositorioCliente = new RepositorioClienteEmMomoria(new List<Cliente>());
        private IRepositorioTema repositorioTema = new RepositorioTemaEmMomoria(new List<Tema>());
        private IRepositorioItem repositorioItem = new RepositorioItemEmMemoria(new List<Item>());
        private IRepositorioAluguel repositorioAluguel = new RepositorioAluguelEmMemoria(new List<Aluguel>());

        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        public static TelaPrincipal Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipal();

                return telaPrincipal;
            }
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            lblTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controladorBase);
            ConfigurarListagem(controladorBase);
            ConfigurarAcoesDosBotoes(controladorBase);

        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }







        private void ConfigurarAcoesDosBotoes(ControladorBase controlador)
        {

            btnInserir.Enabled = controlador.BotaoInserirAtivado;
            btnEditar.Enabled = controlador.BotaoEditarAtivado;
            btnDeletar.Enabled = controlador.BotaoDeletarAtivado;
            btnVisualizarItens.Enabled = controlador.BotaoVisualizarItensAtivado;
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {

            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnDeletar.ToolTipText = controlador.ToolTipExcluir;
        }

        public void AtualizarRodape(string mensagem)
        {
            lblRodape.Text = mensagem;
        }








        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
        }
        private void temasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema, repositorioItem);
            ConfigurarTelaPrincipal(controlador);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItem(repositorioItem);
            ConfigurarTelaPrincipal(controlador);
        }
        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel, repositorioCliente, repositorioTema);
            ConfigurarTelaPrincipal(controlador);

        }





        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Editar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Deletar();
        }

        private void VisualizarItens_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.VisualizarItem();
        }






        private bool VerificaControladorVazio(ControladorBase controlador)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma opção de cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }


    }
}