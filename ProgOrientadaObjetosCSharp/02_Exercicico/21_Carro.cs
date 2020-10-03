using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Carro
{
    public string marca;
    public string modelo;

    public List<Motorista> condutores = new List<Motorista>();
    public List<Peca> pecas = new List<Peca>();

    public void imprimirDados()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);

        foreach (Motorista item in condutores)
        {
            Console.WriteLine("\t Nome: " + item.nome);
            Console.WriteLine("\t Idade: " + item.idade);
        }

        foreach (Peca item in pecas)
        {
            Console.WriteLine("\t Descrição: " + item.descricao);            
        }
    }
}

