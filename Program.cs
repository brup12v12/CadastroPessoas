namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();


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
                        Console.Clear();
                        string? opcaoPf;
                        PessoaFisica pfMetodo = new PessoaFisica();

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(@$"
======================================================
|        Escolha uma das opções abaixo:              |
|                                                    |
|        1. Cadastrar uma Pessoa Física              |
|        2. Listar Pessoas Físicas                   |
|                                                    |
|        0. Voltar ao menu anterior                  |
======================================================
");
                            Console.ResetColor();
                            opcaoPf = Console.ReadLine();

                            switch (opcaoPf)
                            {
                                case "1":

                                    PessoaFisica novaPf = new PessoaFisica();
                                    Endereco novoEndPf = new Endereco();

                                    Console.WriteLine($"Digite o nome da pessoa que deseja ser cadastrada:");
                                    novaPf.nome = Console.ReadLine();

                                    // bool dataValida;
                                    // do
                                    // {
                                    //     Console.WriteLine($"Digite a data de nascimento Ex: AAAA-MM-DD");
                                    //     DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                                    //     dataValida = pfMetodo.ValidarDataNascimento(dataNascimento);

                                    //     if (dataValida)
                                    //     {
                                    //         novaPf.dataNascimento = dataNascimento;
                                    //     }
                                    //     else
                                    //     {
                                    //         Console.ForegroundColor = ConsoleColor.Red;
                                    //         Console.WriteLine($"Data inválida, por favor digite uma data válida(maior de 18 anos de idade)");
                                    //         Console.ResetColor();
                                    //     }
                                    // } while (dataValida == false);


                                    Console.WriteLine("Digite o CPF ");
                                    novaPf.cpf = Console.ReadLine();

                                    Console.WriteLine($"Digite sua renda mensal(apenas números):");
                                    novaPf.rendimento = float.Parse(Console.ReadLine());


                                    // Console.WriteLine($"Digite o logradouro:");
                                    // novoEndPf.logradouro = Console.ReadLine();

                                    // Console.WriteLine($"Digite o número do endereço:");
                                    // novoEndPf.numero = int.Parse(Console.ReadLine());

                                    // Console.WriteLine($"Digite o complemento(aperte ENTER para pular):");
                                    // novoEndPf.complemento = Console.ReadLine();


                                    // Console.WriteLine($"Este endereço é comercial? S/N ");
                                    // string enderecoComercial = Console.ReadLine().ToUpper();

                                    // if (enderecoComercial == "S")
                                    // {
                                    //     novoEndPf.enderecoComercial = true;
                                    // }
                                    // else
                                    // {
                                    //     novoEndPf.enderecoComercial = false;
                                    // }

                                    // novaPf.endereco = novoEndPf;

                                    listaPf.Add(novaPf);



                                    //ATIVIDADE TXT

                                    // StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt");
                                    // sw.Write($"Nome: {novaPf.nome}");
                                    // sw.Close();

                                    //OU:

                                    using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                                    {
                                        sw.Write($"{novaPf.nome}");
                                    }



                                    Console.WriteLine($"Digite 'Enter' para continuar");
                                    Console.ReadLine();


                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Cadastro realizado com sucesso!");
                                    Console.ResetColor();

                                    pfMetodo.VerificaPastaArquivo(pfMetodo.caminho);
                                    pfMetodo.Inserir(novaPf);


                                    break;

                                case "2":

                                    Console.Clear();

                                    //                                     if (listaPf.Count > 0)
                                    //                                     {
                                    //                                         foreach (PessoaFisica item in listaPf)
                                    //                                         {
                                    //                                             Console.WriteLine(@$"
                                    // Nome: {item.nome}      
                                    // CPF: {item.cpf}     
                                    // Endereço: {item.endereco?.logradouro}, {item.endereco?.numero}
                                    // Taxa adicional de imposto: {pfMetodo.PagarImposto(item.rendimento).ToString("C")}     
                                    // ");
                                    //                                         }

                                    //                                         Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    //                                         Console.WriteLine($"Pressione 'ENTER' para continuar.");
                                    //                                         Console.ReadLine();
                                    //                                         Console.ResetColor();
                                    //                                     }
                                    //                                     else
                                    //                                     {
                                    //                                         Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    //                                         Console.WriteLine($"Nenhuma pessoa cadastrada ainda!");
                                    //                                         Console.ResetColor();
                                    //                                         Thread.Sleep(3000);
                                    //                                     }



                                    //                         CONTINUAÇÂO DA ATIVIDADE
                                    // using (StreamReader sr = new StreamReader($"(nome do arquivo que deseja ser lido)"))
                                    // {
                                    //     string linha;
                                    //     while ((linha = sr.ReadLine()) != null)                                        
                                    //     {
                                    //      Console.WriteLine($"{linha}");                                         
                                    //     }
                                    // }

                                    // Console.WriteLine($"Digite ENTER para continuar");
                                    // Console.ReadLine();

                                    List<PessoaFisica> listaPF = pfMetodo.Ler();

                                    if (listaPF.Count > 0)
                                    {
                                        foreach (PessoaFisica cadaPf in listaPF)
                                        {

                                            Console.WriteLine(@$"
Nome: {cadaPf.nome}      
CPF: {cadaPf.cpf}     
Rendimento: {cadaPf.rendimento}    
");

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"A lista está vazia!");

                                    }

                                    Console.WriteLine($"Digite ENTER para continuar");
                                    Console.ReadLine();

                                    break;

                                case "0":
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine($"Opção inválida, escolha uma das opções citadas anteriormente.");
                                    Console.ResetColor();
                                    Thread.Sleep(3000);
                                    break;
                            }
                        } while (opcaoPf != "0");

                        break;








                    case "2":

                        string? opcaoPj;
                        PessoaJuridica pjMetodos = new PessoaJuridica();

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(@$"
======================================================
|        Escolha uma das opções abaixo:              |
|                                                    |
|        1. Cadastrar uma Pessoa Júridica            |
|        2. Listar Pessoas Jurídicas                 |
|                                                    |
|        0. Voltar ao menu anterior                  |
======================================================
");
                            Console.ResetColor();
                            opcaoPj = Console.ReadLine();

                            switch (opcaoPj)
                            {

                                case "1":

                                    PessoaJuridica novaPj = new PessoaJuridica();
                                    Endereco novoEndPj = new Endereco();

                                    Console.WriteLine($"Digite o nome da pessoa que deseja ser cadastrada:");
                                    novaPj.nome = Console.ReadLine();

                                    bool cnpjValido;
                                    do
                                    {
                                        Console.WriteLine($"Digite o CNPJ: ");
                                        string? cnpj = Console.ReadLine();

                                        cnpjValido = pjMetodos.ValidarCnpj(cnpj);

                                        if (cnpjValido)
                                        {
                                            novaPj.cnpj = cnpj;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"CNPJ inválido, por favor digite uma CNPJ válido(Ex: XXXXXXXX0001XX)");
                                            Console.ResetColor();
                                        }

                                    } while (cnpjValido == false);

                                    Console.WriteLine($"Digite a razão social:");
                                    novaPj.razaoSocial = Console.ReadLine();

                                    Console.WriteLine($"Digite a renda mensal da pessoa(apenas números):");
                                    novaPj.rendimento = float.Parse(Console.ReadLine());

                                    // Console.WriteLine($"Digite o logradouro:");
                                    // novoEndPj.logradouro = Console.ReadLine();

                                    // Console.WriteLine($"Digite o número do endereço:");
                                    // novoEndPj.numero = int.Parse(Console.ReadLine());

                                    // Console.WriteLine($"Digite um complemento(Pressione 'ENTER' para pular):");
                                    // novoEndPj.complemento = Console.ReadLine();
                                    // ;

                                    // Console.WriteLine($"O endereço é comercial?: S/N");
                                    // string enderecoComercial = Console.ReadLine().ToUpper();

                                    // if (enderecoComercial == "S")
                                    // {
                                    //     novoEndPj.enderecoComercial = true;
                                    // }
                                    // else
                                    // {
                                    //     novoEndPj.enderecoComercial = false;
                                    // }

                                    // novaPj.endereco = novoEndPj;

                                    listaPj.Add(novaPj);

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Cadastro realizado com sucesso!");
                                    Console.ResetColor();



                                    pjMetodos.VerificaPastaArquivo(pjMetodos.caminho);
                                    pjMetodos.Inserir(novaPj);

                                    break;

                                case "2":

                                    Console.Clear();

                                    if (listaPj.Count > 0)
                                    {


                                        foreach (PessoaJuridica cadaitem in listaPj)
                                        {

                                            Console.WriteLine(@$"
Nome: {cadaitem.nome}
CNPJ:  {cadaitem.cnpj}      
Razão Social: {cadaitem.razaoSocial}      
CNPJ valido: {(pjMetodos.ValidarCnpj(cadaitem.cnpj) ? "Válido" : "Inválido")} 
Taxa adicional de imposto: {pjMetodos.PagarImposto(cadaitem.rendimento).ToString("C")} 
");

                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine($"Aperte 'ENTER' para continuar.");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine($"Nenhuma pessoa cadastrada ainda!");
                                        Console.ResetColor();
                                        Thread.Sleep(3000);
                                    }







                                         List<PessoaJuridica> listPj = pjMetodos.Ler();

                                    if (listPj.Count > 0)
                                    {
                                        foreach (PessoaJuridica cadaPj in listPj)
                                        {
                                            Console.WriteLine(@$"
Nome : {cadaPj.nome}
Razão Social : {cadaPj.razaoSocial}
CNPJ : {cadaPj.cnpj}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Lista vazia!");

                                    }

                                    break;
                                case "0":
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Opcão inválida, por favor digite uma opção válida!");
                                    Console.ResetColor();

                                    break;
                            }

                            //string cnpjValido = pjMetodos.ValidarCnpj(novaPj.cnpj) ? "Válido" : "Inválido";

                        } while (opcaoPj != "0");

                        break;

                    case "0":

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"Obrigado pela prefêrencia!");
                        Console.ResetColor();

                        BarraCarregamento("Finalizando ");

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida, escolha uma das opções citadas anteriormente.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
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