using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;
using ControleFestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {

        private IRepositorioItem repositorioItem;
        private TabelaItemControl tabelaItem;

        public ControladorItem(IRepositorioItem repositorioItem)
        {
            this.repositorioItem = repositorioItem;
        }

        public override string ToolTipInserir => "Inserir novo Item";

        public override string ToolTipEditar => "Editar Item existente";

        public override string ToolTipExcluir => "Excluir Item existente";




        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => false;

        public override bool BotaoConfigurarDescontoAtivado => false;





        public override void CarregarEntidades()
        {
            List<Item> itens = repositorioItem.RetornarTodos();
            tabelaItem.AtualizarRegistros(itens);
        }

        public override void Deletar()
        {
            Item item = ObterEntidadeSelecionada();

            if (item == null)
            {
                MessageBox.Show($"Selecione um item primeiro!",
                    "Exclusão de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (item.estahUtilizado == true)
            {
                MessageBox.Show($"Selecione um item não utilizado primeiro!",
                    "Exclusão de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Item {item.nome}?", "Exclusão de Itens",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioItem.Deletar(item.id);
                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Item item = ObterEntidadeSelecionada();

            if (item == null)
            {
                MessageBox.Show($"Selecione umtema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaItemForm telaItem = new TelaItemForm();
            telaItem.Item = item;

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                if (repositorioItem.VerificaSeOItemJaExiste(telaItem.Item,true) == true)
                {
                    MessageBox.Show($"Um Item com esse nome já existe!",
                        "Inserção de Item",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }
                else
                    repositorioItem.Atualizar(telaItem.Item.id, telaItem.Item);

                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item item = telaItem.Item;
                if (repositorioItem.VerificaSeOItemJaExiste(telaItem.Item,false) == true)
                {
                    MessageBox.Show($"Um Item com esse nome já existe!",
                        "Inserção de Item",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }
                else
                    repositorioItem.Inserir(item);
                
                   

                CarregarEntidades();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarEntidades();

            return tabelaItem;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro Itens";
        }

        public Item ObterEntidadeSelecionada()
        {
            int id = tabelaItem.ObterIdSelecionado();

            return repositorioItem.Busca(id);
        }
    }
}
