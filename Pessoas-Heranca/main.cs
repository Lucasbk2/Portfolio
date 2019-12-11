using Herança.Models;
using System;
using System.Collections.Generic;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {				
						Console.WriteLine("Deseja cadastrar uma pessoa Fisica(1) ou Pessoa Juridica(2): ");
						int decisao = int.Parse(Console.ReadLine());
							if(decisao == 1){
							Console.WriteLine("Digite seu nome: ");
							string nome = Console.ReadLine();
							int age = 0;
							
							while(age <= 0){
							Console.WriteLine("Digite sua idade: ");
							string idade = Console.ReadLine();

							try{
								age = int.Parse(idade);
								if(age <= 0){
									Console.WriteLine("Idade inválida, tente novamente");
								}

							}
							catch(Exception e){
								Console.WriteLine("Valor inválido, tente novamente");

							}
							}


							Console.WriteLine("Digite seu sexo: ");
							string sexo = Console.ReadLine();

							Console.WriteLine("Digite seu CPF");
							long cpf = long.Parse(Console.ReadLine());
							PessoaFisica people = new PessoaFisica(nome,age,sexo,cpf);
							Console.WriteLine(people.GetNome());
							
							

							
							}
        }
				
    }
}
