using ControleFestasInfantis.Dominio.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome;
        public string telefone;
        public string cpf;
        public List<Aluguel> alugueisDoCliente;
        public Cliente(string nome, string telefone, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            alugueisDoCliente = new List<Aluguel>();
        }

        public override void Atualizar(Cliente entidadeAtualizada)
        {
            nome = entidadeAtualizada.nome;
            telefone = entidadeAtualizada.telefone;
            cpf = entidadeAtualizada.cpf;
            alugueisDoCliente = entidadeAtualizada.alugueisDoCliente;
        }
        public void InserirAluguel(Aluguel aluguel)
        {
            alugueisDoCliente.Add(aluguel);
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");
            if (nome.Length < 5)
                erros.Add("O campo 'nome' deve ter no mínimo 5 letras");
            if (telefone.EndsWith('-'))
                erros.Add("O campo 'telefone' é obrigatório");
            if (cpf.EndsWith('-'))
                erros.Add("O campo 'cpf' é obrigatório");

            return erros.ToArray();
        }
        public override string ToString()
        {
            return $"{nome}";
        }
    }
}
