using System;
class MainClass {
  public static void Main (string[] args) {
		int num1 , num2 , num3;
		string input;
    Console.WriteLine ("Digite o primeiro numero: ");
		input = Console.ReadLine();
		num1 = Convert.ToInt16(input);
		
		Console.WriteLine("Digite o segundo numero: ");
		input = Console.ReadLine();
		num2 = Convert.ToInt16(input);

		Console.WriteLine("Digite o terceiro numero");
		input = Console.ReadLine();
		num3 = Convert.ToInt16(input);
		
		if (num3 >= num1 & num3 >= num2){
			Console.WriteLine(num3);
		}
		if (num2 >= num1 & num2 >= num3){
			Console.WriteLine(num2);
		}
		if (num1 >= num2 & num1 >= num3){
			Console.WriteLine(num1);
		}
  }
}