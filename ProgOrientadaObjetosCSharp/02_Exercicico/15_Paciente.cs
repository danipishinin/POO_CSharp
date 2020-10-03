using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Paciente
{
    public string nome;
    public string fone;
    public Cartao cartao;  // RELACIONAMENTO  

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Fone: " + fone);

        if (cartao != null)
        {
            Console.WriteLine("\t Convênio: " + cartao.convenio);
            Console.WriteLine("\t Tipo: " + cartao.tipo);
        }
    }
}

