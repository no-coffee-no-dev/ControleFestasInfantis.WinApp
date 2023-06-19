using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;


namespace ControleFestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public TelaTemaForm(IRepositorioItem repositorioItem)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarLista(repositorioItem);
        }

        public TelaTemaForm(IRepositorioItem repositorioItem, Tema tema)
        {
            InitializeComponent();
            ConfigurarLista(repositorioItem);
            AlterarListaDeItems(repositorioItem, tema);

        }

        public Tema Tema
        {
            set
            {
                ConfigurarValores(value);
            }
            get
            {
                return tema;
            }
        }

        public void AlterarListaDeItems(IRepositorioItem repositorioItem, Tema tema)
        {
            listaItens.Items.Clear();

            int i = 0;
            foreach (Item item in repositorioItem.RetornarTodos())
            {
                listaItens.Items.Add(item);
                if (tema.itens.Contains(item))
                    listaItens.SetItemChecked(i, true);

                i++;
            }
        }
        private void ConfigurarValores(Tema value)
        {
            txtId.Text = value.id.ToString();
            txtNome.Text = value.nome;
        }

        private void ConfigurarLista(IRepositorioItem repositorioItem)
        {
            foreach (Item item in repositorioItem.RetornarTodos())
            {
                listaItens.Items.Add(item);
            }
        }
        private Tema ObterTema()
        {
            string nome = txtNome.Text;

            List<Item> itens = new List<Item>();
            foreach (Item item in listaItens.CheckedItems)
            {
                itens.Add(item);
            }


            return new Tema(nome, itens,false);
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            tema = ObterTema();

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                tema.id = Convert.ToInt32(txtId.Text);
        }
    }
}
