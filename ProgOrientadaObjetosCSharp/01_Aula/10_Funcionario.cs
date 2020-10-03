using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Funcionario
{
    public int codFunc;
    public string nome;
    public Computador notebook;     // RELACIONAMENTO
    public Tablet pdv;              // RELACIONAMENTO

    public void imprimirDados()
    {
        // Funcionário
        Console.WriteLine("Código Func: " + codFunc);
        Console.WriteLine("Nome: " + nome);

        // Computador
        if (notebook != null)
        {
            notebook.imprimirDados();
        }

        // Tablet
        if (pdv != null)
        {
            Console.WriteLine("Código Tablet: " + pdv.codTablet);
            Console.WriteLine("CDescrição: " + pdv.descricao);
        }
    }
}






