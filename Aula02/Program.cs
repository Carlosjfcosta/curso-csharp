using System.Diagnostics;

Console.Clear();
//Exercício 1
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine() ?? "";
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"Olá, {nome}! Ano que vem você fará {idade + 1} anos.");

//Exercício 2
Console.Write("Digite a primeira nota: ");
double notaA = double.Parse(Console.ReadLine() ?? "");
Console.Write("Digite a segunda nota: ");
double notaB = double.Parse(Console.ReadLine() ?? "");
Console.Write("Digite a terceira nota: ");
double notaC = double.Parse(Console.ReadLine() ?? "");

int quantidadeNotas = 3;
double media = (notaA + notaB + notaC)/quantidadeNotas;

Console.WriteLine($"A média das notas com duas casas decimais é: {media:F2}");

//Exercício 3
Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine() ?? "";
Console.Write("Digite o preço unitário do produto: ");
decimal precoProduto = decimal.Parse(Console.ReadLine() ?? "");
Console.Write("Digite a quantidade do produto: ");
int quantidadeProduto = int.Parse(Console.ReadLine() ?? "");
Console.Write("Digite o desconto em porcentagem do produto: ");
double descontoProduto = double.Parse(Console.ReadLine() ?? "");

decimal subtotal = precoProduto * quantidadeProduto;
Console.WriteLine($"O subtotal é de: {subtotal:C}");
decimal valorDesconto = (subtotal * (decimal)descontoProduto)/100;
Console.WriteLine($"O desconto foi de: {valorDesconto:C}");
decimal pagamentoTotal = subtotal - valorDesconto;
Console.WriteLine($"O total a pagar é de: {pagamentoTotal:C}");



