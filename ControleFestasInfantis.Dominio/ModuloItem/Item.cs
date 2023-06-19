using ControleFestasInfantis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloItem
{
    public class Item : EntidadeBase<Item>
    {
        public string nome;        
        public string tipo;
        public double preco;
        public bool estahUtilizado;
        public Item(string nome, string tipo, double preco, bool estahUtilizado)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
            this.estahUtilizado = estahUtilizado;
        }


        public override void Atualizar(Item entidadeAtualizada)
        {
            nome = entidadeAtualizada.nome;
            tipo = entidadeAtualizada.tipo;
            preco = entidadeAtualizada.preco;
            estahUtilizado = entidadeAtualizada.estahUtilizado;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");
            if (string.IsNullOrEmpty(tipo))
                erros.Add("O campo 'tipo' é obrigatório");
            if (preco == 0)
                erros.Add("O campo 'preço' é obrigatório");



            return erros.ToArray();
        }

        public void UtilizarEsteItem()
        {
            estahUtilizado = true;
        }
        public override string ToString()
        {
            return $"{nome} | Tipo {tipo}  | Preço {preco}";
        }
    }
}
