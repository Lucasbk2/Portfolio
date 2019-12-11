using System;

class MainClass {
  public static void Main (string[] args) {
		int soma = 0;
    for(int x=0;x<10;x++){
			Console.WriteLine("Digite o numero "+(x+1));
			int numero = int.Parse(Console.ReadLine());
			soma += numero;

		}
		int media = soma /10;
		Console.WriteLine("Soma: "+soma+" Media: "+media);
  }
}