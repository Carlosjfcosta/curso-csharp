//Perguntas Rápidas
//1. Autonomia() não precisa de parâmetros pois é encarregado de fazer a conta com os outros objetos da classe que serão inseridos.
//2. Construtor apenas cria o objeto da classe com parâmetro já definidos, não retorna nada.
//3. Não, pois agora o Viatura() para ser criado precisa de parâmetros definidos, essa é a questão do construtor, impedir que um objeto seja criado sem os devidos parâmetros.


//Pergunta conferência: letra c


// //Exercício 1

// Livro l1 = new Livro ("Harry Potter e a Pedra Filosofal", "J. K. Rowling", 1997);
// // Livro l2 = new Livro();

// Console.WriteLine($"O livro {l1.Titulo} tem como autor {l1.Autor} e foi lançado no ano de {l1.Ano}");

// //======= CLASSES =======
// class Livro
// {
//     public string Titulo { get ; set; }
//     public string Autor { get ; set; }
//     public int Ano { get ; set; }

//     public Livro (string titulo, string autor, int ano)
//     {
//         Titulo = titulo;
//         Autor = autor;
//         Ano = ano;
//     }
// }


// //Exercício 2

// List<Retangulo> retangulos = new List<Retangulo>();

// Retangulo r1 = new Retangulo (3 , 4);
// Retangulo r2 = new Retangulo (2.5 , 2);
// Retangulo r3 = new Retangulo (5 , 5);

// retangulos.Add(r1);
// retangulos.Add(r2);
// retangulos.Add(r3);

// // Console.WriteLine($"A área do retângulo r1 é {r1.Area():F2} e o perímetro é {r1.Perimetro():F2}");
// // Console.WriteLine($"A área do retângulo r2 é {r2.Area():F2} e o perímetro é {r2.Perimetro():F2}");
// // Console.WriteLine($"A área do retângulo r3 é {r3.Area():F2} e o perímetro é {r3.Perimetro():F2}");

// foreach(Retangulo retangulo in retangulos)
// {
//     Console.WriteLine($"A área do retângulo de largura {retangulo.Largura} e altura {retangulo.Altura} é {retangulo.Area():F2} e o perímetro é {retangulo.Perimetro():F2}");
// }


// //======= CLASSES =======

// class Retangulo
// {
//     public double Largura { get ; set; }
//     public double Altura { get ; set; }

//     public Retangulo (double largura , double altura)
//     {
//         Largura = largura;
//         Altura = altura;
//     }

//     public double Area()
//     {
//         return Altura * Largura;
//     }

//     public double Perimetro()
//     {
//         return ( 2 * Largura) + ( 2 * Altura);
//     }

// }


//Exercício 3

int quantidadeNotas = LerNumeroInt("Quantas notas deseja adicionar ao Aluno? ");
if (quantidadeNotas > 0)
{

    string nomeAluno = PerguntaString("Qual o nome do aluno? ");
    Aluno aluno = new Aluno(nomeAluno);

    for (int i = 1; i <= quantidadeNotas; i++)
    {
        aluno.AdicionarNota(LerNumeroDouble($"Qual a {i} nota? "));
    }

    Console.WriteLine($"A média das notas do {aluno.Nome} é: {aluno.Media():F2}");
    Console.WriteLine($"A situação do {aluno.Nome} é: {aluno.Situacao()}");
}
else
{
    Console.WriteLine("Sem quantidade de notas suficiente.");
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

string PerguntaString(string pergunta)
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

class Aluno
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; }

    public Aluno(string nome)
    {
        Nome = nome;
        Notas = new List<double>();
    }

    public void AdicionarNota(double nota)
    {
        Notas.Add(nota);
    }
    public double Media()
    {
        double somaNotas = 0;

        foreach (double nota in Notas)
        {
            somaNotas += nota;
        }

        return somaNotas / Notas.Count;
    }
    public string Situacao()
    {
        double media = Media();

        if (media >= 7.00)
        {
            return "Aprovado";
        }
        else if (media >= 4.00)
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }
}

//Pergunta final: 
// 1. letra c, pois o programa vai compilar as notas como 0, logo o média será 0 e o aluno será reprovado.
// 2. só é valida para este programa pois a proteção do 0 está no código e não na classe, quando a quantidade de notas da 0, o programa já encerra sem antes mesmo ter entrado na classe.