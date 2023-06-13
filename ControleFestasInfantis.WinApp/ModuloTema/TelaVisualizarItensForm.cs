using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;


namespace ControleFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaVisualizarItensForm : Form
    {
        public TelaVisualizarItensForm(Tema tema)
        {
            InitializeComponent();
            ConfigurarTela(tema);
        }
        public void ConfigurarTela(Tema tema)
        {
            ConfigurarLista(tema);
            ConfigurarLabel(tema);
        }
        public void ConfigurarLista(Tema tema)
        {
            foreach (Item item in tema.itens)
            {
                listaItens.Items.Add(item);
            }
        }

        public void ConfigurarLabel(Tema tema)
        {
            lblNomeDoTema.Text = tema.nome;
        }

        private void listaItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
