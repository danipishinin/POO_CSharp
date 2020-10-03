using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Proprietario
{
    public string nome;
    public string fone;
    private List<Imovel> imoveis;   // RELACIONAMENTO

    public List<Imovel> Imoveis{
        get{
            if (imoveis == null){
                imoveis = new List<Imovel>();
            }
            return imoveis;
        }
        set{
            if (imoveis == null){
                imoveis = new List<Imovel>();
            }
            imoveis = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("fone: " + fone);

        if (imoveis != null)
        {
            foreach (Imovel item in imoveis)
            {
                Console.WriteLine("\t Endereço: " + item.endereco);
                Console.WriteLine("\t Aluguel: " + item.aluguel);
            }
        }
    }
}

