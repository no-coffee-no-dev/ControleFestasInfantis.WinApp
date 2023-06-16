using ControleFestasInfantis.Dominio.ModuloCliente;


namespace ControleFestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        public TelaClienteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Cliente Cliente
        {
            set
            {
                ConfigurarValores(value);
            }
            get
            {
                return cliente;
            }
        }

        private void ConfigurarValores(Cliente value)
        {
            txtId.Text = value.id.ToString();
            txtNome.Text = value.nome;
            txtTelefone.Text = value.telefone;
            txtCpf.Text = value.cpf;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            cliente = ObterCliente();

            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                cliente.id = Convert.ToInt32(txtId.Text);
        }

        private Cliente ObterCliente()
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCpf.Text;
            return cliente = new Cliente(nome, telefone, cpf);
        }
    }

}
