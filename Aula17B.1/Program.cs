//Perguntas rápidas
//1. Uma classe Funcionario calcula o salário e também gera o PDF do contracheque. Qual princípio ela fere? a) Aberto/fechado · b) Responsabilidade única · c) Substituição de Liskov
//Letra b
//2. Para aceitar Pix, foi preciso alterar o método Pagar da classe Caixa, que já funcionava com dinheiro e cartão. Qual princípio foi violado? a) Responsabilidade única · b) Substituição de Liskov · c) Aberto/fechado
//Letra c
//3. A classe ContaPoupanca herda de Conta, mas o Sacar dela lança um erro, e o programa que passa por uma lista de contas cai quando chega nela. Qual princípio foi violado? a) Substituição de Liskov · b) Aberto/fechado · c) Responsabilidade única
//Letra a


//Exercício 1
// Boletim boletim = new Boletim("Ana", 8, 6);
// boletim.Imprimir();

// // ======= CLASSES =======
// class Boletim
// {
//     public string Aluno { get; private set; }
//     public double Nota1 { get; private set; }
//     public double Nota2 { get; private set; }

//     public Boletim(string aluno, double nota1, double nota2)
//     {
//         Aluno = aluno;
//         Nota1 = nota1;
//         Nota2 = nota2;
//     }

//     public double Media()
//     {
//         return (Nota1 + Nota2) / 2;
//     }

//     public void Imprimir()
//     {
//         Console.WriteLine($"{Aluno}: média {Media():F1}");
//     }
// }


// //CORREÇÃO: 
// Boletim boletim = new Boletim("Ana", 8, 6);
// ImpressoraDeBoletim impressoraDeBoletim = new ImpressoraDeBoletim();
// impressoraDeBoletim.Imprimir(boletim);

// // ======= CLASSES =======
// class Boletim
// {
//     public string Aluno { get; private set; }
//     public double Nota1 { get; private set; }
//     public double Nota2 { get; private set; }

//     public Boletim(string aluno, double nota1, double nota2)
//     {
//         Aluno = aluno;
//         Nota1 = nota1;
//         Nota2 = nota2;
//     }

//     public double Media()
//     {
//         return (Nota1 + Nota2) / 2;
//     }
// }

// class ImpressoraDeBoletim
// {
//     public void Imprimir(Boletim boletim)
//     {
//         Console.WriteLine($"{boletim.Aluno}: média {boletim.Media():F1}");
//     }
// }


//Exercício 2
// List<Arquivo> arquivos = new List<Arquivo>();
// arquivos.Add(new ArquivoDeTexto("notas.txt"));
// arquivos.Add(new ArquivoSomenteLeitura("manual.pdf"));

// foreach (Arquivo arquivo in arquivos)
// {
//     arquivo.Abrir();
// }

// foreach (Arquivo arquivo in arquivos)
// {
//     arquivo.Salvar();          // no manual.pdf, o programa cai
// }

// // ======= CLASSES =======
// class Arquivo
// {
//     public string Nome { get; private set; }

//     public Arquivo(string nome)
//     {
//         Nome = nome;
//     }

//     public void Abrir()
//     {
//         Console.WriteLine($"Abrindo {Nome}");
//     }

//     public virtual void Salvar()
//     {
//         Console.WriteLine($"Salvando {Nome}");
//     }
// }

// class ArquivoDeTexto : Arquivo
// {
//     public ArquivoDeTexto(string nome) : base(nome) { }
// }

// class ArquivoSomenteLeitura : Arquivo
// {
//     public ArquivoSomenteLeitura(string nome) : base(nome) { }

//     public override void Salvar()
//     {
//         throw new InvalidOperationException("Arquivo somente leitura!");
//     }
// }

// //CORREÇÃO:
// List<Arquivo> arquivos = new List<Arquivo>();
// ArquivoDeTexto notasTXT = new ArquivoDeTexto("notas.txt");
// arquivos.Add(notasTXT);
// ArquivoSomenteLeitura manualPDF = new ArquivoSomenteLeitura("manual.pdf");
// arquivos.Add(manualPDF);

