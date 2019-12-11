using System;

class Carro{
  private string modelo;
  private string cor;
  private int ano;

  public Carro(){
    modelo = "Não Definido";
    cor = "Branca";
    ano = 2000;    
  }

  public Carro(string mod, string c, int a){
    modelo = mod;
    cor = c;
    ano = a;    
  }

  public Carro(string mod){
    modelo = mod;
    cor = "Branca";
    ano = 1990;        
  }

  public string getModelo(){
    return modelo;
  }
  public string getCor(){
    return cor;
  }
  public int getAno(){
    return ano;
  }

  public void setModelo(string m){
    modelo = m;
  }

  public void setCor(string c){
    switch(c){
      case "Branca": case "Preta": case "Prata":
         cor = c;
         break;
      default:
         Console.WriteLine("Cor Inválida!");
         break;
    }  
  }

  public void setAno(int a){
    if(a >= 1990){
      ano = a;
    }
    else{
      Console.WriteLine("Ano Inválido!");
    }
  }

  public string FichaCompleta(){
     string ficha = string.Format("{0} / {1} / {2} ", modelo, cor, ano);
     return ficha;
  }



}

class MainClass {
  public static void Main (string[] args) {
    Carro seinao = new Carro();
    Carro fusca = new Carro("Fusca", "Branca", 2017);

    Console.WriteLine("{0}", seinao.FichaCompleta());
    Console.WriteLine("{0}", fusca.FichaCompleta());
  }
}