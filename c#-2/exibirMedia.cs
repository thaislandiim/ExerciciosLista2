using System;

class exibirMedia 
{
  public static void Main (string[] args) 
  {
    double n1, n2, n3, n4, media, total;

    Console.WriteLine("Digite primeira nota");
    n1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Digite segunda nota");
    n2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Digite terceira nota");
    n3 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Digite quarta nota");
    n4 = Convert.ToInt32(Console.ReadLine());

    total = n1 + n2 + n3 + n4;
    media = total / 4;

    if(media >=6) {
      Console.WriteLine("Você foi aprovado");
    }
    else if (media >= 4) {
      Console.WriteLine("Você está de recuperação");
    }
    else {
      Console.WriteLine("Você foi reprovado");
    }
  }
}