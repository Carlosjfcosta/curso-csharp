//Perguntas Rápidas
//1. cofre é private get e private get (não pode ver a senha e nem alterar a senha), o caixa eletronico e get e private set (pode ver o saldo, etc porém não pode alterar o saldo), e o saldo é o get que é possivel visualizar do caixa eletronico
//2. o programa pode ler não pode escrever, apenas pode escrever se atender os requisitos para escrever dentro da class
//3. quando o programador for utilizar o código, ele não pode setar algumas coisas dependendo do código para manter a lógica, por exemplo: ao setar um senha do cofre o programador não pode alterar a senha, apenas realizar tentativas de abrir o cofre
//4. O programa deveria barrar essa adição de notas e ter que passar pelo AdicionarNota sempre, no AdicionarNota deve ser implementado uma condição de aceitar apenas notas de 0 a 10.


//Correções Perguntas Rápidas
//1. Eu posso alterar o saldo no caixa eletrônico porém só vai ser possível após realizar a condição dentro da classe, não é possível alterar no saldo com comando no código como (Saldo.Set(50000)).
// cofre = private; caixa eletrônico = get, private set; saldo na tela = public.
//2. 
//3. 
//4. não usa aluno.Notas, caso faça isso irá mostrar todas as notas do aluno criado, não entendi mais a pergunta


//Correções Perguntas Rápidas
//Conferência: letra b
//4. O notas pode ser public get e private set, da pra ve as notas em lista porém não é possível alterar ou adicionar as notas pelo código, apenas dentro da classe ao passar pela condição. Ou o Notas pode ser private, apenas sendo alterado no class.


// //Exercício 1

// Cofre cofre = new Cofre();

// while (true)
// {
// string tentativa = PerguntaString("Qual a senha do cofre? ");

// if (cofre.Abrir(tentativa))
// {
//     Console.WriteLine("O cofre abriu");
//     break;
// }
// else
// {
//     Console.WriteLine("Senha errrada, tente novamente");
// }
// }

// // Console.WriteLine(cofre.senha);

// //======= MÉTODOS =======

// string PerguntaString(string pergunta)
// {
//     Console.Write(pergunta);

//     string entrada = Console.ReadLine() ?? "";
//     while (string.IsNullOrWhiteSpace(entrada))
//     {
//         Console.WriteLine("Entrada inválida");
//         Console.Write("Digite novamente a entrada correta: ");
//         entrada = Console.ReadLine() ?? "";
//     }

//     return entrada;
// }


// //======= CLASSES =======
// class Cofre
// {
//     private string senha = "1234";

//     public bool Abrir(string tentativa)
//     {
//         if (tentativa == senha)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
// }

// //Exercício 2

//     string titular = PerguntaString("Qual o nome do Titular da conta? ");
//     decimal saldoInicial = LerNumeroDecimal("Qual o valor do saldo inicial? ");

//     ContaBancaria novaConta = new ContaBancaria(titular , saldoInicial);
    
//     OperacaoDeposito(50);
//     OperacaoDeposito(-50);
//     OperacaoSaque(30);
//     OperacaoSaque(500);
//     OperacaoSaque(novaConta.Saldo);

//     // novaConta.Saldo = 999;


// //======= MÉTODOS =======

// decimal LerNumeroDecimal(string pergunta)
// {
//     Console.Write(pergunta);

//     decimal numero;
//     while (!decimal.TryParse(Console.ReadLine() ?? "", out numero))
//     {
//         Console.WriteLine("Entrada inválida");
//         Console.Write("Digite novamente a entrada correta: ");
//     }

//     return numero;
// }

// string PerguntaString(string pergunta)
// {
//     Console.Write(pergunta);

//     string entrada = Console.ReadLine() ?? "";
//     while (string.IsNullOrWhiteSpace(entrada))
//     {
//         Console.WriteLine("Entrada inválida");
//         Console.Write("Digite novamente a entrada correta: ");
//         entrada = Console.ReadLine() ?? "";
//     }

//     return entrada;
// }

// void OperacaoDeposito(decimal deposito)
// {
//     if (novaConta.Depositar(deposito))
//     {
//         Console.WriteLine($"Depósito de {deposito:C}: realizado - saldo: {novaConta.Saldo:C}");
//     }
//     else
//     {
//         Console.WriteLine($"Operação não realizada - saldo: {novaConta.Saldo:C}");
//     }
// }

