using System;

namespace CadastroPessoas
{
   class Program 
   {
    static void Main(string[] args)
    {
      PessoaFisica pfMetodo = new PessoaFisica();

      PessoaFisica novaPf = new  PessoaFisica();
      Endereco novoEnd = new Endereco();


      novaPf.nome = "Bruno";
      novaPf.dataNascimento = new DateTime(2004,09,11); 
      novaPf.cpf = "1442681079";
      novaPf.rendimento = 3000.734f;
      
      novoEnd.logradouro = "Rua Carlos Sherer";
      novoEnd.numero = 603;
      novoEnd.complemento = "Terreno de esquina";
      novoEnd.enderecoComercial = false;

      novaPf.endereco = novoEnd;


      // Console.WriteLine($"Nome: {novaPf.nome}");
      // Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}");  
      // Console.WriteLine($"{pfMetodo.ValidarDataNascimento(novaPf.dataNascimento)}"); 

      Console.WriteLine(@$"
Nome: {novaPf.nome}      
CPF: {novaPf.cpf}     
Endereço: {novaPf.endereco.logradouro}, {novoEnd.numero}      
");  



    }
   }
}