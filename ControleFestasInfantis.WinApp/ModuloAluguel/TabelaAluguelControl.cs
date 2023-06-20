using ControleFestasInfantis.Dominio.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            ConfigurarColunas();
        }
        private void ConfigurarGrid()
        {
            tabelaAluguels.ConfigurarGridZebrado();

            tabelaAluguels.ConfigurarGridSomenteLeitura();

            tabelaAluguels.ConfigurarGridDockFill();

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
                    Name = "cliente.nome",
                    HeaderText = "Cliente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tema.nome",
                    HeaderText = "Tema"
                }
                
                
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                }
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "horaInicio",
                    HeaderText = "Hora de Inicio"
                }
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "horaTermino",
                    HeaderText = "Hora de Termino"
                }
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorTotal",
                    HeaderText = "Valor Total"
                }
            };

            tabelaAluguels.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Aluguel> aluguels)
        {
            tabelaAluguels.Rows.Clear();
            foreach (Aluguel aluguel in aluguels)
            {
                tabelaAluguels.Rows.Add(aluguel.id, aluguel.cliente.nome, aluguel.tema.nome, aluguel.date.ToString("dd/MM/yy"),aluguel.horaInicio.ToString("t"),aluguel.horaTermino.ToString("t"), aluguel.valorTotal);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaAluguels.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

