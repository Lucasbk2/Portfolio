using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Models
{
    class PessoaJuridia : Pessoa
    {
        private string cnpj { get; set; }
        public string GetCnpj()
        {
            return cnpj;
        }
        public void GetCnpj(string cp)
        {
            cnpj = cp;
        }

    }
}
