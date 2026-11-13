//Perguntas Rápidas
//Func<Extintor, bool> descreve um método que: a) recebe um bool e devolve um Extintor · b) recebe um Extintor e devolve um bool · c) não devolve nada
// B
//Em e => e.MesesParaVencer == 0, o e é: a) o parâmetro: cada item, um por vez · b) a lista inteira · c) uma variável criada antes, em outro lugar
// A
//litros.Where(x => x > 45) devolve: a) true ou false · b) a quantidade de itens · c) só os itens que passam na regra
// C
//litros.First(x => x > 100), quando nenhum item passa: a) devolve 0 · b) derruba o programa com uma exception · c) devolve uma lista vazia
// B
//Num evento, a classe que dispara: a) precisa conhecer cada classe que escuta · b) chama os métodos dos ouvintes pelo nome · c) só avisa, e quem se inscreveu com += reage
// C

// //Usando só métodos do LINQ, sem escrever nenhum contador nem acumulador, mostre: quantos abastecimentos passaram de 45 litros; se existe algum abaixo de 30 litros; o total de litros; e, por último, a lista dos abastecimentos acima de 45 litros, um por linha. O único foreach do programa é o que imprime essa lista.
// //Exercício 1

// List<int> litros = new List<int>();
// litros.Add(40);
// litros.Add(55);
// litros.Add(38);
// litros.Add(62);
// litros.Add(46);

// Console.WriteLine($"Acima de 62 litros: {litros.Count(n => n > 62)}");
// Console.WriteLine($"Existe algum abaixo de 30? {litros.Any(n => n < 30)}");
// Console.WriteLine($"Total: {litros.Sum()}");

// foreach(int litro in litros.Where(n => n > 62))
// {
//     Console.WriteLine($"A lista dos acima de 62: {litro}");
// }
// // ======= MÉTODOS =======



// // ======= CLASSES =======


// //Exercício 2
// //Com LINQ, monte um relatório de quatro partes: os locais dos extintores vencidos (prazo igual a zero); os que vencem em até 3 meses, sem contar os já vencidos, do menor prazo para o maior, com o local e o prazo; todos os locais em ordem alfabética; e o maior prazo da lista. Nenhum if, contador ou "campeão" escrito à mão: os foreach servem só para imprimir.

// List<Extintor> extintores = new List<Extintor>();
// extintores.Add(new Extintor("Garagem", 8));
// extintores.Add(new Extintor("Alojamento", 0));
// extintores.Add(new Extintor("Cozinha", 5));
// extintores.Add(new Extintor("Pátio", 2));
// extintores.Add(new Extintor("Almoxarifado", 0));
// extintores.Add(new Extintor("Recepção", 3));

// Console.WriteLine("Vencidos: ");
// foreach (string local in extintores
//     .Where(n => n.MesesParaVencer == 0)
//     .Select(n => n.Local))
// {
//     Console.WriteLine(local);
// }

// Console.WriteLine("Vencem em até 3 meses:");
// foreach (Extintor extintor in extintores
//     .Where(n => n.MesesParaVencer <= 3 && n.MesesParaVencer > 0)
//     .OrderBy(n => n.MesesParaVencer))     
// {
//     Console.WriteLine($"{extintor.Local} ({extintor.MesesParaVencer})");   
// }

// Console.WriteLine("Locais em ordem alfabética: ");
// foreach (string local in extintores
//     .OrderBy(n => n.Local)
//     .Select(n => n.Local))
// {
//     Console.WriteLine(local);
// }

// Console.WriteLine($"O maior prazo: {extintores.Max(n => n.MesesParaVencer)} meses");

// // ======= MÉTODOS =======



// // ======= CLASSES =======

// class Extintor
// {
//     public string Local { get; private set; }
//     public int MesesParaVencer { get; private set; }

//     public Extintor(string local, int mesesParaVencer)
//     {
//         Local = local;
//         MesesParaVencer = mesesParaVencer;
//     }
// }


