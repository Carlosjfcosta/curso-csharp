//Perguntas Rápidas
//1. b
//2. b
//3. b
//4. b

// //Exercício 1

// AutoBombaTanque novaBomba = new AutoBombaTanque("ABT-01", 6000); 

// Console.WriteLine($"A nova bomba tem o prefixo: {novaBomba.Prefixo}; e capacidade em litros de: {novaBomba.LitrosDeAgua}");

// //======= CLASSES =======

// class Viatura
// {
//     public string Prefixo { get; private set; }

//     public Viatura(string prefixo)
//     {
//         Prefixo = prefixo;
//     }
// }

// class AutoBombaTanque : Viatura
// {
//     public int LitrosDeAgua { get; private set; }

//     public AutoBombaTanque (string prefixo, int litrosDeAgua) : base(prefixo)
//     {
//         LitrosDeAgua = litrosDeAgua;
//     }
// }


// //Exercício 2

// List<Produto> produtos = new List<Produto>();

// while (true)
// {
//     string nomeNovoProduto = PerguntaString("Digite o nome do produto, ou 'fim' para encerrar a lista: ");
//     if ((nomeNovoProduto).ToLower() == "fim")
//     {
//         break;
//     }

//     int quantidadeNovoProduto = LerNumeroInt("Digite a quantidade do produto: ");

//     decimal precoNovoProduto = LerNumeroDecimal("Digite o preço do produto: ");

//     if (precoNovoProduto <= 0)
//     {
//         Console.WriteLine("Esse produto não interessa (valor igual a zero ou negativo), próximo!");
//         continue;
//     }
//     else if (quantidadeNovoProduto < 0)
//     {
//         Console.WriteLine("Esse produto não interessa (quantidade menor que zero), próximo!");
//         continue; 
//     }
//     else
//     {   
//         Produto novoProduto = new Produto(nomeNovoProduto, quantidadeNovoProduto, precoNovoProduto);
//         produtos.Add(novoProduto);        
//     }
// }

// decimal somaValorTotal = 0;
// foreach (Produto produto in produtos)
// {
//     Console.WriteLine(produto);
//     somaValorTotal += produto.ValorTotal();
// }
// Console.WriteLine($"O valor total de todos os produtos é: {somaValorTotal:C}");


// //======= MÉTODOS =======

// int LerNumeroInt(string pergunta)
// {
//     Console.Write(pergunta);

//     int numero;
//     while (!int.TryParse(Console.ReadLine() ?? "", out numero))
//     {
//         Console.WriteLine("Entrada inválida");
//         Console.Write("Digite novamente a entrada correta: ");
//     }

//     return numero;
// }

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

// //======= CLASSES =======
// class Produto
// {
//     public string Nome { get; private set; }
//     public int Quantidade { get; private set; }
//     public decimal Preco { get; private set; }

//     public Produto(string nome, int quantidade, decimal preco)
//     {
//         Nome = nome; 
//         if (quantidade >= 0 && preco > 0)
//         {   
//         Quantidade = quantidade;
//         Preco = preco;            
//         }
//     }

//         public override string ToString()
//     {
//         return $"Produto: {Nome} - Quantidade: {Quantidade} - Preço: {Preco:C} - Valor Total do Produto: {ValorTotal():C}";
//     }

//     public decimal ValorTotal()
//     {
//         return Quantidade * Preco;
//     }
// }


//Exercício 3

string titularContaBancaria = PerguntaString("Qual o nome do Titular da conta bancária? ");
decimal saldoInicialContaBancaria = LerNumeroDecimal("Qual o valor do saldo inicial? ");

string titularContaEspecial = PerguntaString("Qual o nome do Titular da conta especial? ");
decimal saldoInicialContaEspecial = LerNumeroDecimal("Qual o valor do saldo inicial? ");
decimal limiteContaEspecial = LerNumeroDecimal("Qual o valor do limite da conta? ");

ContaBancaria novaContaBancaria = new ContaBancaria(titularContaBancaria, saldoInicialContaBancaria);
ContaEspecial novaContaEspecial = new ContaEspecial(titularContaEspecial, saldoInicialContaEspecial, limiteContaEspecial);

OperacaoSaque(novaContaBancaria, 120);

OperacaoSaque(novaContaEspecial, 120);
OperacaoSaque(novaContaEspecial, 40);
OperacaoSaque(novaContaEspecial, 30);
OperacaoDeposito(novaContaEspecial, 70);

// novaConta.Saldo = 999;


//======= MÉTODOS =======

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

void OperacaoDeposito(ContaBancaria conta, decimal deposito)
{
    if (conta.Depositar(deposito))
    {
        Console.WriteLine($"{conta} - Depósito de {deposito:C}: realizado - saldo: {conta.Saldo:C}");
    }
    else
    {
        Console.WriteLine($"{conta} - Operação não realizada - saldo: {conta.Saldo:C}");
    }
}

void OperacaoSaque(ContaBancaria conta, decimal saque)
{
    if (conta.Sacar(saque))
    {
        Console.WriteLine($"{conta} - Saque de {saque:C}: realizado - saldo: {conta.Saldo:C}");
    }
    else
    {
        Console.WriteLine($"{conta} - Operação não realizada - saldo: {conta.Saldo:C}");
    }
}

//======= CLASSES =======

class ContaBancaria
{
    public string Titular { get; private set; }
    public decimal Saldo { get; protected set; }

    public ContaBancaria(string titular, decimal saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public bool Depositar(decimal deposito)
    {
        if (deposito <= 0)
        {
            return false;
        }
        else
        {
            Saldo += deposito;
            return true;
        }
    }
    public virtual bool Sacar(decimal saque)
    {
        if (saque > Saldo)
        {
            return false;
        }
        else if (saque <= 0)
        {
            return false;
        }
        else
        {
            Saldo -= saque;
            return true;
        }
    }
}

class ContaEspecial : ContaBancaria
{
    public decimal Limite { get; private set; }

    public ContaEspecial (string titular, decimal saldo, decimal limite) : base(titular, saldo)
    {
        Limite = limite;
    }

    public override bool Sacar(decimal saque)
    {
        if (saque <= 0)
        {
            return false;
        }
        else if (Saldo + Limite >= saque)
        {
            Saldo -= saque;
            return true;
        }
        
        return false;
    }
}

//Perguntas finais
// -> Limite pra mim está incluído.
//1. a palavra virtual, o mesmo nome e os mesmos parâmetros
//2. letra A
//3. letra B


//PERGUNTAS AULA EXTRA
//1. Letra c
//2. Letra a
//3. Letra b - Não entendi muito bem destrutores (me explique denovo de forma resumida e fácil)
//4. Letra a
//5. Letra a
