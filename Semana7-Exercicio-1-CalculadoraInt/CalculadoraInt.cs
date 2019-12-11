using System.Collections.Generic;
using System.Linq;

public class CalculadoraInt{


public double Soma(double numeroA, double numeroB)
{
  return numeroA + numeroB;
}

public double Subtracao(double numeroA, double numeroB)
{
  return numeroA - numeroB;
}

public double Multiplicacao(double numeroA, double numeroB)
{
  return numeroA * numeroB;
}

public double Divisao(double numeroA, double numeroB)
{
  return numeroA / numeroB;
}


public static int SomaEstatica(int numeroA, int numeroB)
{
  return numeroA + numeroB;
}

public int Maior(int numeroA, int numeroB)
{
  List<int> listaNum = new List<int>();
  listaNum.Add(numeroA);
  listaNum.Add(numeroB);

  return listaNum.Max();
}

// public double Divisao(double numeroA, double numeroB)
// {
//   return numeroA / numeroB;
// }

}