//Exercício 3
//Escreva o método Filtrar: ele recebe uma lista e uma regra, e devolve uma lista nova só com os itens que passam na regra. Dentro dele não vale LINQ: use foreach. O mesmo método precisa servir para a lista de extintores e para a lista de números. No programa, chame o Filtrar para cada teste abaixo e mostre quantos itens voltaram.

// ======= PROGRAM =======

List<Extintor> extintores = new List<Extintor>();
extintores.Add(new Extintor("Garagem", 8));
extintores.Add(new Extintor("Alojamento", 0));
extintores.Add(new Extintor("Cozinha", 5));
extintores.Add(new Extintor("Pátio", 2));
extintores.Add(new Extintor("Almoxarifado", 0));
extintores.Add(new Extintor("Recepção", 3));

List<int> litros = new List<int>();
litros.Add(40);
litros.Add(55);
litros.Add(38);
litros.Add(62);
litros.Add(46);

// List<Extintor> vencidos = Filtrar(extintores, e => e.MesesParaVencer == 0);
// Console.WriteLine("Vencidos com uma lambda: ");
// foreach (Extintor vencido in vencidos)
// {
//     Console.WriteLine($"Extintor do: {vencido.Local} - {vencido.MesesParaVencer} mes(es) para vencer.");
// }
// Console.WriteLine($"Quantidade: {vencidos.Count}");

List<Extintor> vencidos = Filtrar(extintores, EstaVencido);
Console.WriteLine("Vencidos com uma lambda: ");
foreach (Extintor vencido in vencidos)
{
    Console.WriteLine($"Extintor do: {vencido.Local} - {vencido.MesesParaVencer} mes(es) para vencer.");
}
Console.WriteLine($"Quantidade: {vencidos.Count}");

// List<Extintor> vencidos = Filtrar(extintores, e => e.MesesParaVencer);
// Console.WriteLine("Vencidos com uma lambda: ");
// foreach (Extintor vencido in vencidos)
// {
//     Console.WriteLine($"Extintor do: {vencido.Local} - {vencido.MesesParaVencer} mes(es) para vencer.");
// }
// Console.WriteLine($"Quantidade: {vencidos.Count}");

List<Extintor> vencimentoQuatroMeses = Filtrar(extintores, e => e.MesesParaVencer > 4);
Console.WriteLine("Extintores com mais de 4 meses para vencer:");
foreach (Extintor vencido in vencimentoQuatroMeses)
{
    Console.WriteLine($"Extintor do: {vencido.Local} - {vencido.MesesParaVencer} mes(es) para vencer.");
}
Console.WriteLine($"Quantidade: {vencimentoQuatroMeses.Count}");

Console.WriteLine("Mais de 45 litros:");
List<int> litrosFiltro = Filtrar(litros, x => x > 45);
foreach(int litro in litrosFiltro)
{
    Console.WriteLine(litro);
}
Console.WriteLine($"Quantidade: {litrosFiltro.Count}");

// ======= MÉTODOS =======

List<T> Filtrar<T>(List<T> itens, Func<T, bool> regra)
{
    List<T> listaNova = new List<T>();
    foreach (T item in itens)
    {
        if (regra(item))
        {
            listaNova.Add(item);
        }
    }
    return listaNova;
}

// List<Extintor> Filtrar(List<Extintor> itens, Func<Extintor, bool> regra)
// {
//     List<Extintor> listaNova = new List<Extintor>();
//     foreach (Extintor item in itens)
//     {
//         if (regra(item))
//         {
//             listaNova.Add(item);
//         }
//     }
//     return listaNova;
// }

bool EstaVencido(Extintor e)
{
    return e.MesesParaVencer == 0;
}

// ======= CLASSES =======

class Extintor
{
    public string Local { get; private set; }
    public int MesesParaVencer { get; private set; }

    public Extintor(string local, int mesesParaVencer)
    {
        Local = local;
        MesesParaVencer = mesesParaVencer;
    }
}