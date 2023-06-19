using ControleFestasInfantis.Dominio.ModuloAluguel;
using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;
using ControleFestasInfantis.Infra.Data.Memoria.ModuloAluguel;
using ControleFestasInfantis.WinApp.ModuloItem;
using ControleFestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.WinApp.ModuloAluguel
{
    internal class ControladorAluguel : ControladorBase
    {
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir =>"Inserindo um Aluguel";

        public override string ToolTipEditar => "Editando um Aluguel Existente";

        public override string ToolTipExcluir => "Deletando um Aluguel Existente";

        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado =>true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => false;

        public override void CarregarEntidades()
        {
            List<Aluguel> aluguels = repositorioAluguel.RetornarTodos();
            tabelaAluguel.AtualizarRegistros(aluguels);
        }

        public override void Deletar()
        {
            Aluguel aluguel = ObterEntidadeSelecionada();

            if (aluguel == null)
            {
                MessageBox.Show($"Selecione um Aluguel primeiro!",
                    "Exclusão de Aluguel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Aluguel?", "Exclusão de Aluguel",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Deletar(aluguel.id);
                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Aluguel aluguel = ObterEntidadeSelecionada();

            if (aluguel == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edição de Aluguel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioTema, repositorioCliente);
            telaAluguel.Aluguel = aluguel;

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Atualizar(telaAluguel.Aluguel.id, telaAluguel.Aluguel);
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioTema, repositorioCliente);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.Aluguel;
                aluguel.tema.AlugarTema();
                repositorioAluguel.Inserir(aluguel);

                CarregarEntidades();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarEntidades();

            return tabelaAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro Aluguel";
        }

        public Aluguel ObterEntidadeSelecionada()
        {
            int id = tabelaAluguel.ObterIdSelecionado();

            return repositorioAluguel.Busca(id);
        }
    }
}
