using System;

namespace CadastroPessoas
{
   class Program 
   {
    static void Main(string[] args)
    {
      PessoaFisica pfMetodo = new PessoaFisica();

      PessoaFisica novaPf = new  PessoaFisica();
      Endereco novoEndPf = new Endereco();


      novaPf.nome = "Bruno";
      novaPf.dataNascimento = new DateTime(2004,09,11); 
      novaPf.cpf = "1442681079";
      novaPf.rendimento = 3000.734f;
      
      novoEndPf.logradouro = "Rua Carlos Sherer";
      novoEndPf.numero = 603;
      novoEndPf.complemento = "Terreno de esquina";
      novoEndPf.enderecoComercial = false;

      novaPf.endereco = novoEndPf;


      // Console.WriteLine($"Nome: {novaPf.nome}");
      // Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}");  
      // Console.WriteLine($"{pfMetodo.ValidarDataNascimento(novaPf.dataNascimento)}"); 

//       Console.WriteLine(@$"
// Nome: {novaPf.nome}      
// CPF: {novaPf.cpf}     
// Endereço: {novaPf.endereco.logradouro}, {novoEnd.numero}      
// ");  
 
      PessoaJuridica pjMetodos = new PessoaJuridica();

      PessoaJuridica novaPj = new PessoaJuridica();
      Endereco novoEndPj = new Endereco();
      
      novaPj.nome = "Nova pessoa Física";
      novaPj.cnpj = "34567890000199";
      novaPj.razaoSocial = "Razão social nova Pessoa Juridica";
      novaPf.rendimento = 15000f;

      novoEndPj.logradouro = "Rua Carlos Sherer";
      novoEndPj.numero = 603;
      novoEndPj.complemento = "Terreno de esquina";
      novoEndPj.enderecoComercial = false;

      novaPj.endereco = novoEndPj;      
       
      Console.WriteLine(@$"
Nome: {novaPj.nome}
CNPJ:  {novaPj.cnpj}      
Razão Social: {novaPj.razaoSocial}      
CNPJ valido: {pjMetodos.ValidarCnpj(novaPj.cnpj)}  
");
    }
   }
}