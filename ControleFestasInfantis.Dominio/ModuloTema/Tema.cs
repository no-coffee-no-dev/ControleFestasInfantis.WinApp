﻿using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nome;
        public List<Item> itens;
        public decimal valorTema;
        public bool alugado;
        public Tema(string nome, List<Item> itens, bool alugado)
        {
            this.nome = nome;
            this.itens = itens;
            this.alugado = alugado;
            valorTema = ObterValorTema();
        }

        public override void Atualizar(Tema entidadeAtualizada)
        {
            nome = entidadeAtualizada.nome;
            itens = entidadeAtualizada.itens;
            alugado = entidadeAtualizada.alugado;
            valorTema = ObterValorTema();
        }

        public decimal ObterValorTema()
        {
            valorTema = 0;
            foreach (Item item in itens)
            {
                valorTema += Convert.ToDecimal(item.preco);
            }
            return valorTema;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
           
            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");
            if (itens.Count == 0)
                erros.Add("é obrigatório ter itens");
            if (itens.Count == 0)
                erros.Add("é obrigatório ter itens");

            return erros.ToArray();
        }
        public override string ToString()
        {
            return $"{nome}";
        }

        public void AlugarTema()
        {
            alugado = true;
        }

        public override bool Equals(object? obj)
        {
            return obj is Tema tema &&
                   id == tema.id &&
                   nome == tema.nome &&
                   EqualityComparer<List<Item>>.Default.Equals(itens, tema.itens) &&
                   valorTema == tema.valorTema;
        }
    }
}
