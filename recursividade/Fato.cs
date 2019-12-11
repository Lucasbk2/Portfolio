using System;

class Program{
	 public static int Fato(int num){
		 if(num<= 1){
				return 1;
		 }
			return num*Fato(num-1);
	 }
}