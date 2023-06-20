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
    public partial class Tela_config : Form
    {
        public Tela_config()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void ObterDesconto()
        {
            Desconto.valorDescontoInicial = NumUpDown_Descontoinicial.Value;
            Desconto.valorDescontoFinal = NumUpDown_Descontofinal.Value;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ObterDesconto();

        }
    }
}
