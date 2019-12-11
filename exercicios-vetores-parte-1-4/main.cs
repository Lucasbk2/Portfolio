//Exercício 04: Crie um programa em C# que realize o preenchimento de um vetor com 10 caracteres e, em seguida, imprima na tela apenas as vogais presentes no vetor.
using System;

class MainClass {
  public static void Main (string[] args) {
    char[] array = new char[10];
		for (int x=0;x<10;x++){
			Console.WriteLine("Digite a {0}º Letra: ",(x+1));
			array[x] = char.Parse(Console.ReadLine());
		}
		for (int y=0;y<10;y++){
			if (string(array[y]) == "a" | string(array[y]) == "e" | string(array[y] =="i")  | string(array[y] == "o")  | string(array[y] == "u"))
				Console.WriteLine("a letra '{0}' é vogal ",array[y]);
			}
  }
}
