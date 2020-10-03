using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Veiculo
{
    public string modelo;
    public int nroPortas;
    public Montadora montadora;    // RELACIONAMENTO    

    public void imprimirDados()
    {
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Nro Portas: " + nroPortas);

        if (montadora != null)
        {
            Console.WriteLine("\t Código: " + montadora.codMontadora);
            Console.WriteLine("\t Nome: " + montadora.nome);            
        }
    }
}

