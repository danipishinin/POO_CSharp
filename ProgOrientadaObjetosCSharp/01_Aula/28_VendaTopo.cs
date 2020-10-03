using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class VendaTopo
{
    public int nf;
    public DateTime dataVenda;
    private List<VendaItem> itens;

    public List<VendaItem> Itens
    {
        get
        {
            if (itens == null)
            {
                itens = new List<VendaItem>();
            }
            return itens;
        }
        set
        {
            if (itens == null)
            {
                itens = new List<VendaItem>();
            }
            itens = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Nro NF: " + nf);
        Console.WriteLine("DataVenda: " + dataVenda);

        if (itens != null)
        {
            foreach (VendaItem item in itens)
            {
                Console.WriteLine("\t Qtde: " + item.quantidade);
                Console.WriteLine("\t Preço unitário: " + item.vlrUnitario.ToString("N2"));
            }
        }
    }
}

