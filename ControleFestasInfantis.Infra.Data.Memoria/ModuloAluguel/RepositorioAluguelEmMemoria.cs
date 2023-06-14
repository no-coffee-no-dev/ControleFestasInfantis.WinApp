using ControleFestasInfantis.Dominio.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Infra.Data.Memoria.ModuloAluguel
{
    public class RepositorioAluguelEmMemoria : RepositorioBaseEmMemoria<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmMemoria(List<Aluguel> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
    }
}
