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

namespace ControleFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaItemForm : Form
    {
        private Item item;
        public TelaItemForm()
        {
            InitializeComponent();
        }

        public Item Item
        {
            get
            {
                return item;
            }
            set
            {
                ConfigurarValores(value);

            }
        }

        private void ConfigurarValores(Item value)
        {
            txtId.Text = value.id.ToString();
            txtNome.Text = value.nome;
            txtTipo.Text = value.tipo;
            txtPreco.Text = value.preco.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            item = ObterItem();

            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                item.id = Convert.ToInt32(txtId.Text);
        }

        private Item ObterItem()
        {
            string nome = txtNome.Text;
            string tipo = txtTipo.Text;
            double preco = 0;
            try
            {
               preco = Convert.ToDouble(txtPreco.Text);
            }
            catch(FormatException)
            {}
            return new Item(nome, tipo, preco);
        }

    }
}
