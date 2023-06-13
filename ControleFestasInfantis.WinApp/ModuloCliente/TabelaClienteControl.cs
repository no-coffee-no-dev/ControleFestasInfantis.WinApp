using ControleFestasInfantis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControleFestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }
        private void ConfigurarGrid()
        {
            tabelaCliente.ConfigurarGridZebrado();

            tabelaCliente.ConfigurarGridSomenteLeitura();

            tabelaCliente.ConfigurarGridDockFill();

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
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cpf",
                    HeaderText = "CPF"
                }
            };

            tabelaCliente.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Cliente> clientes)
        {
            tabelaCliente.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                tabelaCliente.Rows.Add(cliente.id, cliente.nome, cliente.telefone, cliente.cpf);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaCliente.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

