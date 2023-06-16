using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Infra.Data.Memoria.ModuloTema
{
    public class RepositorioTemaEmMomoria : RepositorioBaseEmMemoria<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmMomoria(List<Tema> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }

        public bool VerificaSeOTemaJaExiste(Tema temaAtual)
        {
            bool naoExiste = false;
            foreach (Tema tema in listaEntidades)
            {
                if (tema.nome == temaAtual.nome)
                    return true;
                else
                    naoExiste = true;
            }
            if (naoExiste == true)
                return false;
            else
                return false;
        }
    }
}
