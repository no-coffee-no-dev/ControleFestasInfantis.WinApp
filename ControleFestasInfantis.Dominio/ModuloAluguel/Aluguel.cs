using ControleFestasInfantis.Dominio.ModuloCliente;
using ControleFestasInfantis.Dominio.ModuloItem;
using ControleFestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public Cliente cliente;
        public Tema tema;
        public DateTime date;
        public decimal valorTotal;
        public DateTime horaInicio, horaTermino;
        public String endereco;
        public decimal percentualDesconto;

        public Aluguel(Cliente cliente, Tema tema, DateTime date, decimal valorTotal, DateTime horaInicio, DateTime horaTermino, string endereco)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.date = date;
            this.valorTotal = valorTotal;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.endereco = endereco;
        }

        public override void Atualizar(Aluguel entidadeAtualizada)
        {
            cliente = entidadeAtualizada.cliente;
            tema = entidadeAtualizada .tema;
            date = entidadeAtualizada .date;
            valorTotal = entidadeAtualizada.valorTotal;
            horaInicio = entidadeAtualizada.horaInicio;
            horaTermino = entidadeAtualizada.horaTermino;
            endereco = entidadeAtualizada.endereco;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (cliente == null)
                erros.Add("O campo 'Cliente' é obrigatório");
            if (tema == null)
                erros.Add("O campo 'Tema' é obrigatório");
            if (horaInicio > horaTermino)
                erros.Add("A hora de conclusão não pode ser menor que a hora de criação");
            if (date > DateTime.Now)
                erros.Add("A data do evento não pode ser menor que a data atual");
            if (string.IsNullOrEmpty(endereco))
                erros.Add("O campo 'endereço' é obrigatório");

            return erros.ToArray();
        }
        public void AumentarQuantidadeAluguel()
        {
            cliente.numeroAlugueis++;
        }
        public void DiminuirQuantidadeAluguel()
        {
            cliente.numeroAlugueis--;
        }

        public void ContarQuantidadeAlugueis()
        {
            if(cliente.numeroAlugueis == 0)
            {
                decimal percentual = valorTotal * (1/100);
                valorTotal -= percentual;
            }
            
        }
    }
}
