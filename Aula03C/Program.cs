//Perguntas
//1. erro, é necessário fechar o case.
//2. para cartacterizar o caso que não está contido nos case do switch
//3. não, case não é valido para conjuntos de valores e sim para valores exatos
//4. a operação vira switch pois os valores são conhecidos e fixos já a divisão por zero pode ser recebida por infinitos valores.
//5. bissexto e comparador de dois números

//Exercício 1
Console.Write("Digite um número inteiro de 1 a 7: ");
string verificador = Console.ReadLine() ?? "";
if (int.TryParse(verificador, out int numero))
{
    switch (numero)
    {
        case (1):
            Console.WriteLine("Domingo");
            break;

        case (2):
            Console.WriteLine("Segunda-Feira");
            break;

        case (3):
            Console.WriteLine("Terça-Feira");
            break;

        case (4):
            Console.WriteLine("Quarta-Feira");
            break;

        case (5):
            Console.WriteLine("Quinta-Feira");
            break;

        case (6):
            Console.WriteLine("Sexta-Feira");
            break;

        case (7):
            Console.WriteLine("Sábado");
            break;

        default:
            Console.WriteLine("Inválido");
            break;
    }
}
else
{
    Console.WriteLine("Número inválido");
}

//Exercício 2
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


//Exercício 3
Console.Write("Digite o número de um mês (1 a 12) para saber a estação do ano: ");
string verificacao = Console.ReadLine() ?? "";

if(int.TryParse(verificacao, out int mes)){

    switch (mes)
    {
        case 1:
        case 2:
        case 12:
            Console.WriteLine($"{mes} está na estação Verão");
            break;

        case 3:
        case 4:
        case 5:
            Console.WriteLine($"{mes} está na estação Outono");
            break;

        case 6:
        case 7:
        case 8:
            Console.WriteLine($"{mes} está na estação Inverno");
            break;

        case 9:
        case 10:
        case 11:
            Console.WriteLine($"{mes} está na estação Primavera");
            break;

        default:
            Console.WriteLine("Número inválido");
            break;
    }
}
else
{
    Console.WriteLine("Número inválido");
}
