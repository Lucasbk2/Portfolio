//Crie um programa em C# que realize a leitura de 10 números presentes em um arquivo e exiba para o usuário a raiz quadrada de cada número lido.
using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
	float num = 0.0f;
	FileStream arquivo = new FileStream("dados.txt",FileMode.Open,FileAccess.Read);
	StreamReader ler = new StreamReader(arquivo,Encoding.UTF8);
	for (int x=0;x<10;x++){
		num = float.Parse(ler.ReadLine());
		Console.WriteLine(num*num);
	}
	}
}
