// //Etapa 2
// //2.1
// int contadorA = 1;
// double somaNotas = 0;
// double mediaNotas;

// Console.Write("Quantas notas para fazer a média? ");
// if (int.TryParse(Console.ReadLine() ?? "", out int numNotas))
// {
//     while (contadorA <= numNotas)
//     {
//         Console.Write($"Digite a {contadorA}ª nota: ");
//         if (double.TryParse(Console.ReadLine() ?? "", out double valorNotas))
//         {
//             somaNotas += valorNotas;
//             contadorA ++;
//         }
//         else
//         {
//             Console.WriteLine("Entrada inválida.");

//         }
//     }
//     if(numNotas != 0)
//     {
//         mediaNotas = somaNotas/numNotas;
//         Console.WriteLine($"A média das notas é: {mediaNotas:F2}"); 
//     }
//     else
//     {
//         Console.WriteLine($"Sem notas para fazer a média."); 
//     }
// }
// else
// {
//     Console.WriteLine("Entrada inválida, digite um número inteiro.");
// }

// //2.2
// int contadorTentativas = 3;

// while (contadorTentativas > 0)
// {
//     Console.WriteLine("Digite o PIN de 4 dígitos do cofre: ");
//     if(int.TryParse(Console.ReadLine() ?? "", out int PIN))
//     {
//         if(PIN == 1234)
//         {
//             Console.WriteLine("Cofre Aberto");
//             break;
//         }
//         else
//         {
//             contadorTentativas--;
//             Console.WriteLine($"Restam {contadorTentativas} tentativas.");
//         }
//     }
//     else
//     {
//         contadorTentativas--;
//         Console.WriteLine($"Restam {contadorTentativas} tentativas.");
//     }
//     if (contadorTentativas == 0)
//     {
//         Console.WriteLine($"Cofre bloqueado");
//     }

// }

// //Exercício 2
// using System.Runtime.InteropServices;

// int somaNumerosA = 0;
// int numerosCorretosA = 0;

// for (int i = 1; i <= 50; i++)
// {
//     if(i % 3 == 0 && i % 15 != 0)
//     {
//         Console.WriteLine(i);
//         numerosCorretosA++;
//         somaNumerosA += i;
//     }
// }

// Console.WriteLine($"A quantidade de números impressos foi de: {numerosCorretosA}");
// Console.WriteLine($"A soma dos números impressos foi de: {somaNumerosA}");

// //Exercício 2 - continue
// int somaNumerosB = 0;
// int numerosCorretosB = 0;

// for (int i = 1; i <= 50; i++)
// {
//     if(i % 3 != 0)
//     {
//         continue;
//     }
//     if(i % 5 == 0)
//     {
//         continue;
//     }
    
//     Console.WriteLine(i);
//     somaNumerosB += i;
//     numerosCorretosB++;
// }

// Console.WriteLine($"A quantidade de números impressos foi de: {numerosCorretosB}");
// Console.WriteLine($"A soma dos números impressos foi de: {somaNumerosB}");

// //Exercício 3
// for (int candidato = 1; candidato <= 50; candidato++)
// {
//     if (candidato == 1)
//     {
//         continue;
//     }

//     bool ehPrimo = true;

//     for (int divisor = 2; divisor <= (candidato - 1); divisor++)
//     {
//         if(candidato % divisor == 0)
//         {
//             ehPrimo = false;
//             break;
//         }
//     }

//     if (ehPrimo == true)
//     {
//         Console.WriteLine($"{candidato}");
//     }
// }


//Projeto Final

string resposta;

do
{
Console.Write("Digite um número: ");
string verA = Console.ReadLine() ?? "";

if (double.TryParse(verA, out double numbA))
{
    Console.Write("Digite outro número: ");
    string verB = Console.ReadLine() ?? "";

    if (double.TryParse(verB, out double numbB))
    {
        Console.Write("Digite uma operação entre o primeiro número e o segundo dentre: Adição (+), Subtração (-), Multiplicação (*) e Divisão (/): ");
        string testeC = Console.ReadLine() ?? "";
        double resultado = 0;
        bool temResultado = true;

        switch (testeC)
        {
            case ("+"):
                resultado = numbA + numbB;
                break;

            case ("-"):
                resultado = numbA - numbB;
                break;

            case ("*"):
                resultado = numbA * numbB;
                break;

            case ("/"):
                if (numbB == 0)
                {
                    temResultado = false;
                    Console.WriteLine("Não é possível dividir um número por zero.");
                }
                else
                {
                    resultado = numbA / numbB;
                    break;
                }
                break;

            default:
                temResultado = false;
                Console.WriteLine("Isso não é uma operação válida.");
                break;
        }
        if (temResultado)
        {
            Console.WriteLine($"O total da operação é: {resultado}");
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

Console.WriteLine("Deseja fazer outra operação? (s/n)");
resposta = Console.ReadLine() ?? "";
}
while (resposta != "n");

