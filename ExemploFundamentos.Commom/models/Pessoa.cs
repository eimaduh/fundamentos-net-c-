using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Commom.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá mundo! Meu nome é {Nome}, eu tenho {Idade} anos e sou {Profissao} ");
        }
        
        
    }
}