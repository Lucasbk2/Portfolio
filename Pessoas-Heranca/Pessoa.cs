using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Models
{
    class Pessoa
    {
        protected string nome { get; set; }
        protected int idade { get; set; }
        protected string sexo { get; set; }
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string no)
        {
            nome = no;
        }
        public int GetIdade()
        {
            return idade;
        }
        public void SetIdade(int id)
        {
            idade = id;
        }
        public string GetSexo()
        {
            return sexo;
        }
        public void SetSexo(string sex)
        {
            sexo = sex;
        }



    }
}
