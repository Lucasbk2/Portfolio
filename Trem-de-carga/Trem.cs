using System;
class Trem{
	private string nome;	
	private int quantidadeVagoes;
	private float cargaMaxima;
	private Vagoes[] vagoes;
	//Metódos get / set
	public string getNome(){
	return nome;
	}
	public int getQuantidadeVagoes(){
		return quantidadeVagoes;
	}
	public float getCargaMaxima(){
		return cargaMaxima;
	}

public string getVagoes(int vagao){
	return vagoes[vagao].getMaterialCarga(); 

}
	public void setNome(string nome){
		this.nome = nome;
			}
	public void setQuantidadeVagoes(int qV){
		this.quantidadeVagoes= qV;
	}
	//Construtores
	public Trem(string n , int qV,float Cv,Vagoes[] vag){
		this.nome = n;
		this.quantidadeVagoes = qV;
		this.cargaMaxima = Cv;
		this.vagoes = vag;
	}
	public Trem(){
		this.nome = "padrão";
		this.quantidadeVagoes = 0;	
	}
	//Metódos usuais
	public void CargaRestante(){
	
	float carga = vagoes[0].getCargaAtual() + vagoes[0].getCargaAtual() + vagoes[2].getCargaAtual();
	if (carga >= cargaMaxima){
		Console.WriteLine("O trem não consegue aguentar a carga");
	}
	 Console.WriteLine("O trem ainda aguenta {0} de carga",cargaMaxima-carga);
	}

}