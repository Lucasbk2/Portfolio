using System;

class MainClass {
  public static void Main (string[] args) {
		double cal =0;
    Console.WriteLine("Digite sua altura: ");
		float variavel = float.Parse(Console.ReadLine());
		Console.WriteLine("Digite seu sexo (F) ou (M): ");
		string variavel2 = Console.ReadLine();
		if(variavel2 == "F"){

			cal = (variavel * 62.1);
		}
		else if (variavel2 == "M"){

				cal = variavel * 72.7;

		}
		Console.WriteLine(cal);
			



	
		

  }
}