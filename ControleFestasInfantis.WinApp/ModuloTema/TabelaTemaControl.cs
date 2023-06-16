using ControleFestasInfantis.Dominio.ModuloTema;


namespace ControleFestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }
        private void ConfigurarGrid()
        {
            tabelaTema.ConfigurarGridZebrado();

            tabelaTema.ConfigurarGridSomenteLeitura();

            tabelaTema.ConfigurarGridDockFill();

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
                }
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorTema",
                    HeaderText = "Valor"
                }
            };

            tabelaTema.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Tema> temas)
        {
            tabelaTema.Rows.Clear();
            foreach (Tema tema in temas)
            {
                tabelaTema.Rows.Add(tema.id, tema.nome,tema.valorTema);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaTema.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
