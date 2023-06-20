using ControleFestasInfantis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloAluguel
{
    public static class Desconto
    {   
        
        public  static decimal valorDescontoInicial;
        public static decimal valorDescontoFinal;
        

        public static decimal GerarDesconto(Cliente cliente)
        {   decimal valorAtual = 1;
            for(int i = 0; i<cliente.alugueisDoCliente.Count; i++)
            {
                if(valorAtual < valorDescontoFinal)
                {
                    valorAtual += valorDescontoInicial;
                }
            }
            return valorAtual;
        }
    }
}
