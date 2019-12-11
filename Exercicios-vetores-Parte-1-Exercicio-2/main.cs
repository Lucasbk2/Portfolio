//Crie um programa em C# que realize o preenchimento de um vetor com 10 números inteiros a partir da entrada padrão (teclado) e, em seguida, imprima esses dados na tela para o usuário na ordem inversa.
using System;

class MainClass {
  public static void Main (string[] args) {
		int[] array = new int[]{1,2,3,4,5,6,7,8,9,10};
		Console.WriteLine("{0:F2}",15.325625);
  
		for(int x=0;  x<10; x++){
		Console.Write(array[x]+" ");
			
		}
		for(int y=9;y >0;y--){
			Console.Write(array[y]+" ");

		}


	
	
  } 
}