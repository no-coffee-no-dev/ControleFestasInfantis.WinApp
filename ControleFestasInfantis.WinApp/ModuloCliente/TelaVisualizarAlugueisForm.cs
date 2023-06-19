using ControleFestasInfantis.Dominio.ModuloAluguel;
using ControleFestasInfantis.Dominio.ModuloCliente;

namespace ControleFestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaVisualizarAlugueisForm : Form
    {
        public TelaVisualizarAlugueisForm(Cliente cliente)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTela(cliente);
        }
        public void ConfigurarTela(Cliente cliente)
        {
            ConfigurarLista(cliente);
            ConfigurarLabel(cliente);
        }
        public void ConfigurarLista(Cliente cliente)
        {
            foreach (Aluguel aluguel in cliente.alugueisDoCliente)
            {
                listaAlugueis.Items.Add(aluguel);
            }
        }

        public void ConfigurarLabel(Cliente cliente)
        {
            lblNomeDoCliente.Text = cliente.nome;
        }

    }
}
