using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heraca.Models
{
    public class PessoaFisica : Pessoa
    {
        public int Cpf { get; set; }

        public PessoaFisica(int cpf)
        {
            this.Cpf = cpf;
        }




    }
}
