using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Governador
{
    public string nome;
    public string cpf;
    public Estado estado;   // RELACIONAMENTO

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("CPF: " + cpf);

        if (estado != null)
        {
            // Problema de REFERÊNCIA CIRCULAR
            //Estado.imprimirDados();

            Console.WriteLine("\t Nome: " + estado.nome);
            Console.WriteLine("\t UF: " + estado.uf);
        }
    }
}

