using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Estado
{
    public string nome;
    public string uf;
    public Governador governador;   // RELACIONAMENTO

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("UF: " + uf);

        if (governador != null)
        {
            // Problema de REFERÊNCIA CIRCULAR
            //governador.imprimirDados();

            Console.WriteLine("\t Nome: " + governador.nome);
            Console.WriteLine("\t CPF: " + governador.cpf);
        }
    }
}




