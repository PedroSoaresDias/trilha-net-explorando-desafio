using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get ; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
        }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTADO*
            if (Suite.Capacidade >= hospedes.Count)
            {
                this.Hospedes = hospedes;
                Console.WriteLine("Está dentro da capacidade da suite");
            }
            else
            {
                // *IMPLEMENTADO*

                this.Hospedes = hospedes;
                Console.WriteLine("O número de hospedes passou da capacidade máxima da suite escolhida");
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            int quantidade = this.Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {

            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // *IMPLEMENTADO*
            decimal valorDescontado = valor * 0.10M;
            if (DiasReservados >= 10)
            {
                valor = valor - valorDescontado;
            }

            return valor;
        }
    }
}