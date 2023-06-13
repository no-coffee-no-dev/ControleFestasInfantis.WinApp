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
    }
}
