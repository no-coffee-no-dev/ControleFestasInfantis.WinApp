﻿using ControleFestasInfantis.Dominio.ModuloAluguel;
using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;
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
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        public TelaAluguelForm(IRepositorioTema repositorioTema, IRepositorioCliente repositorioCliente)
        {
            InitializeComponent();
            AdicionaAComboBox(repositorioCliente, repositorioTema);

        }

        public Aluguel Aluguel
        {
            get
            {
                return aluguel;
            }
            set
            {
                ConfigurarValores(value);

            }
        }

        private void ConfigurarValores(Aluguel value)
        {
            txtId.Text = value.id.ToString();


            if (value.cliente != null)
            {
                CBX_CLIENTE.SelectedItem = value.cliente;
            }
            if (value.tema != null)
            {
                CBX_TEMA.SelectedItem = value.tema;
            }

            DTP_DATA.Value = value.date;
            DTP_HORAINICIO.Value = value.horaInicio;
            DTP_HORATERMINO.Value = value.horaTermino;
            txtPercentual.Text = value.percentualDesconto.ToString();
            TXT_ENDERECO.Text = value.endereco;
            TXT_VALORTOTAL.Text = value.valorTotal.ToString();

        }
        public void AdicionaAComboBox(IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            foreach (Cliente cliente in repositorioCliente.RetornarTodos())
            {
                CBX_CLIENTE.Items.Add(cliente);
            }

            foreach (Tema tema in repositorioTema.RetornarTodos())
            {
                CBX_TEMA.Items.Add(tema);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            aluguel = ObterAluguel();

            string[] erros = aluguel.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                aluguel.id = Convert.ToInt32(txtId.Text);
        }
        private Aluguel ObterAluguel()
        {
            string endereco = TXT_ENDERECO.Text;
            decimal valorTotal = ObterValorTotal();
            Cliente cliente = CBX_CLIENTE.SelectedItem as Cliente;
            Tema tema = CBX_TEMA.SelectedItem as Tema;
            DateTime data = DTP_DATA.Value.Date;
            DateTime horaInicio = DTP_HORAINICIO.Value;
            DateTime horaTermino = DTP_HORATERMINO.Value;



            return new Aluguel(cliente, tema, data, valorTotal, horaInicio, horaTermino, endereco);
        }
        private decimal ObterValorTotal()
        {
            decimal valorTotal = 0;

            foreach (Tema tema in CBX_TEMA.Items)
            {
                if (tema.Equals(CBX_TEMA.SelectedItem))
                {
                    valorTotal = tema.ObterValorTema();
                }
            }
            decimal percentual = 0;
            if (txtPercentual.Text != "")
                percentual = Convert.ToDecimal(txtPercentual.Text);
            decimal porcentagem = valorTotal * (percentual / 100);
            return valorTotal - porcentagem;
            
            return valorTotal - porcentagem;
        }

        private void btnCalcularValorTotal_Click(object sender, EventArgs e)
        {
            if (CBX_TEMA.SelectedItem != null)
                TXT_VALORTOTAL.Text = ObterValorTotal().ToString();
        }
    }
}
