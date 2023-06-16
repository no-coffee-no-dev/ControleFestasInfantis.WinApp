using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloTema
{
    public interface IRepositorioTema : IRepositorio<Tema>
    {
        public bool VerificaSeOTemaJaExiste(Tema tema);
    }
}
