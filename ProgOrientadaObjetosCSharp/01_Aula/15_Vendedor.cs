using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Vendedor
{
    public int codVendedor;
    public string nome;
    private List<Cliente> clientes;  // 0...*  // RELACIONAMENTO

    public List<Cliente> Clientes {
        get {
            if (clientes == null) {
                clientes = new List<Cliente>();
            }
            return clientes;
        }
        set
        {
            if (clientes == null){
                clientes = new List<Cliente>();
            }
            clientes = value;
        }
    }


    public void imprimirDados()
    {
        Console.WriteLine("Código: " + codVendedor);
        Console.WriteLine("Nome: " + nome);

        // 0...*
        if (clientes != null)
        {
            foreach (Cliente item in Clientes)
            {
                item.imprimirDados();
            }
        }
    }
}


