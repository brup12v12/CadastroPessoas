using System;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@$"

===============================================
|                Bem vindo!                   |
|                   ao                        |
|       Sistema de Cadastro de Pessoas        |
|           Físicas ou Juridícas              |
===============================================
");
            BarraCarregamento("Carregando ");

            string? opcao;
            do
            {

                Console.WriteLine(@$"
  
=============================================
|        Escolha uma das opções abaixo:     |
|                                           |
|        1. Pessoa Física                   |
|        2. Pessoa Jurídica                 |
|                                           |
|        0. Sair                            |
=============================================
");
               
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        PessoaFisica pfMetodo = new PessoaFisica();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();


                        novaPf.nome = "Bruno";
                        novaPf.dataNascimento = new DateTime(2004, 09, 11);
                        novaPf.cpf = "1442681079";
                        novaPf.rendimento = 3000.734f;

                        novoEndPf.logradouro = "Rua Carlos Sherer";
                        novoEndPf.numero = 603;
                        novoEndPf.complemento = "Terreno de esquina";
                        novoEndPf.enderecoComercial = true;

                        novaPf.endereco = novoEndPf;

                        Console.WriteLine(@$"
Nome: {novaPf.nome}      
CPF: {novaPf.cpf}     
Endereço: {novaPf.endereco.logradouro}, {novoEndPf.numero}      
");

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Aperte 'ENTER' para continuar.");
                        Console.ReadLine();
                        Console.ResetColor();

                        break;

                    case "2":

                        PessoaJuridica pjMetodos = new PessoaJuridica();

                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        novaPj.nome = "Nova pessoa Juridíca";
                        novaPj.cnpj = "34567890000199";
                        novaPj.razaoSocial = "Razão social nova Pessoa Juridica";
                        novaPj.rendimento = 15000f;

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

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Aperte 'ENTER' para continuar.");
                        Console.ReadLine();
                        Console.ResetColor();


                        break;

                    case "0":
                        Console.WriteLine($"Obrigado pela prefêrencia!:)");

                        BarraCarregamento("Finalizando ");

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida, escolha uma das opções citadas anteriormente.");
                        Console.ResetColor();
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;
                }

            } while (opcao != "0");


            static void BarraCarregamento(string txtCarregamento)
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{txtCarregamento}");
                Thread.Sleep(500);

                for (var contador = 0; contador < 5; contador++)
                {
                    Console.Write($" .");
                    Thread.Sleep(500);

                }

                Console.ResetColor();
                Console.Clear();
            }

        }
    }
}