// void OperacaoSaque(decimal saque)
// {
//     if (novaConta.Sacar(saque))
//     {
//         Console.WriteLine($"Saque de {saque:C}: realizado - saldo: {novaConta.Saldo:C}");
//     }
//     else
//     {
//         Console.WriteLine($"Operação não realizada - saldo: {novaConta.Saldo:C}");
//     }
// }

// //======= CLASSES =======

// class ContaBancaria
// {
//     public string Titular { get; private set; }
//     public decimal Saldo { get; private set; }

//     public ContaBancaria(string titular, decimal saldo)
//     {
//         Titular = titular;
//         Saldo = saldo;
//     }

//     public bool Depositar(decimal deposito)
//     {
//         if (deposito <= 0)
//         {
//             return false;
//         }
//         else
//         {
//             Saldo += deposito;
//             return true;
//         }
//     }
//    public bool Sacar(decimal saque)
//     {
//         if (saque > Saldo)
//         {
//             return false;
//         }
//         else if (saque <= 0)
//         {
//             return false; 
//         }
//         else
//         {
//             Saldo -= saque;
//             return true;
//         }
//     }
// }

//Exercício 3

List<Produto> produtos = new List<Produto>();

while (true)
{
    string nomeNovoProduto = PerguntaString("Digite o nome do produto, ou 'fim' para encerrar a lista: ");
    if ((nomeNovoProduto).ToLower() == "fim")
    {
        break;
    }

    int quantidadeNovoProduto = LerNumeroInt("Digite a quantidade do produto: ");

    decimal precoNovoProduto = LerNumeroDecimal("Digite o preço do produto: ");

    if (precoNovoProduto <= 0)
    {
        Console.WriteLine("Esse produto não interessa (valor igual a zero ou negativo), próximo!");
        continue;
    }
    else if (quantidadeNovoProduto < 0)
    {
        Console.WriteLine("Esse produto não interessa (quantidade menor que zero), próximo!");
        continue; 
    }
    else
    {   
        Produto novoProduto = new Produto(nomeNovoProduto, quantidadeNovoProduto, precoNovoProduto);
        produtos.Add(novoProduto);        
    }
}

decimal somaValorTotal = 0;
foreach (Produto produto in produtos)
{
    Console.WriteLine($"Produto: {produto.Nome} - Quantidade: {produto.Quantidade} - Preço: {produto.Preco:C} - Valor Total do Produto: {produto.ValorTotal():C}");
    somaValorTotal += produto.ValorTotal();
}
Console.WriteLine($"O valor total de todos os produtos é: {somaValorTotal:C}");


//======= MÉTODOS =======

int LerNumeroInt(string pergunta)
{
    Console.Write(pergunta);

    int numero;
    while (!int.TryParse(Console.ReadLine() ?? "", out numero))
    {
        Console.WriteLine("Entrada inválida");
        Console.Write("Digite novamente a entrada correta: ");
    }

    return numero;
}

decimal LerNumeroDecimal(string pergunta)
{
    Console.Write(pergunta);

    decimal numero;
    while (!decimal.TryParse(Console.ReadLine() ?? "", out numero))
    {
        Console.WriteLine("Entrada inválida");
        Console.Write("Digite novamente a entrada correta: ");
    }

    return numero;
}

string PerguntaString(string pergunta)
{
    Console.Write(pergunta);

    string entrada = Console.ReadLine() ?? "";
    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Entrada inválida");
        Console.Write("Digite novamente a entrada correta: ");
        entrada = Console.ReadLine() ?? "";
    }

    return entrada;
}

//======= CLASSES =======
class Produto
{
    public string Nome { get; private set; }
    public int Quantidade { get; private set; }
    public decimal Preco { get; private set; }

    public Produto(string nome, int quantidade, decimal preco)
    {
        Nome = nome; 
        if (quantidade >= 0 && preco > 0)
        {   
        Quantidade = quantidade;
        Preco = preco;            
        }
    }

    public decimal ValorTotal()
    {
        return Quantidade * Preco;
    }
}

//Revisão Rápida Módulo 9
//1. b
//2. b
//3. b