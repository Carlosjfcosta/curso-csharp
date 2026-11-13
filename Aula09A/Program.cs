//Perguntas Rápidas
//1. Classe é o molde (como se fosse um int, double) próprio do programador, objeto são as cirações dentro do molde.
//2. o new funciona como um compilador do objeto dentro do molde.
//3. p1.Idade permanece inalterado.


// //Exercício 1

// Livro l1 = new Livro();
// l1.Titulo = "Harry Potter e a Pedra Filosofal";
// l1.Autor = "J. K. Rowling";
// l1.Ano = 1997;

// Console.WriteLine($"O livro {l1.Titulo} tem como autor {l1.Autor} e foi lançado no ano de {l1.Ano}");

// //======= CLASSES =======
// class Livro
// {
//     public string Titulo {get ; set; }
//     public string Autor {get ; set; }
//     public int Ano {get ; set; }
// }


//Perguntas Rápidas
//1. b
//2. c
//3. a
//4. b


// //Exercício 2

// Livro l1 = new Livro();
// l1.Titulo = "Harry Potter e a Pedra Filosofal";
// l1.Autor = "J. K. Rowling";
// l1.Ano = 1997;

// Livro l2 = new Livro();
// l2.Titulo = "Percy Jackson e o Ladrão de Raios";
// l2.Autor = "Rick Riordan";
// l2.Ano = 2005;

// Livro l3 = new Livro();
// l3.Titulo = "O Senhor dos Anéis";
// l3.Autor = "J. R. R. Tolkien";
// l3.Ano = 1954;

// List<Livro> livros = new List<Livro>();
// livros.Add(l1);
// livros.Add(l2);
// livros.Add(l3);


// foreach (Livro livro in livros)
// {
//     Console.WriteLine($"{livro.Titulo} - {livro.Autor} - {livro.Ano}");
// }

// Console.WriteLine($"A Quantidade de livros na lista são: {livros.Count}");

// //======= CLASSES =======
// class Livro
// {
//     public string Titulo { get; set; }
//     public string Autor { get; set; }
//     public int Ano { get; set; }
// }


//Exercício 3


List<Livro> livros = new List<Livro>();

while (true)
{
    Livro novoLivro = new Livro();

    novoLivro.Titulo = PerguntaLivro("Digite o título do livro, ou 'fim' para encerrar a lista: ");
    if ((novoLivro.Titulo).ToLower() == "fim")
    {
        break;
    }

    novoLivro.Autor = PerguntaLivro("Digite o autor do livro: ");

    novoLivro.Ano = LerNumeroInt("Digite o ano de publicação do livro: ");

    livros.Add(novoLivro);
}

if (livros.Count == 0)
{
    Console.WriteLine("Sem livros na lista.");
}
else
{
    Livro maisAntigo = livros[0];

    foreach (Livro livro in livros)
    {
        if (livro.Ano < maisAntigo.Ano)
        {
            maisAntigo = livro;
        }

        Console.WriteLine($"{livro.Titulo} - {livro.Autor} - {livro.Ano}");
    }

    Console.WriteLine($"O livro mais antigo é o: {maisAntigo.Titulo} - {maisAntigo.Autor} - {maisAntigo.Ano}");
}



//======= MÉTODOS =======
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

string PerguntaLivro(string pergunta)
{
    Console.Write(pergunta);

    string entrada = Console.ReadLine() ?? "";
    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Entrada inválida");
        Console.Write("Digite novamente a entrada correta: ");
        entrada = Console.ReadLine() ?? "";
    }

    return entrada;

}

//======= CLASSES =======
class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}
