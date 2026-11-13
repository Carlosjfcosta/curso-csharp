//Perguntas Rápidas
//1. Uma classe assina uma interface com 6 métodos, usa só 1 e deixa os outros 5 vazios. Qual princípio foi violado? a) Segregação de interface · b) Inversão de dependência · c) Aberto/fechado
//Letra a
//2. No construtor da Loja está escrito pagamento = new PagamentoCartao();, e para trocar a forma de pagamento é preciso abrir a Loja. Qual princípio foi violado? a) Substituição de Liskov · b) Responsabilidade única · c) Inversão de dependência
//Letra c
//3. Um método static recebe o texto "pdf" ou "excel" e devolve o exportador certo, ou null. Que padrão é esse, e de que família? a) Adapter, estrutural · b) Factory, criacional · c) Strategy, comportamental
//Letra b


//Exercício 1
// List<IFuncionario> equipe = new List<IFuncionario>();
// equipe.Add(new Vendedor());
// equipe.Add(new Estagiario());

// foreach (IFuncionario funcionario in equipe)
// {
//     funcionario.Trabalhar();
// }

// foreach (IFuncionario funcionario in equipe)
// {
//     funcionario.ReceberComissao(500);
// }

// // ======= CLASSES =======
// interface IFuncionario
// {
//     void Trabalhar();
//     void ReceberComissao(decimal valor);
// }

// class Vendedor : IFuncionario
// {
//     public void Trabalhar() { Console.WriteLine("Vendedor: atendendo clientes"); }
//     public void ReceberComissao(decimal valor) { Console.WriteLine($"Vendedor: comissão de {valor:C}"); }
// }

// class Estagiario : IFuncionario
// {
//     public void Trabalhar() { Console.WriteLine("Estagiário: organizando o estoque"); }
//     public void ReceberComissao(decimal valor) { }      // estagiário não recebe comissão
// }

// //CORREÇÃO
// List<ITrabalhandoEm> equipeTrabalho = new List<ITrabalhandoEm>();
// List<IComissao> equipeComissao = new List<IComissao>();

// Vendedor vendedor = new Vendedor();
// Estagiario estagiario = new Estagiario();

// equipeTrabalho.Add(vendedor);
// equipeTrabalho.Add(estagiario);
// equipeComissao.Add(vendedor);

// foreach (ITrabalhandoEm funcionario in equipeTrabalho)
// {
//     funcionario.Trabalhar();
// }

// foreach (IComissao funcionario in equipeComissao)
// {
//     funcionario.ReceberComissao(500);
// }

// // ======= CLASSES =======
// interface ITrabalhandoEm
// {
//     void Trabalhar();
// }

// interface IComissao
// {
//     void ReceberComissao(decimal valor);
// }

// class Vendedor : ITrabalhandoEm , IComissao
// {
//     public void Trabalhar() { Console.WriteLine("Vendedor: atendendo clientes"); }
//     public void ReceberComissao(decimal valor) { Console.WriteLine($"Vendedor: comissão de {valor:C}"); }
// }

// class Estagiario : ITrabalhandoEm
// {
//     public void Trabalhar() { Console.WriteLine("Estagiário: organizando o estoque"); }
// }


//Exercício 2
// Relatorio relatorio = new Relatorio();
// relatorio.Gerar("Ocorrências de outubro");

// // ======= CLASSES =======
// class Relatorio
// {
//     private ExportadorPdf exportador;

//     public Relatorio()
//     {
//         exportador = new ExportadorPdf();
//     }

//     public void Gerar(string titulo)
//     {
//         exportador.Exportar(titulo);
//     }
// }

// class ExportadorPdf
// {
//     public void Exportar(string titulo)
//     {
//         Console.WriteLine($"Exportando \"{titulo}\" em PDF");
//     }
// }

//CORREÇÃO
List<string> exportadores = new List<string>();
exportadores.Add("pdf");
exportadores.Add("excel");
exportadores.Add("word");

foreach (string tipo in exportadores)
{
    Exportador? exportador = FabricaDeExportador.Criar(tipo);
    if (exportador != null)
    {
        Relatorio relatorio = new Relatorio(exportador); 
        relatorio.Gerar("Ocorrências de outubro");
    }
    else
    {
        Console.WriteLine($"Formato {tipo} não suportado");
    }
}



// ======= CLASSES =======
class Relatorio
{
    private Exportador exportador;  
    public Relatorio(Exportador formato)
    {
        exportador = formato;
    }

    public void Gerar(string titulo)
    {
        Console.WriteLine(exportador.Exportar(titulo));
    }
}

abstract class Exportador
{
    public abstract string Exportar(string titulo);
}

class ExportadorPDF : Exportador { public override string Exportar(string titulo) { return $"Exportando \"{titulo}\" em PDF"; } }

class ExportadorExcel : Exportador { public override string Exportar(string titulo) { return $"Exportando \"{titulo}\" em Excel"; } }


class FabricaDeExportador
{
    public static Exportador? Criar(string tipo)
    {
        if (tipo == "pdf") { return new ExportadorPDF(); }
        if (tipo == "excel") { return new ExportadorExcel(); }
        return null;
    }
}