// // Exercício 1
// Console.Write("Digite uma frase: ");

// string frase = Console.ReadLine() ?? "";
// if (string.IsNullOrWhiteSpace(frase))
// {
//     Console.WriteLine("Entrada inválida, não é permito entrada vazia ou só com espaços.");
// }
// else
// {
//     Console.WriteLine(frase.Length);
//     string fraseMinuscula = frase.ToLower();
//     Console.WriteLine(fraseMinuscula);
//     string fraseMaiuscula = frase.ToUpper();
//     Console.WriteLine(fraseMaiuscula);
//     string fraseSemEspacos = frase.Trim();
//     Console.WriteLine(fraseSemEspacos);
//     Console.WriteLine(fraseSemEspacos.Length);
//     Console.WriteLine($"Primeiro caractere da frase original: [{frase[0]}]");
//     Console.WriteLine($"Último caractere da frase original: [{frase[frase.Length - 1]}]");
// }



// // Exercício 2

// Console.Write("Digite seu nome completo: ");
// string nomeCompleto = Console.ReadLine() ?? "";
// nomeCompleto = nomeCompleto.Trim();
// string[] partes = nomeCompleto.Split(' ');

// if (string.IsNullOrWhiteSpace(nomeCompleto))
// {
//     Console.Write("Entrada inválida");    
// }
// else if (partes.Length >= 2)
// {
//     Console.WriteLine($"{partes[partes.Length - 1].ToUpper()}, {partes[0]}");

// }
// else
// {
//     Console.Write("Faltou o sobrenome!");
// }



//Exercício 3
Console.Write("Digite uma frase: ");
string fraseOriginal = Console.ReadLine() ?? "";

string frase = fraseOriginal.Trim();
frase = frase.ToLower();
frase = frase.Replace(" ", "");
bool ehPalindromo = true;


for(int i = 0; i < frase.Length / 2; i++)
{

    if(frase[i] != frase[frase.Length - 1 - i])
    {
        Console.WriteLine("Não é palíndromo");
        ehPalindromo = false;
        break;
    }
}


if(ehPalindromo)
{
    Console.WriteLine("É palíndromo");
}
