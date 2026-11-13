// //Exercício 1a

// void MostrarTitulo(string texto)
// {
//     Console.WriteLine("======================");
//     Console.WriteLine(texto.ToUpper());
//     Console.WriteLine("======================");
// }


// // Exercício 1b

// double Media(double a, double b, double c)
// {
//     return (a + b + c) / 3;
// }


// //Exercício 1c

// MostrarTitulo("Média dos 3 números");

// double resultadoMedia = Media(8,9,10);

// Console.WriteLine($"A média dos 3 números é: {resultadoMedia:F2}");


//// Exercício 2

// for (int candidato = 1; candidato <= 50; candidato++)
// {
//     if (EhPrimo(candidato))
//     {
//         Console.WriteLine(candidato);
//     }
// }

// Console.WriteLine("Digite um número inteiro para saber se é primo: ");
// if (int.TryParse(Console.ReadLine() ?? "", out int numPrimo))
// {
//     if (EhPrimo(numPrimo))
//     {
//         Console.WriteLine("Número primo");
//     }
//     else
//     {
//         Console.WriteLine("Número não primo");
//     }
// }
// else
// {
//     Console.WriteLine("Número inválido.");
// }


// bool EhPrimo(int numero)
// {
//     if (numero < 2)
//     {
//         return false;
//     }
//     for (int divisor = 2; divisor <= (numero - 1); divisor++)
//     {
//         if (numero % divisor == 0)
//         {
//             return false;
//         }
//     }

//     return true;
// }


//Exercício 3

double LerNumeroDouble(string pergunta)
{
    Console.Write(pergunta);

    double numero;
    while (!double.TryParse(Console.ReadLine() ?? "", out numero))
    {
        Console.WriteLine("Entrada inválida");
        Console.Write("Digite novamente a entrada correta: ");
    }

    return numero;
}

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

int quantidadeNotas = LerNumeroInt("Digite a quantidade de notas para fazer a média: ");

if (quantidadeNotas > 0)
{
    double somaNotas = 0;

    for (int i = 1; i <= quantidadeNotas; i++)
    {
    somaNotas += LerNumeroDouble($"Digite a {i}ª nota: ");
    }

    double mediaNotas = somaNotas / quantidadeNotas;
    Console.WriteLine($"A média das notas é: {mediaNotas:F2}");
}
else
{
    Console.WriteLine($"Sem notas para fazer a média.");
}





