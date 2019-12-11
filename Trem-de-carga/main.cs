/*
Crie um programa em C# para representar um trem de carga. Cada trem possui apenas 3 vagões, a informação da sua velocidade e a carga máxima suportada pela locomotiva. Cada vagão possui uma descrição do material presente e a quantidade carregada (em toneladas). 
  Devem ser criadas classes para a representação do trem e dos vagões.
  Crie as classes e pelo menos 2 atributos de tipos diferentes em cada classe. 
  Crie 1 método construtor com parâmetros e um sem parâmetros para cada classe. 
  Crie pelo menos 1 par de métodos get/set para cada classe.
  Crie o método CargaRestante que retorna a quantidade de carga que o trem ainda consegue suportar com bascarga carregada em seus vagões. 
  Crie o método bool TransferirCargaPara(Trem destino) que permite transferir a carga de um trem para omantendo a quantidade carregada em cada vagão. Só deve ser possível realizar a transferência se o trem de desestiver vazio e tiver capacidade para receber a carga. O método deve indicar como retorno se a transferênciarealizada com sucesso ou não.
  Crie um método main para fazer uso da classe criada com pelo menos 2 objetos Trem e uso de 2 dos méto(diferentes de get/set) criados.
trem = new Tre,(v1,v2,v3)
*/
using System;
class MainClass {
  public static void Main (string[] args) {
		Vagoes vagao1 = new Vagoes(110.55f,100.0f,"Carvão");
		Vagoes vagao2 = new Vagoes(50.45f,150.0f,"Pessoa");
		Vagoes vagao3 = new Vagoes(90.0f,190.0f,"Metal");
		Vagoes[] vag = new Vagoes [] {vagao1,vagao2,vagao3};
		Trem trem1 = new Trem("Cambada",3,1110.00f,vag);
		
		Console.WriteLine(trem1.getNome()+" "+trem1.getQuantidadeVagoes());
		Console.WriteLine(trem1.getVagoes(0));
		trem1.CargaRestante();
		
	}
}
