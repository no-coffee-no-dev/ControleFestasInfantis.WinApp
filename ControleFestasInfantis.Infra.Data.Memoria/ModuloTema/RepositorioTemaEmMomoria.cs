using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloItem;
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

        public bool VerificaSeOTemaJaExiste(Tema temaAtual, bool ehEdicao)
        {
            bool naoExiste = false;

            if(ehEdicao == true)
            {
                foreach (Tema tema in listaEntidades)
                {
                    if (tema.nome == temaAtual.nome && tema.valorTema == temaAtual.valorTema)
                        return true;
                    else
                        naoExiste = true;
                }
            }
            else
            {
                foreach (Tema tema in listaEntidades)
                {
                    if (tema.nome == temaAtual.nome)
                        return true;
                    else
                        naoExiste = true;
                }

            }
            if (naoExiste == true)
                return false;
            else
                return false;
        }
        public void VerificaOsItensDoTema(IRepositorioTema repositorioTema, IRepositorioItem repositorioItem)
        {
            foreach (Item item in repositorioItem.RetornarTodos())
            {
               item.estahUtilizado = false;               
            }

            foreach (Tema tema in repositorioTema.RetornarTodos())
            {
                foreach (Item item in repositorioItem.RetornarTodos())
                {
                    if (tema.itens.Contains(item))
                    {
                        item.UtilizarEsteItem();
                    }
                }
            }
            
            
        }
    }
}
