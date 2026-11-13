//Exercício 1

int notaA = 7;
int notaB = 8;
int notaC = 10;
double media;
int quantidadeNotas = 3;

media = ((double)notaA + notaB + notaC) / quantidadeNotas;

Console.WriteLine($"A média das notas é: {media:F2}");

//Exercício 2

int duracaoOcorrenciaSegundos = 3725;
int duracaoHoras = duracaoOcorrenciaSegundos/3600;
int duracaoMinutos = (duracaoOcorrenciaSegundos%3600)/60;
int duracaoSegundos = ((duracaoOcorrenciaSegundos%3600)%60);

Console.WriteLine($"Duração: {duracaoHoras}h {duracaoMinutos}min {duracaoSegundos}s");

//Exercício 3

int numero = 472;
int centena = numero/100;
int dezena = (numero%100)/10;
int unidade = (numero%10);
int soma = centena + dezena + unidade;

Console.WriteLine($"Centena: {centena}");
Console.WriteLine($"Dezena: {dezena}");
Console.WriteLine($"Unidade: {unidade}");
Console.WriteLine($"Soma dos dígitos: {soma}");


//Aula01b

double a = 0.1;
double b = 0.2;
Console.WriteLine($"double:  {a} + {b} = {a + b}");
Console.WriteLine($"É igual a 0.3? {(a + b) == 0.3}");

decimal x = 0.1m;
decimal y = 0.2m;
Console.WriteLine($"decimal: {x} + {y} = {x + y}");
Console.WriteLine($"É igual a 0.3? {(x + y) == 0.3m}");