//Crie um programa em C# que realize o preenchimento de um vetor com 10 números inteiros a partir da entrada padrão (teclado) e, em seguida, imprima esses dados na tela para o usuário.
using System;
class MainClass {
  public static void Main (string[] args) {
		int num =0, x=0;
    int[] array = new int[10];
		for (x =0;x<10;x++){
			Console.WriteLine("Digite o {0}º número: ",(x+1));
			num = int.Parse(Console.ReadLine());
			array[x] = num;
		}
		for (int y=0;y <10;y++){
			Console.WriteLine("posição {0}º, número {1}º.",y,array[y]);
		}
	}
}