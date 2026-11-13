//Perguntas Rápidas
//1. while é uma repetição que pode não ser executada caso a condição não seja aceita de primeira, já o do/while, pelo comando do, força uma primeira execução do comando.
//2. varíável (contador ou acumulador), intervalo, incremento.
//3. no for roda antes do bloco, já no while roda depois.
//4. break para o laço completo, o continue para apenas a volta do laço.
//5. como o incremento do contador é após o comando no while, caso use o continuie antes do incremento do contador, o laço ficará infinito, já no for, como o incremento é feito antes do comando, o continue pode ficar em qualquer posição.
//6. o laço de dentro roda todas as vezes do intervalo em 1 rodagem do laço de fora.

//Etapa 1
//1.1
using System.ComponentModel;
using System.Numerics;

int contador = 10;

while (contador >= 1) {
    Console.WriteLine($"{contador}");
    contador--;
}

Console.WriteLine($"Fim!");

Console.WriteLine($" ");

//1.2
int contadorA = 2;

while (contadorA <= 20)
{
    if (contadorA % 2 == 0)
    {
    Console.WriteLine($"{contadorA}");
    }
    contadorA ++;
}

Console.WriteLine($" ");

//1.2
int ia = 2;

while (ia <= 20) {
    Console.WriteLine($"{ia}");
    ia += 2;
}

Console.WriteLine($" ");

//1.3
int contadorB = 1;
int somaB = 0;

while (contadorB <= 100) 
{
    somaB += contadorB;
    contadorB++;
}

Console.WriteLine($"A soma de 1 a 100 é: {somaB}");

Console.WriteLine($" ");

//1.4
int contadorC = 1;
int produtoC = 0;

Console.Write("Digite um número inteiro para saber toda a tabuada: ");

if(int.TryParse(Console.ReadLine() ?? "", out int numC))
{
    while(contadorC <= 10)
    {
    produtoC = numC * contadorC;
    Console.WriteLine($"{numC} * {contadorC} = {produtoC}");
    contadorC ++;
    }
}

else
{
    Console.WriteLine($"Entrada inválida, digite um número inteiro.");
}


