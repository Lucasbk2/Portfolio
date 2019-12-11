using System;


// Exercício 1: Crie uma classe chamada CalculadoraInt que possua como atributos 2 operandos e possua as seguintes operações (métodos):

// Métodos não estático para as operações Soma, Subtração, Divisão, Multiplicação para a realização das operações básicas com os operandos da calculadora.
// Método estático chamado Soma que recebe 2 valores inteiros como parâmetros e retorna a soma desses dois valores. Crie também o teste de utilização do método dentro do método main.
// Método não estático chamado Maior que retorna o maior dos dois operandos. Crie também o teste de utilização do método dentro do método main.


class MainClass {
  public static void Main (string[] args) {

		try{

		
    CalculadoraInt calculadora = new CalculadoraInt();

		Console.WriteLine("Digita um valor:");
		int var1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Digite o segundo valor:");
		int var2 = Convert.ToInt32(Console.ReadLine());

	


    Console.WriteLine ("Exemplo soma: {0} + {1} = {2}",var1,var2,calculadora.Soma(var1,var2));

    Console.WriteLine ("Exemplo Subtração: {0} - {1} = {2}",var1,var2,calculadora.Soma(var1,var2));

    Console.WriteLine ("Exemplo Multiplicação: {0} * {1} = {2}",var1,var2,calculadora.Soma(var1,var2));

    Console.WriteLine ("Exemplo Divisão: {0} / {1} = {2}",var1,var2,calculadora.Soma(var1,var2));

    Console.WriteLine ("Exemplo soma estatica: {0} + {1} = {2}",var1,var2,calculadora.Soma(var1,var2));

    Console.WriteLine ("Maior número: Entre {0} e {1} é {2}",var1,var2,calculadora.Soma(var1,var2));
	}
	catch{

			Console.WriteLine("Errou!");

	}

  }
}