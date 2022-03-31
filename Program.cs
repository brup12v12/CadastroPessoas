using System;

namespace CadastroPessoas
{
   class Program 
   {
    static void Main(string[] args)
    {
      PessoaFisica novaPf = new  PessoaFisica();

      novaPf.nome = "Bruno";
      Console.WriteLine($"Nome: {novaPf.nome}");
         
    }
   }
}