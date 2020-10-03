using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Montadora
{
    public int codMontadora;
    public string nome;    
    private List<Veiculo> veiculos;     // RELACIONAMENTO

    public List<Veiculo> Veiculos{
        get{
            if (veiculos == null){
                veiculos = new List<Veiculo>();
            }
            return veiculos;
        }
        set{
            if (veiculos == null){
                veiculos = new List<Veiculo>();
            }
            veiculos = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Código: " + codMontadora);
        Console.WriteLine("Nome: " + nome);

        if (veiculos != null){
            
            foreach (Veiculo item in veiculos)
            {
                Console.WriteLine("\t Modelo: " + item.modelo);
                Console.WriteLine("\t Nro Portas: " + item.nroPortas);               
            }
        }
    }
}

