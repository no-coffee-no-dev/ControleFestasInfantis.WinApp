using ControleFestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloItem
{
    public interface IRepositorioItem : IRepositorio<Item>
    {
         public bool VerificaSeOItemJaExiste(Item item, bool ehEdicao);
    }
}
