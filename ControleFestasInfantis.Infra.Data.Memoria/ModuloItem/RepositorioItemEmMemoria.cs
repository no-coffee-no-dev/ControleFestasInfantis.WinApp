using ControleFestasInfantis.Dominio.ModuloItem;

namespace ControleFestasInfantis.Infra.Data.Memoria.ModuloItem
{
    public class RepositorioItemEmMemoria : RepositorioBaseEmMemoria<Item>, IRepositorioItem
    {
        public RepositorioItemEmMemoria(List<Item> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }

        public bool VerificaSeOItemJaExiste(Item itemAtual, bool ehEdicao)
        {
            bool naoExiste = false;

            if (ehEdicao == true)
            {
                foreach (Item item in listaEntidades)
                {
                    if (item.nome == itemAtual.nome && item.tipo == itemAtual.tipo && item.preco == itemAtual.preco)
                        return true;
                    else
                        naoExiste = true;
                }
            }
            else
            {
                foreach (Item item in listaEntidades)
                {
                    if (item.nome == itemAtual.nome)
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
    }
}
