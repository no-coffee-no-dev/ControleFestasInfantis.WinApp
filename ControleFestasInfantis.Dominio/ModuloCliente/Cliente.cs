﻿using System;
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

        public Cliente(string nome, string telefone, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
        }

        public override void Atualizar(Cliente entidadeAtualizada)
        {
            nome = entidadeAtualizada.nome;
            telefone = entidadeAtualizada.telefone;
            cpf = entidadeAtualizada.cpf;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");
            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'telefone' é obrigatório");
            if (string.IsNullOrEmpty(cpf))
                erros.Add("O campo 'cpf' é obrigatório");

            return erros.ToArray();
        }
        public override string ToString()
        {
            return $"{nome} , Telefone {telefone}, cpf {cpf} ";
        }
    }
}