using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(){}

        public Pessoa(string nome){
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome){
            Nome = nome;    
            Sobrenome = sobrenome;
        }
    }
}