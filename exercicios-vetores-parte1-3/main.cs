//Exercício 03: Crie um programa em C# que realize o preenchimento de um vetor com 10 números inteiros a partir da entrada padrão (teclado) e, em seguida, imprima na tela os valores pares em uma linha e os valores ímpares em outra linha.
using System;
class MainClass {
  public static void Main (string[] args) {
    int[] array = new int[10];
		for (int x=0;x < 10;x++){
		Console.WriteLine("{0}º número do vetor: ",x+1);
		array[x] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Pares");
		for (int y=0;y<10;y++){
			if (array[y] % 2 == 0)
				Console.WriteLine(array[y]);
		}
		Console.WriteLine("Impares");
		for (int z=0;z<10;z++){
		if(array[z] % 2 != 0)
			Console.WriteLine(array[z]);
		}
  }
}