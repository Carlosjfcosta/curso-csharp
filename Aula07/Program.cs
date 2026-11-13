// //Exercício 1

// double[] notas = {7, 8.5, 6, 9, 10};

// double somaNotas = 0;

// foreach(double nota in notas)
// {
//     Console.WriteLine($"{nota}");
//     somaNotas += nota;
// }

// Console.WriteLine($"A quantidade de notas é: {notas.Length}");
// Console.WriteLine($"A soma das notas é: {somaNotas}");


// //Exercício 2

// int teste;
// Console.Write("Quantas notas você vai inserir? ");
// if(int.TryParse(Console.ReadLine() ?? "", out teste))
// {
//     int quantidadeNotas = teste;
//     double[] notas = new double[teste];
//     double somaNotas = 0;

//     if(teste > 0)
//     {
//         for(int i = 0; i < quantidadeNotas; i++)
//         {
//             double nota = LerNumeroDouble($"Qual o valor da {i + 1}ª nota? ");
//             notas[i] = nota;
//             somaNotas += nota;
//         }

//         foreach(double leitura in notas)
//         {
//             double leituraNota = leitura;
//             Console.WriteLine(leituraNota);
//         }

//         Console.WriteLine($"A média das notas é: {somaNotas / quantidadeNotas}");

//         double maior = notas[0];
//         double menor = notas[0];
//         foreach(double copiaNotas in notas)
//         {
//             if (copiaNotas > maior)
//             {
//                 maior = copiaNotas;
//             }
//         }

//         foreach(double copiaNotas in notas)
//         {
//             if (copiaNotas < menor)
//             {
//                 menor = copiaNotas;
//             }
//         }

//         Console.WriteLine($"A maior nota é: {maior}; e a menor é: {menor}");
//     }
//     else
//     {
//         Console.WriteLine("Sem notas inseridas.");
//     }
// }
// else
// {
//     Console.WriteLine($"Entrada inválida.");
// }

// double LerNumeroDouble(string pergunta)
// {
//     Console.Write(pergunta);

//     double numero;
//     while (!double.TryParse(Console.ReadLine() ?? "", out numero))
//     {
//         Console.WriteLine("Entrada inválida");
//         Console.Write("Digite novamente a entrada correta: ");
//     }

//     return numero;
// }


// //Exercício 2 - Correções/Refino

// Console.Write("Quantas notas você vai inserir? ");

// if (int.TryParse(Console.ReadLine() ?? "", out int quantidadeNotas))
// {
//     if (quantidadeNotas > 0)
//     {

//         double[] notas = new double[quantidadeNotas];
//         double somaNotas = 0;

//         for (int i = 0; i < quantidadeNotas; i++)
//         {
//             double nota = LerNumeroDouble($"Qual o valor da {i + 1}ª nota? ");
//             notas[i] = nota;
//             somaNotas += nota;
//         }

//         double maior = notas[0];
//         double menor = notas[0];

//         foreach (double leitura in notas)
//         {
//             Console.WriteLine(leitura);

//             if (leitura > maior)
//             {
//                 maior = leitura;
//             }

//             if (leitura < menor)
//             {
//                 menor = leitura;
//             }
//         }

//         Console.WriteLine($"A média das notas é: {(somaNotas / quantidadeNotas):F2}");
//         Console.WriteLine($"A maior nota é: {maior}; e a menor é: {menor}");
//     }
//     else
//     {
//         Console.WriteLine("Quantidade de notas inválida.");
//     }
// }
// else
// {
//     Console.WriteLine("Entrada inválida.");
// }


// double LerNumeroDouble(string pergunta)
// {
//     Console.Write(pergunta);

//     double numero;
//     while (!double.TryParse(Console.ReadLine() ?? "", out numero))
//     {
//         Console.WriteLine("Entrada inválida");
//         Console.Write("Digite novamente a entrada correta: ");
//     }

//     return numero;
// }

//Perguntas rápidas
//1. nomes.Count(), pois o "Count" é um método que devolve um valor guardado, logo necessário o ().
//2. não compila, pois o Sort() é um método que embaralha os valores dentro da List e não guarda um valor específico em um variável
//3. Bruno; depois do Sort, Ana.

//Exercício 3
List<string> nomes = new List<string>();

while (true)
{
    Console.Write("Digite um nome para adicionar a lista, ou 'fim' para encerrar a lista: ");
    string entrada = Console.ReadLine() ?? "";

    if (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Entrada inválida");
    }
    else
    {
        if (entrada.ToLower() == "fim")
        {
            break;
        }

        nomes.Add(entrada);
    }
}

if (nomes.Count == 0)
{
    Console.WriteLine("Sem nomes na lista.");
}
else
{
    Console.WriteLine($"A quantidade de nomes na lista é: {nomes.Count}");

    nomes.Sort();
    Console.WriteLine("A lista em ordem alfabética é: ");
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }

    Console.Write("Digite um nome para saber se está na lista: ");
    string pesquisaNome = Console.ReadLine() ?? "";
    bool temNome = false;
    if (string.IsNullOrWhiteSpace(pesquisaNome))
    {
        Console.WriteLine("Digite um nome.");
    }
    else
    {
        pesquisaNome = pesquisaNome.ToLower();
        foreach (string nome in nomes)
        {  
            string nomeMinusculo = nome.ToLower();
            if (pesquisaNome == nomeMinusculo)
            {
                temNome = true;
                break;
            }
        }

        if(temNome == true)
        {
            Console.WriteLine($"{pesquisaNome} está na lista");
        }
        else
        {
            Console.WriteLine($"{pesquisaNome} não está na lista");
        }
    }
}
