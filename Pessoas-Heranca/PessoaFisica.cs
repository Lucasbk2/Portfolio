using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Models
{
    class PessoaFisica : Pessoa
    {
        private long cpf { get; set; }
        public PessoaFisica()
        {
            nome = "André";
            idade = 22;
            sexo = "Masculino";
            cpf = 190057148;
        }
        public PessoaFisica(string no,int id,string sex,long cp )
        {
            nome = no;
            idade = id;
            sexo = sex;
            cpf = cp;

        }
        public long GetCpf()
        {
            return cpf;           
        }
        public void GetCpf(long cp)
        {
            cpf = cp;
        }

    }
}
