using ControleFestasInfantis.Dominio.ModuloItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFestasInfantis.WinApp.ModuloItem
{
    public partial class TabelaItemControl : UserControl
    {
        public TabelaItemControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            ConfigurarColunas();
        }
        private void ConfigurarGrid()
        {
            tabelaItem.ConfigurarGridZebrado();

            tabelaItem.ConfigurarGridSomenteLeitura();

            tabelaItem.ConfigurarGridDockFill();

        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tipo",
                    HeaderText = "Tipo"
                }
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "preco",
                    HeaderText = "Preco"
                }
            };

            tabelaItem.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Item> itens)
        {
            tabelaItem.Rows.Clear();
            foreach (Item item in itens)
            {
                tabelaItem.Rows.Add(item.id, item.nome, item.tipo,item.preco);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaItem.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
