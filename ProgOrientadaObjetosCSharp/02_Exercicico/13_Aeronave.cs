using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Aeronave
{
    public int codAeronave;
    public string modelo;
    public List<VooTrecho> vooTrechos;  // RELACIONAMENTO

    public List<VooTrecho> VooTrechos{
        get{
            if (vooTrechos == null){
                vooTrechos = new List<VooTrecho>();
            }
            return vooTrechos;
        }
        set{
            if (vooTrechos == null){
                vooTrechos = new List<VooTrecho>();
            }
            vooTrechos = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Código: " + codAeronave);
        Console.WriteLine("Modelo: " + modelo);

        foreach (VooTrecho item in vooTrechos)
        {
            item.imprimirDados();
        }
    }
}

