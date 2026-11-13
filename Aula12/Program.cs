//Perguntas Rápidas
// Perguntas rápidas (responda só com as letras)
// Em List<Viatura>, o <Viatura> é: a) o tipo que a lista vai guardar, escolhido na hora de criar · b) o nome da lista · c) a quantidade de itens
// a
// Num Dictionary<string, int>, ler quadro["XX-99"] quando essa chave não existe: a) devolve 0 · b) devolve um texto vazio · c) derruba o programa com uma exception
// c
// Para saber se uma chave existe antes de ler, usa-se: a) Count · b) ContainsKey ou TryGetValue · c) Sort
// b
// Dentro de class Deposito<T>, sem where, a linha item.EstaEmCondicoes(): a) compila, se você só usar extintores · b) compila sempre · c) não compila: o T pode ser qualquer tipo
// c -> Não entendi muito bem essa parte, me explique novamente rápido e preciso.
// Chamar Add duas vezes com a mesma chave num Dictionary: a) derruba o programa, porque a chave é única · b) guarda os dois valores · c) troca o valor antigo em silêncio
// a


// //Exercício 1

// Dictionary<string, int> viaturaCombustivel = new Dictionary<string, int>();

// // Dictionary<string, int> viaturaCombustivel = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

// viaturaCombustivel.Add("ABT-01", 120);
// viaturaCombustivel.Add("UR-01", 45);
// viaturaCombustivel.Add("AT-02", 80);

// Console.WriteLine($"Viaturas no quadro: {viaturaCombustivel.Count}");

// string resposta = Pergunta("Digite o prefixo de uma viatura para saber se está no quadro: ");
// resposta = resposta.ToUpper();

// if (viaturaCombustivel.ContainsKey(resposta))
// {
//     Console.WriteLine($"{resposta}: {viaturaCombustivel[resposta]} litros");
// }
// else
// {
//     Console.WriteLine("Viatura não cadastrada.");
// }

// // if(viaturaCombustivel.TryGetValue(resposta, out int litros))
// // {
// //     Console.WriteLine($"{resposta}: {litros} litros");
// // }

// // Console.WriteLine(viaturaCombustivel["XX-99"]);

// //======= MÉTODOS =======

// string Pergunta(string pergunta)
// {
//     Console.Write(pergunta);

//     string entrada = Console.ReadLine() ?? "";
//     while (string.IsNullOrWhiteSpace(entrada))
//     {
//         Console.WriteLine("Entrada inválida");
//         Console.Write("Digite novamente a entrada correta: ");
//         entrada = Console.ReadLine() ?? "";
//     }

//     return entrada;
// }

// //======= CLASSES =======


// //Exercício 2

// List<string> ocorrencias = new List<string>();
// ocorrencias.Add("incêndio");
// ocorrencias.Add("resgate");
// ocorrencias.Add("incêndio");
// ocorrencias.Add("salvamento");
// ocorrencias.Add("resgate");
// ocorrencias.Add("incêndio");
// ocorrencias.Add("vistoria");
// ocorrencias.Add("incêndio");

// Dictionary<string, int> naturezasOcorrencia = new Dictionary<string, int>();

// foreach(string ocorrencia in ocorrencias)
// {
//     if (naturezasOcorrencia.ContainsKey(ocorrencia))
//     {
//         naturezasOcorrencia[ocorrencia] = naturezasOcorrencia[ocorrencia] + 1;
//     }
//     else
//     {
//         naturezasOcorrencia.Add(ocorrencia, 1);
//     }
// }

// int somaContagens = 0;
// string ocorrenciaCampeao = "";
// int maiorQuantidade = 0;

// foreach (KeyValuePair<string, int> par in naturezasOcorrencia)
// {
//     Console.WriteLine($"{par.Key}: {par.Value}");
//     somaContagens += par.Value;

//     if (par.Value > maiorQuantidade)
//     {
//         maiorQuantidade = par.Value;
//         ocorrenciaCampeao = par.Key;
//     }
// }

// Console.WriteLine($"Total contado: {somaContagens} de {ocorrencias.Count}");

// Console.WriteLine($"Mais frequente: {ocorrenciaCampeao} ({maiorQuantidade})");


//Exercício 3

Deposito<Extintor> depositoExtintores = new Deposito<Extintor>(3);
Deposito<AutoBombaTanque> depositoABT = new Deposito<AutoBombaTanque>(2);

depositoExtintores.Guardar(new Extintor("Garagem", 8));
depositoExtintores.Guardar(new Extintor("Alojamento", 0));
depositoExtintores.Guardar(new Extintor("Cozinha", 5));
// depositoExtintores.Guardar(new Extintor("Pátio", 2));

depositoABT.Guardar(new AutoBombaTanque("ABT-01", 6000));
depositoABT.Guardar(new AutoBombaTanque("ABT-02", 3500));

// depositoExtintores.Guardar(new AutoBombaTanque("ABT-03", 6000));
//Não compila, já que o deposito de extintores aceita apenas a classe Extintor e não a AutoBombaTanque

Console.WriteLine($"A quantidade no depósito de extintores é: {depositoExtintores.Quantidade()} e tem {depositoExtintores.ContarAlteracoes()} alterações");

Console.WriteLine(depositoExtintores.Guardar(new Extintor("Pátio", 2)));

Console.WriteLine($"A quantidade no depósito de ABTs é: {depositoABT.Quantidade()} e tem {depositoABT.ContarAlteracoes()} alterações");

// Console.WriteLine(depositoExtintores.Primeiro().Local);

//======= CLASSES =======

// class Deposito<T> 
class Deposito<T> where T : IInspecionavel
{
    public int Capacidade { get; private set; }
    private List<T> itens;

    public Deposito (int capacidade)
    {
        Capacidade = capacidade;
        itens = new List<T>();
    }

    public bool Guardar(T item)
    {
        if (itens.Count >= Capacidade)
        {
            return false;
        }

        itens.Add(item);
        return true;
    }

    public int Quantidade()
    {
        return itens.Count;
    }

    public int ContarAlteracoes()
    {
        int somaAlteracoes = 0;

        foreach (T item in itens)
        {
            if (!item.EstaEmCondicoes())
            {
                somaAlteracoes++;
            }
        }

        return somaAlteracoes;
    }

    public T Primeiro()
    {
        return itens[0];
    }
}

interface IInspecionavel
{
    string Descrever();

    bool EstaEmCondicoes();
}

class Extintor : IInspecionavel
{
    public string Local { get; private set; }
    public int MesesParaVencer { get; private set; }

    public Extintor (string local, int mesesParaVencer)
    {
        Local = local;
        MesesParaVencer = mesesParaVencer;
    }

    public bool EstaEmCondicoes()
    {
        return MesesParaVencer >= 1;
    }
    public string Descrever()
    {
        return $"Local do extintor: {Local}, {MesesParaVencer} meses";
    }
}

class Viatura
{
    public string Prefixo { get; private set; }

    public Viatura(string prefixo)
    {
        Prefixo = prefixo;
    }

        public virtual string Descrever()
    {
        return $"Viatura {Prefixo}";
    }
}

class AutoBombaTanque : Viatura, IInspecionavel
{
    public int LitrosDeAgua { get; private set; }

    public AutoBombaTanque(string prefixo, int litros) : base (prefixo)
    {
        LitrosDeAgua = litros;
    }

    public bool EstaEmCondicoes()
    {
        return LitrosDeAgua >= 5000;
    }
    public override string Descrever()
    {
        return $"Auto Bomba Tanque {Prefixo} · {LitrosDeAgua} litros";
    }
}