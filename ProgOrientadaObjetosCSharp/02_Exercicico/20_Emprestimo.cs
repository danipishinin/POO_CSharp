using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Emprestimo
{
    public int codConsumidor;
    public float valor;
    public int nroParcelas;

    public void efetuarEmprestimo(Consumidor o_Consumidor, float valor, int nroParcelas)
    {
        codConsumidor = o_Consumidor.codConsumidor;
        this.valor = valor;
        this.nroParcelas = nroParcelas;       
    }

    public void imprimirDados()
    {
        Console.WriteLine("Código: " + codConsumidor);
        Console.WriteLine("Valor: " + valor);
        Console.WriteLine("Nro Parcelas: " + nroParcelas);       
    }
}

