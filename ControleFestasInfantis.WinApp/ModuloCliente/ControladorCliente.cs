using ControleFestasInfantis.Dominio.Compartilhado;
using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloTema;
using ControleFestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir => "Inserir novo Cliente";

        public override string ToolTipEditar => "Editar Cliente existente";

        public override string ToolTipExcluir => "Editar Cliente existente";


        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => true;
        public override bool BotaoConfigurarDescontoAtivado => false;

        public override void Deletar()
        {

            Cliente cliente = ObterEntidadeSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Cliente {cliente.nome}?", "Exclusão de Clientes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Deletar(cliente.id);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {

            Cliente cliente = ObterEntidadeSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm telaCliente= new TelaClienteForm();
            telaCliente.Cliente = cliente;

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Atualizar(telaCliente.Cliente.id, telaCliente.Cliente);

                CarregarEntidades();
            }
        }





        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.Cliente;

                repositorioCliente.Inserir(cliente);

                CarregarEntidades();
            }
        }


        public override void VisualizarItem() 
        {
            Cliente cliente = ObterEntidadeSelecionado();

            if (cliente == null || cliente.alugueisDoCliente.Count == 0)
            {
                MessageBox.Show($"Selecione um cliente com aluguéis primeiro!",
                    "Visualização de Itens do Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaVisualizarAlugueisForm telaVisualizarAlugueis = new TelaVisualizarAlugueisForm(cliente);
            telaVisualizarAlugueis.ShowDialog();
        }


        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarEntidades();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }

        public Cliente ObterEntidadeSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();

            return repositorioCliente.Busca(id);
        }

        public override void CarregarEntidades()
        {
            List<Cliente> clientes = repositorioCliente.RetornarTodos();
            tabelaCliente.AtualizarRegistros(clientes);
        }
    }
}
