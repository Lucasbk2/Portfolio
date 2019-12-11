using System;
using System.IO;
using System.Text;
class MainClass {
  public static void Main (string[] args) {
		int n1 = 0, n2 =0;
		Console.WriteLine("Digite o primeiro numero: ");
		n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo numero: ");
		n2 = int.Parse(Console.ReadLine());
		FileStream arq = new FileStream("soma.txt", FileMode.Open,FileAccess.Write);
		StreamWriter escrever = new StreamWriter(arq,Encoding.UTF8);

		escrever.WriteLine(n1+n2);
		escrever.Close();
		arq.Close();
		
  }
}