using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Computador
{
    public int codComputador;
    public string descricao;

    public void imprimirDados()
    {
        Console.WriteLine("Código Comp: " + codComputador);
        Console.WriteLine("Descrição: " + descricao);
    }
}

