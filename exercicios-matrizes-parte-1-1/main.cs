using System;

class MainClass {
  public static void Main (string[] args) {
    int[,] matriz = new int[2,5];
		for (int x=0;x<2;x++){
			for(int y=0;y<5;y++){
				Console.WriteLine("Digite o {0}º número da {1}º parte da matriz",y+1,x+1);
				matriz[x,y] =int.Parse(Console.ReadLine());
			
		}
		}
		for (int x=0;x<2;x++){
			for(int y=0;y<5;y++){
					Console.WriteLine("O {0}º é valor da {1}º parte da matriz",matriz[x,y],x+1);
			}
		}
  }
}