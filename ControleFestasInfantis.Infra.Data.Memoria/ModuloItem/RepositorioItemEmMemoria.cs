using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Infra.Data.Memoria.ModuloItem
{
    public class RepositorioItemEmMemoria : RepositorioBaseEmMemoria<Item>, IRepositorioItem
    {
        public RepositorioItemEmMemoria(List<Item> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
    }
}
