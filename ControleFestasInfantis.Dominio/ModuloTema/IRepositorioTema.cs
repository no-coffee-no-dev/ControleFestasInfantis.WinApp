using ControleFestasInfantis.Dominio.ModuloItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloTema
{
    public interface IRepositorioTema : IRepositorio<Tema>
    {
        void VerificaOsItensDoTema(IRepositorioTema repositorioTema, IRepositorioItem repositorioItem);
        bool VerificaSeOTemaJaExiste(Tema tema, bool v);
    }
}