// foreach (Arquivo arquivo in arquivos)
// {
//     arquivo.Abrir();
// }

// List<ISalvar> salvar = new List<ISalvar>();
// salvar.Add(notasTXT);
// // salvar.Add(manualPDF);

// foreach (ISalvar salva in salvar)
// {
//     salva.Salvar();
// }

// // ======= CLASSES =======
// class Arquivo
// {
//     public string Nome { get; private set; }

//     public Arquivo(string nome)
//     {
//         Nome = nome;
//     }

//     public void Abrir()
//     {
//         Console.WriteLine($"Abrindo {Nome}");
//     }    
// }

// interface ISalvar
// {
//     void Salvar();
// }

// class ArquivoDeTexto : Arquivo, ISalvar 
// {
//     public ArquivoDeTexto(string nome) : base(nome) { }
//     public void Salvar()
//     {
//         Console.WriteLine($"Salvando {Nome}");
//     }
// }

// class ArquivoSomenteLeitura : Arquivo
// {
//     public ArquivoSomenteLeitura(string nome) : base(nome) { }
// }


//Exercício 3
// Enviar("email", "Plantão começa às 7h");
// Enviar("sms", "Plantão começa às 7h");

// // ======= MÉTODOS =======
// void Enviar(string canal, string mensagem)
// {
//     if (canal == "email")
//     {
//         Console.WriteLine($"E-mail: {mensagem}");
//     }
//     else if (canal == "sms")
//     {
//         Console.WriteLine($"SMS: {mensagem}");
//     }
// }

//CORREÇÃO
List<IMensagem> mensagens = new List<IMensagem>();
mensagens.Add(new CanalEmail("E-mail", "Plantão começa às 7h"));
mensagens.Add(new CanalSMS("SMS", "Plantão começa às 7h"));
mensagens.Add(new CanalWhatsApp("WhatsApp", "Plantão começa às 7h"));

foreach (IMensagem mensagem in mensagens)
{
    mensagem.EnviarMensagem();
}

//======= CLASSES =======

interface IMensagem
{
    void EnviarMensagem();
}

class CanalEmail : IMensagem
{
    public string Nome { get; private set; }
    public string Mensagem { get; private set; }
    public CanalEmail (string nome, string mensagem)
    {
        Nome = nome;
        Mensagem = mensagem;
    }
    public void EnviarMensagem()
    {
        Console.WriteLine($"{Nome}: {Mensagem}");
    }
}

class CanalSMS : IMensagem
{
    public string Nome { get; private set; }
    public string Mensagem { get; private set; }
    public CanalSMS (string nome, string mensagem)
    {
        Nome = nome;
        Mensagem = mensagem;
    }
    public void EnviarMensagem()
    {
        Console.WriteLine($"{Nome}: {Mensagem}");
    }
}

class CanalWhatsApp : IMensagem
{
    public string Nome { get; private set; }
    public string Mensagem { get; private set; }
    public CanalWhatsApp (string nome, string mensagem)
    {
        Nome = nome;
        Mensagem = mensagem;
    }
    public void EnviarMensagem()
    {
        Console.WriteLine($"{Nome}: {Mensagem}");
    }
}


// List<ICanal> canais = new List<ICanal>();
// canais.Add(new CanalEmail());
// canais.Add(new CanalSms());
// canais.Add(new CanalWhatsApp());

// foreach (ICanal canal in canais)
// {
//     canal.Enviar("Plantão começa às 7h");
// }

// // ======= CLASSES =======
// interface ICanal
// {
//     void Enviar(string mensagem);
// }

// class CanalEmail : ICanal
// {
//     public void Enviar(string mensagem)
//     {
//         Console.WriteLine($"E-mail: {mensagem}");
//     }
// }

// class CanalSms : ICanal
// {
//     public void Enviar(string mensagem)
//     {
//         Console.WriteLine($"SMS: {mensagem}");
//     }
// }

// class CanalWhatsApp : ICanal
// {
//     public void Enviar(string mensagem)
//     {
//         Console.WriteLine($"WhatsApp: {mensagem}");
//     }
// }
