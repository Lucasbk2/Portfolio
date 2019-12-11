using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Qual o nome do tamagushi?");
		string nome = Console.ReadLine();
		Tamagushi pet = new Tamagushi(nome);
		Random rdn= new Random();
		Console.WriteLine(rdn.Next(3,30));
		int humor = 100;
		while(pet.getIdade() <100 && humor > 0 && pet.getFome() > 0 && pet.getSaude() > 0){
			Console.WriteLine("{0} : Idade:{1} Fome:{2} Saude{3} Humor:{4}",pet.getNome(),pet.getIdade(),pet.getFome(),pet.getSaude(),humor);
			Console.WriteLine("Deseja dar Comida-1 ou dar Rivotril-2");
			int decisao = int.Parse(Console.ReadLine());
			if(decisao == 1){
				int fome = pet.getFome() + 30;
				if (fome > 100){
					fome = 100;
				}
				pet.setFome((fome));
				Console.WriteLine(pet.getNome()+" Alimentado.");
			} else if(decisao == 2){
				int saude = pet.getSaude() + 30;
				
				if(saude > 100){
					saude = 100;
				}
				pet.setSaude((saude));
				Console.WriteLine(pet.getNome()+" Drogado.");
			}
			else{
				Console.WriteLine("Nenhuma ação realizada");
			}
			humor = (pet.getFome() + pet.getSaude()) / 2;
			int sau = pet.getSaude() + rdn.Next(-30,-5);
			int fom = pet.getSaude() + rdn.Next(-30,-5);
			pet.setSaude((sau));
			pet.setFome((fom));


		}
		Console.WriteLine("O Tamagushi morreu ;(");

  }
}