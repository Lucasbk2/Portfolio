using System;

class MainClass {
  public static void Main (string[] args) {
    int valor = 0;
		int soma = 0;
		while (valor <10){
			valor++;
			Console.WriteLine("Digite o "+valor+"º valor.");
			int numero = int.Parse(Console.ReadLine());
			soma = (soma+ numero);
			
		} 
		float media = (soma / valor);
		Console.WriteLine("A média dos valores é :"+media);
  }
}