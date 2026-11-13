//Perguntas Rápidas
//1. b
//2. c
//3. a
//4. c 
//5. a


// //Exercício 1

// List<Viatura> viaturas = new List<Viatura>();

// // Viatura novaBomba = new AutoBombaTanque("ABT-01", 6000);
// // AutoBombaTanque novaBomba = new AutoBombaTanque("ABT-01", 6000);
// // viaturas.Add(novaBomba);
// // Console.WriteLine(novaBomba.LitrosDeAgua);

// // Viatura novaUR = new UnidadeResgate ("UR-01", 2);
// // Viatura novaViatura = new Viatura("AT-02");

// viaturas.Add(new AutoBombaTanque("ABT-01", 6000));
// viaturas.Add(new UnidadeResgate ("UR-01", 2));
// viaturas.Add(new Viatura("AT-02"));

// // AutoBombaTanque outra = new Viatura("AT-09");
// // // Não compila pois AutoBombaTanque tem o construtor exigindo os litros de água


// foreach (Viatura viatura in viaturas)
// {
//     Console.WriteLine(viatura.Descrever());
// }


// //======= MÉTODOS =======



// //======= CLASSES =======

// class Viatura
// {
//     public string Prefixo { get; private set; }

//     public Viatura(string prefixo)
//     {
//         Prefixo = prefixo;
//     }

//     public virtual string Descrever()
//     {
//         return $"Viatura {Prefixo}";
//     }
// }

// class AutoBombaTanque : Viatura
// {
//     public int LitrosDeAgua { get; private set; }

//     public AutoBombaTanque(string prefixo, int litros) : base(prefixo)
//     {
//         LitrosDeAgua = litros;
//     }

//     public override string Descrever()
//     {
//         return $"Auto Bomba Tanque {Prefixo} · {LitrosDeAgua} litros";
//     }
// }

// class UnidadeResgate : Viatura
// {
//     public int Macas { get; private set; }

//     public UnidadeResgate(string prefixo, int macas) : base(prefixo)
//     {
//         Macas = macas;
//     }

//     public override string Descrever()
//     {
//         return $"Unidade de Resgate {Prefixo} · {Macas} macas";
//     }

//     // public new string Descrever()
//     // {
//     //     return $"Unidade de Resgate {Prefixo} · {Macas} macas";
//     // }
// }


//Contraexemplos:
//1. a
//2. a
//3. b (foi criado diretamente como um UnidadeResgate)


// //Exercício 2

// List<Forma> formas = new List<Forma>();

// formas.Add(new Retangulo(4, 5));
// formas.Add(new Circulo(1));
// formas.Add(new Circulo(2));

// double somaAreas = 0;
// foreach (Forma forma in formas)
// {
//     Console.WriteLine(forma);
//     somaAreas += forma.Area();
// }

// Console.WriteLine($"Área total: {somaAreas:F2}");

// // Forma teste = new Forma("Teste");

// //======= CLASSES =======
// abstract class Forma
// {
//     public string Nome { get; private set; }

//     public Forma (string nome)
//     {
//         Nome = nome;
//     }

//     public abstract double Area();

//     public override string ToString()
//     {
//         return $"{Nome}: área {Area():F2}";
//     }
// }

// class Retangulo : Forma 
// {
//     public double Largura { get; private set; }
//     public double Altura { get; private set; }

//     public Retangulo (double largura, double altura) : base ("Retângulo")
//     {
//         Largura = largura;
//         Altura = altura;
//     }

//     public override double Area()
//     {
//         return Largura * Altura;
//     }
// }

// class Circulo : Forma
// {
//     public double Raio { get; private set; }

//     public Circulo (double raio) : base ("Círculo")
//     {
//         Raio = raio;
//     }
//     public override double Area()
//     {
//         return Math.PI * Raio * Raio;
//     }
// }


//Exercício 3

List<IInspecionavel> inspecoes = new List<IInspecionavel>();

inspecoes.Add(new AutoBombaTanque("ABT-01", 6000));
inspecoes.Add(new Extintor("Garagem", 8));
inspecoes.Add(new AutoBombaTanque("ABT-02", 3500));
// inspecoes.Add(new AutoBombaTanque("ABT-02", 5000));
inspecoes.Add(new Extintor("Alojamento", 0));
// inspecoes.Add(new Extintor("Alojamento", 1));

// inspecoes.Add(new UnidadeResgate("UR-01", 2));

int alteracoes = 0;
foreach (IInspecionavel inspecao in inspecoes)
{
    if (inspecao.EstaEmCondicoes())
    {
            Console.WriteLine($"Condição: OK | {inspecao.Descrever()}");
    }
    else
    {
        Console.WriteLine($"Condição: ALTERAÇÃO | {inspecao.Descrever()}");
        alteracoes++;
    }
}

if (alteracoes > 0)
{
    Console.WriteLine($"Passagem de serviço com {alteracoes} alteração(ões)");
}
else
{
    Console.WriteLine("Passagem de serviço sem alteração");
}



//======= CLASSES =======

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

class UnidadeResgate : Viatura
{
    public int Macas { get; private set; }

    public UnidadeResgate(string prefixo, int macas) : base(prefixo)
    {
        Macas = macas;
    }

    public override string Descrever()
    {
        return $"Unidade de Resgate {Prefixo} · {Macas} macas";
    }
}
