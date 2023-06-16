using ControleFestasInfantis.Dominio.Compartilhado;
using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;
using ControleFestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema repositorioTema;
        private IRepositorioItem repositorioItem;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema repositorioTema, IRepositorioItem repositorioItem)
        {
            this.repositorioTema = repositorioTema;
            this.repositorioItem = repositorioItem;
        }


        public override string ToolTipInserir => "Inserir novo Tema";

        public override string ToolTipEditar => "Editar Tema existente";

        public override string ToolTipExcluir => "Excluir Tema existente";






        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => true;

        public override void CarregarEntidades()
        {
            List<Tema> temas = repositorioTema.RetornarTodos();
            tabelaTema.AtualizarRegistros(temas);
        }

        public override void Deletar()
        {
            Tema tema = ObterEntidadeSelecionada();

            if (tema == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Tema {tema.nome}?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Deletar(tema.id);
                CarregarEntidades();
            }
        }






        public override void Editar()
        {
            Tema tema = ObterEntidadeSelecionada();

            if (tema == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTemaForm telaTema = new TelaTemaForm(repositorioItem,tema);
            telaTema.Tema = tema;

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                if (repositorioTema.VerificaSeOTemaJaExiste(telaTema.Tema,true) == true)
                {
                    MessageBox.Show($"Um Tema com esse nome já existe!",
                        "Edição de Temas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }
                else
                    repositorioTema.Atualizar(telaTema.Tema.id, telaTema.Tema);


                CarregarEntidades();
            }
        }








        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm(repositorioItem);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.Tema;
                if (repositorioTema.VerificaSeOTemaJaExiste(telaTema.Tema,false) == true)
                {
                    MessageBox.Show($"Um Tema com esse nome já existe!",
                        "Inserção de Temas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }
                else
                    repositorioTema.Inserir(tema);

                CarregarEntidades();
            }
        }


        public override void VisualizarItem()
        {
            Tema tema = ObterEntidadeSelecionada();

            if (tema == null || tema.itens.Count == 0)
            {
                MessageBox.Show($"Selecione um tema com itens primeiro!",
                    "Visualização de Itens do Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaVisualizarItensForm telaTema = new TelaVisualizarItensForm(tema);
            telaTema.ShowDialog();

            telaTema.ShowDialog();

        }






        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarEntidades();

            return tabelaTema;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }

        public Tema ObterEntidadeSelecionada()
        {
            int id = tabelaTema.ObterIdSelecionado();

            return repositorioTema.Busca(id);
        }

    }
}
