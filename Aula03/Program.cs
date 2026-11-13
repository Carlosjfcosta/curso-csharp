
//Perguntas Rápidas
//1. idade >= 18 produz um bool
//2. = equivale a recebe (valor), == é um bool de comparação.
//3. o que estiver depois do ponto e vírgula não estará condicionado ao bool do if, será executado independente da descisão,
//4. 4 blocos.
//5. imprime recuperação, apesar de o else if também ser verdadeiro, o comando if irá executar o primeiro verdadeiro depois sairá do bloco

//Exercício 1
Console.Write("Digite um número para comparação: ");
int numA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Digite outro número para comparação: ");
int numB = int.Parse(Console.ReadLine() ?? "");

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

//Exercício 2
Console.Write("Digite sua nota: ");
double nota = double.Parse(Console.ReadLine() ?? "");

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 4)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

//Exercício 3
Console.Write("Digite um ano para saber se é bissexto: ");
int ano = int.Parse(Console.ReadLine() ?? "");

if (ano % 4 == 0 && ano % 100 != 0)
{
    Console.WriteLine($"{ano} é bissexto");
}
else if (ano % 100 == 0 && ano % 400 == 0){
    Console.WriteLine($"{ano} é bissexto");
}
else
{
    Console.WriteLine($"{ano} não é bissexto");
}

//Exercício 3 corrigido:
Console.Write("Digite um ano para saber se é bissexto: ");

bool ehBissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);

if (ehBissexto)
{
    Console.WriteLine($"{ano} é bissexto");
}
else
{
    Console.WriteLine($"{ano} não é bissexto");
}