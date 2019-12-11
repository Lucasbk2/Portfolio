class Pessoa{
  private string nome;
  private int idade;

  public string getNome(){
    return nome;
  }

  public int getIdade(){
    return idade;
  }

  //Acesso  TipoRetorno  Nome(Parametros)
  public string maisVelho(int id, string n){
    if(idade > id)
      return nome;
    else
      return n;
  }
  //Acesso  TipoRetorno  Nome(  Parametros )
  public Pessoa maisVelho(Pessoa outra){
    if(idade > outra.idade)
      return this;
    
    return outra;
  }

  //Construtor da classe:
  public Pessoa(){
    nome = "Sem nome ainda!";
    idade = 0;
  }
  public Pessoa(string n, int i){
    nome = n;
    idade = i;
  }

}