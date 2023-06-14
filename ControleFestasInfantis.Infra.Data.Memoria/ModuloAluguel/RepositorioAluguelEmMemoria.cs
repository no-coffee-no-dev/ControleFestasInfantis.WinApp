using ControleFestasInfantis.Dominio.ModuloItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Infra.Data.Memoria.ModuloAluguel
{
    internal class RepositorioAluguelEmMemoria : RepositorioBaseEmMemoria<Aluguel>, IRepositorioAlguel
    {
        public RepositorioItemEmMemoria(List<Alguel> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
    }
}
