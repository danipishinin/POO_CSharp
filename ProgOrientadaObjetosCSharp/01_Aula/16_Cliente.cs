using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cliente
{
    public string nome;
    public string cidade;

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cidade: " + cidade);
    }
}

