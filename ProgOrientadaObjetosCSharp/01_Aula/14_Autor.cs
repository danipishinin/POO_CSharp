using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Autor
{
    public int codAutor;
    public string nome;

    public void imprimirDados()
    {
        Console.WriteLine("\t Código: " + codAutor);
        Console.WriteLine("\t Nome: " + nome);
    }
}


