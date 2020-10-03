using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClasseA
{
    public int Id;
}

public class ClasseB : ClasseA
{
    public string nome;
}

public class ClasseC : ClasseB
{
    public float valor;
}

public class ClasseD
{
    public void imprimirA(ClasseA o_clsA)
    {
        Console.WriteLine("ID: " + o_clsA.Id);
    }
    public void imprimirB(ClasseB o_clsB)
    {
        Console.WriteLine("ID: " + o_clsB.Id);
        Console.WriteLine("Nome: " + o_clsB.nome);
    }
    public void imprimirC(ClasseC o_clsC)
    {
        Console.WriteLine("ID: " + o_clsC.Id);
        Console.WriteLine("Nome: " + o_clsC.nome);
        Console.WriteLine("Valor: " + o_clsC.valor);
    }
}