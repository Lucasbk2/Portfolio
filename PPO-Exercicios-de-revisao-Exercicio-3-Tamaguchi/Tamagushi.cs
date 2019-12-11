class Tamagushi{
	private string nome;
	private int fome;
	private int saude; 
	private int idade;

	public Tamagushi(string nome){
		this.nome = nome;
		this.fome = 100;
		this.saude = 100;
		this.idade = 0;
	}

	public string getNome(){
		return nome;
	}
	public void setNome(string variavel){
		this.nome = variavel;
	}
	public int getFome(){
		return fome;
	}
	public void setFome(int variavel){
		this.fome = variavel;
	}
	public int getSaude(){
		return saude;
	}
	public void setSaude(int variavel){
		this.saude = variavel;
	}
	public int getIdade(){
		return idade;
	}
	public void setIdade(int variavel){
		this.idade = variavel;
	}
	

}