using ControleFestasInfantis.Dominio.ModuloCliente;


namespace ControleFestasInfantis.Infra.Data.Memoria.ModuloCliente
{
    public class RepositorioClienteEmMomoria : RepositorioBaseEmMemoria<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmMomoria(List<Cliente> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
    }
}
