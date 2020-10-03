using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Empresa
{
    public string nome;
    public string cnpj;
    private List<Empresa> filiais;

    public List<Empresa> Filiais {
        get{
            if (filiais == null){
                filiais = new List<Empresa>();
            }
            return filiais;
        }
        set{
            if (filiais == null){
                filiais = new List<Empresa>();
            }
            filiais = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("CNPJ: " + cnpj);

        if (filiais != null)
        {
            foreach (Empresa item in filiais)
            {
                Console.WriteLine("\t Nome: " + item.nome);
                Console.WriteLine("\t CNPJ: " + item.cnpj);
            }
        }
    }
}

