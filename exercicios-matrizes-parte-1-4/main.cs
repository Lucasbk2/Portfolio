//Crie um programa em C# que realize o preenchimento de uma matriz 2x4 com números reais e, em seguida, após a leitura completa, imprima na tela a média dos valores.
using System;
class MainClass {
  public static void Main (string[] args) {
		float soma = 0;
    float[,] matriz = new float[2,4];
		for (int x=0; x < 2;x++){
			for (int y=0;y<4;y++){
				Console.WriteLine("Qual valor deseja adiciona na {0}º matriz: ",x+1);
				matriz[x,y] = float.Parse(Console.ReadLine());
				
			}
		}
		for (int x2=0;x2<2;x2++){
			for (int y2=0;y2<4;y2++){
				soma += matriz[x2,y2];
			}
		}
		float media = (soma/8);
		Console.WriteLine("O resultado da soma foi de {0} e sua respectiva média de {1}.",soma,media);
  }
}