using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem.Entities
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        //getter tradicional - faz sempre algo simples.
        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Sobrenome}".ToUpper();
            }
        }
    }
}
