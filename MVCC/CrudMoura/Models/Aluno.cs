using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMoura.Models
{
    public class Aluno
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public double Cpf {get; set;}
        public string Endereco {get; set;}
        public int Idade {get; set;}
    }
}