using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Models
{
    public class Reserva
    {
        List<Pessoa> Hospedes = new List<Pessoa>();
        Suite Suite = new Suite();
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes (List<Pessoa> hospedes)
        {
            if(Suite.Capacidade >= hospedes.Count){
                Hospedes = hospedes;    
            } else {
                
               throw new Exception("Suíte ja lotada.");
            }
             
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            int quantidadeH = Hospedes.Count;
            return quantidadeH;
        }

        public decimal CalcularValorDiaria (){
           decimal valor =  Suite.ValorDiaria ;
             valor = valor* DiasReservados;

             if(DiasReservados >= 10){
               decimal desconto = (valor * 10) / 100;

               valor = valor - desconto;
             }

             return valor;
        }

    }
}