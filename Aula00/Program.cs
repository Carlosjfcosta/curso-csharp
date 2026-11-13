using System.Reflection.Metadata.Ecma335;
using Microsoft.Win32.SafeHandles;

//Exercício 1

string nome = "Carlos";
int idade = 23;
string cidade = "Belo Horizonte";
double altura = 1.78;

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Cidade: {cidade}");
Console.WriteLine($"Altura: {altura}");

//Exercício 2

string nomeEquipamento = "Holmatro";
int quantidade = 3;
double peso = 40.5;
bool disponivel = true;
char categoria = 'A';

Console.WriteLine("=== EQUIPAMENTO ===");
Console.WriteLine($"Nome do equipamento: {nomeEquipamento}");
Console.WriteLine($"Quantidade em estoque: {quantidade}");
Console.WriteLine($"Peso em kg: {peso} kg");
Console.WriteLine($"Está disponível? {disponivel}");
Console.WriteLine($"Categoria: {categoria}");

//Exercício 3

double larguraRetangulo = 4;
double alturaRetangulo = 5;
double areaRetangulo;
double perimetroRetangulo;

areaRetangulo = alturaRetangulo * larguraRetangulo;
perimetroRetangulo = 2*alturaRetangulo + 2*larguraRetangulo;

Console.WriteLine($"A área do retângulo é: {areaRetangulo}");
Console.WriteLine($"O perímetro do retângulo é: {perimetroRetangulo}");