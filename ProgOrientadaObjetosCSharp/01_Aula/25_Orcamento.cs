using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Orcamento
{
    private int nroOrcamento;
    private int codConsumidor;
    private float valor;

    public void inserirDados(int nroOrcamento, Consumidor o_Consumidor, float valor)
    {
        this.nroOrcamento = nroOrcamento;
        
        codConsumidor = o_Consumidor.codConsumidor;
        
        this.valor = valor;
    }

    public void imprimirDados()
    {
        Console.WriteLine("Nro Orçamento: " + nroOrcamento);
        Console.WriteLine("Código do Consumidor: " + codConsumidor);
        Console.WriteLine("Valor: " + valor);        
    }
}

