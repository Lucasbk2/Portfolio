using System;

class MainClass {
  public static void Main (string[] args) {
    int num1 =10;
		int num2 = 0; 
		try{
		Console.WriteLine("Divisão: {0}",num1 /num2);
		}
		catch(Exception e){
			Console.WriteLine("não da para dividir por zero");
		}
}
}