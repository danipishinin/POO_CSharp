using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Imovel
{
    public string endereco;
    public float aluguel;
    public Proprietario proprietario;   // RELACIONAMENTO

    public void imprimirDados()
    {
        Console.WriteLine("Endereço: " + endereco);
        Console.WriteLine("Aluguel: " + aluguel);

        if (proprietario != null)
        {
            Console.WriteLine("\t Nome: " + proprietario.nome);
            Console.WriteLine("\t Fone: " + proprietario.fone);
        }
    }
}

