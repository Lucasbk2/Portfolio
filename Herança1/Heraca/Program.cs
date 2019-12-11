using Heraca.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heraca
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("idade man: ");
                Console.ReadLine();
                Pessoa pessoa = new PessoaJuridica();

            }
            catch (Exception e)
            {
                Console.WriteLine("deu problema {0}", e);
            }


        }
    }
}
