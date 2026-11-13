//Perguntas Rápidas
//1. Devolve um bool
//2. a palavra out aloca o que foi testado se true em algum lugar (no exemplo uma variável), se false ele por padrão retorna 0
//3. zero por padrão
//4. qual variável? não entendi a pergunta
//5. int.parse retornará um erro falando que "abc" não é um inteiro, o int.tryparse irá retornar 0, podendo ser manipulado para retornar uma mensagem personalizada.

//Exercício 1
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.Serialization.Formatters;

Console.Write("Digite um número inteiro para comparação: ");
string entradaA = Console.ReadLine() ?? "";

if (int.TryParse(entradaA, out int numA))
{
    Console.Write("Digite outro número inteiro para comparação: ");
    string entradaB = Console.ReadLine() ?? "";

    if (int.TryParse(entradaB, out int numB))
    {
        if (numA > numB)
        {
            Console.WriteLine($"{numA} é maior que {numB}");
        }
        else if (numA < numB)
        {
            Console.WriteLine($"{numB} é maior que {numA}");
        }
        else
        {
            Console.WriteLine($"{numA} é igual a {numB}");
        }
    }
    else
    {
        Console.WriteLine("Isso não é um número inteiro válido.");
    }
}
else
{
    Console.WriteLine("Isso não é um número inteiro válido.");
}


//Exercício 2
Console.Write("Digite a primeira nota: ");
string testeA = Console.ReadLine () ?? "";

if (double.TryParse(testeA, out double notaA))
{
    Console.Write("Digite a segunda nota: ");
    string testeB = Console.ReadLine () ?? "";

    if (double.TryParse(testeB, out double notaB))
    {
        Console.Write("Digite a terceira nota: ");
        string testeC = Console.ReadLine () ?? "";

        if (double.TryParse(testeC, out double notaC))
        {
            int quantidadeNotas = 3;
            double media = (notaA + notaB + notaC)/quantidadeNotas;
            Console.WriteLine($"A média das notas é: {media:F2}");
            if (media >= 7)
            {
             Console.WriteLine("Aprovado");
            }
            else if (media >= 4)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
              Console.WriteLine("Reprovado");
            }
        }
        else
        {
        Console.WriteLine("Isso não é uma nota válida.");
        }
    }
    else
    {
    Console.WriteLine("Isso não é uma nota válida.");
    }
}
else
{
    Console.WriteLine("Isso não é uma nota válida.");
}

//Exercício 3
Console.Write("Digite um número: ");
string verA = Console.ReadLine () ?? "";

if (double.TryParse(verA, out double numbA))
{
    Console.Write("Digite outro número: ");
    string verB = Console.ReadLine () ?? "";

    if (double.TryParse(verB, out double numbB))
    {
        Console.Write("Digite uma operação entre o primeiro número e o segundo dentre: Adição (+), Subtração (-), Multiplicação (*) e Divisão (/): ");
        string testeC = Console.ReadLine () ?? "";

        if (testeC == "+")
        {
            double totalSoma;
           totalSoma = numbA + numbB;
           Console.Write($"O total da operação é: {totalSoma}");
        }
            else if (testeC == "-")
            {
               double totalSubt;
               totalSubt = numbA - numbB;
            Console.Write($"O total da operação é: {totalSubt}");
         }
            else if (testeC == "*")
            {
                double totalMult;
                totalMult = numbA * numbB;
                Console.Write($"O total da operação é: {totalMult}");
            }
            else if (testeC == "/")
            {
                if (numbB == 0)
                {
                    Console.WriteLine("Não é possível dividir um número por zero.");
                }
                else
                {
                    double totalDiv;
                    totalDiv = numbA / numbB;
                    Console.Write($"O total da operação é: {totalDiv}");
                }
        }
        else
        {
        Console.WriteLine("Isso não é uma operação válida.");
        }
    }
    else
    {
    Console.WriteLine("Isso não é um número válido.");
    }
}
else
{
    Console.WriteLine("Isso não é um número válido.");
}

